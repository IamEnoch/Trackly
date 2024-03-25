import 'package:trackly_app/src/data/models/Tickets/ticket.dart';
import 'package:trackly_app/src/data/models/Tickets/ticket_status_update.dart';
import 'package:trackly_app/src/data/models/api_response.dart';
import 'package:trackly_app/src/data/services/repositories/ticket_repository.dart';

class TicketProvider {
  Future<ApiResponse<void>> changeTicketStatus(
      String id, TicketStatusUpdate ticketStatusUpdate) async {
    return await TicketRepository().changeTicketStatus(
      id,
      ticketStatusUpdate,
    );
  }

  Future<ApiResponse<List<Ticket>?>> getCompletedPaginatedTickets(
      int pageNumber, int pageSize) async {
    return await TicketRepository()
        .getCompletedPaginatedTickets(pageNumber, pageSize);
  }

  Future<ApiResponse<List<Ticket>?>> getUserAssignedTickets(
    int pageNumber,
    int pageSize,
  ) async {
    return await TicketRepository()
        .getUserAssignedTickets(pageNumber, pageSize);
  }
}
