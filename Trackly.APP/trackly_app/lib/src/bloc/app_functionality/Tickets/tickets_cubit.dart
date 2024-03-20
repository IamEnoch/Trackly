import 'dart:async';

import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/tickets/tickets_state.dart';
import 'package:trackly_app/src/data/models/Tickets/ticket.dart';
import 'package:trackly_app/src/data/models/Tickets/ticket_status_update.dart';
import 'package:trackly_app/src/data/models/api_response.dart';
import 'package:trackly_app/src/data/services/providers/ticket_provider.dart';

class TicketCubit extends Cubit<TicketsState> {
  ///Singleton instance
  static final TicketCubit _instance = TicketCubit._internal();

  factory TicketCubit() {
    return _instance;
  }
  TicketCubit._internal() : super(TicketsInitial());
  final log = logger(TicketCubit);

  //Update ticket status
  Future<void> changeTicketStatus(
      String id, TicketStatusUpdate ticketStatusUpdate) async {
    emit(TicketStatusUpdateLoading());
    try {
      var response = await TicketProvider().changeTicketStatus(
        id,
        ticketStatusUpdate,
      );
      if (response.error) {
        log.e('The ticket status was not updated');
        emit(TicketStatusUpdateFailure(message: response.errorMessage));
        log.e(response.errorMessage);
        return;
      } else {
        log.d('The ticket status was updated');
        emit(TicketStatusUpdateSuccess());
      }
    } on Exception catch (e) {
      emit(TicketStatusUpdateFailure(message: e.toString()));
    }
  }

  //Get paginated assets
  Future<List<Ticket>> getCompletedPaginatedTickets(
      int currentPage, int pageSize) async {
    try {
      emit(TicketsLoading());
      ApiResponse<List<Ticket>?> assets = await TicketProvider()
          .getCompletedPaginatedTickets(currentPage, pageSize);

      // Check if there are assets. If not, do not fetch data again
      if (assets.response!.isEmpty) {
        emit(TicketsEmpty());
        //return an empty list of type asset
        return <Ticket>[];
      }

      emit(TicketsSuccess());
      return assets.response!;
    } catch (error) {
      // Handle errors
      emit(TicketsFailure(message: error.toString()));
      return <Ticket>[];
    }
  }

  //To ticket initial
  void toTicketInitial() {
    emit(TicketsInitial());
  }
}
