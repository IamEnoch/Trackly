import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/workItems/work_item_state.dart';
import 'package:trackly_app/src/data/models/WorkItems/work_item.dart';
import 'package:trackly_app/src/data/models/WorkItems/work_item_create.dart';
import 'package:trackly_app/src/data/models/WorkItems/work_item_status_update.dart';
import 'package:trackly_app/src/data/models/api_response.dart';
import 'package:trackly_app/src/data/services/providers/work_item_provider.dart';

class WorkItemCubit extends Cubit<WorkItemState> {
  WorkItemCubit() : super(WorkItemInitial());
  final log = logger(WorkItemCubit);

  //Create work item
  Future<void> createWorkItem(WorkItemCreate workItem) async {
    emit(WorkItemLoading());
    try {
      var response = await WorkItemProvider().createWorkItem(workItem);
      if (response.error) {
        log.e('The work item was not created');
        emit(WorkItemFailure(message: response.errorMessage));
        log.e(response.errorMessage);
        return;
      } else {
        log.d('The work item was created');
        emit(WorkItemCreated());
      }
    } on Exception catch (e) {
      emit(WorkItemFailure(message: e.toString()));
    }
  }

  //Update work item status
  Future<void> changeWorkItemStatus(
      String workItemId, WorkItemStatusUpdate workItemStatusUpdate) async {
    emit(WorkItemStatusUpdateLoading());
    try {
      var response = await WorkItemProvider()
          .changeWorkItemStatus(workItemId, workItemStatusUpdate);
      if (response.error) {
        log.e('The work item status was not updated');
        emit(WorkItemStatusUpdateFailure(message: response.errorMessage));
        log.e(response.errorMessage);
        return;
      } else {
        log.d('The work item status was updated');
        emit(WorkItemStatusUpdateSucess());
      }
    } on Exception catch (e) {
      emit(WorkItemStatusUpdateFailure(message: e.toString()));
    }
  }

  //Get paginated work items
  Future<List<WorkItem>> getWorkItems(int currentPage, int pageSize) async {
    emit(WorkItemsLoading());
    try {
      ApiResponse<List<WorkItem>> workItems =
          await WorkItemProvider().getWorkItems(currentPage, pageSize);

      // Check if there are workItems. If not, do not fetch data again
      if (workItems.response!.isEmpty) {
        emit(WorkItemsEmpty());
        //return an empty list of type asset
        return <WorkItem>[];
      }

      emit(WorkItemsSuccess());
      return workItems.response!;
    } catch (error) {
      // Handle errors
      emit(WorkItemsFailure(message: error.toString()));
      return <WorkItem>[];
    }
  }
}
