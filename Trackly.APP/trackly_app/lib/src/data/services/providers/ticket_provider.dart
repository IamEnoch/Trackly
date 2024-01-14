import 'package:trackly_app/src/data/models/api_response.dart';
import 'package:trackly_app/src/data/models/work_item.dart';
import 'package:trackly_app/src/data/services/repositories/ticket_repository.dart';

class TicketProvider {
  Future<ApiResponse<void>> createWorkItem(WorkItem workItem) {
    return TicketRepository().createWorkItem(workItem);
  }
}
