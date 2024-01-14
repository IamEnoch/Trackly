import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/workItems/work_item_state.dart';
import 'package:trackly_app/src/data/models/work_item.dart';
import 'package:trackly_app/src/data/services/providers/ticket_provider.dart';

class WorkItemCubit extends Cubit<WorkItemState> {
  WorkItemCubit() : super(WorkItemInitial());
  final log = logger(WorkItemCubit);

  Future<void> createWorkItem(WorkItem workItem) async {
    emit(WorkItemLoading());
    try {
      var response = await TicketProvider().createWorkItem(workItem);
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
}
