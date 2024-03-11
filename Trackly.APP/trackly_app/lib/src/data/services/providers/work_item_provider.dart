import 'package:trackly_app/src/data/models/WorkItems/work_item_create.dart';
import 'package:trackly_app/src/data/models/WorkItems/work_item_status_update.dart';
import 'package:trackly_app/src/data/models/api_response.dart';
import 'package:trackly_app/src/data/models/WorkItems/work_item.dart';
import 'package:trackly_app/src/data/services/repositories/work_item_repository.dart';

class WorkItemProvider {
  //Create work item
  Future<ApiResponse<void>> createWorkItem(WorkItemCreate workItem) {
    return WorkItemRepository().createWorkItem(workItem);
  }

  //Update work item status
  Future<ApiResponse<void>> changeWorkItemStatus(
      String id, WorkItemStatusUpdate workItemStatusUpdate) {
    return WorkItemRepository().changeWorkItemStatus(id, workItemStatusUpdate);
  }

  //Get paginated work items
  Future<ApiResponse<List<WorkItem>>> getWorkItems(
      int pageNumber, int pageSize) {
    return WorkItemRepository().getWorkItems(pageNumber, pageSize);
  }
}
