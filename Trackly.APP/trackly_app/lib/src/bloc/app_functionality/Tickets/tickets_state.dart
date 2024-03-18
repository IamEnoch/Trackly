import 'package:equatable/equatable.dart';
import 'package:trackly_app/src/data/models/Tickets/ticket.dart';

class TicketsState extends Equatable {
  const TicketsState();

  @override
  List<Object> get props => [];
}

class TicketsInitial extends TicketsState {}

final class TicketsLoading extends TicketsState {}

final class TicketsEmpty extends TicketsState {}

final class TicketsSuccess extends TicketsState {}

final class TicketsFailure extends TicketsState {
  final String message;

  const TicketsFailure({required this.message});

  @override
  List<Object> get props => [message];
}

//Asset related states
final class TicketLoading extends TicketsState {}

final class TicketCreated extends TicketsState {}

final class TicketUpdated extends TicketsState {}

final class TicketDeleted extends TicketsState {}

final class TicketFetched extends TicketsState {
  final Ticket ticket;

  const TicketFetched({required this.ticket});

  @override
  List<Object> get props => [ticket];
}

final class TicketFailure extends TicketsState {
  final String message;

  const TicketFailure({required this.message});

  @override
  List<Object> get props => [message];
}
