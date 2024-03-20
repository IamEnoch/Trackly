class TicketStatusUpdate {
  String ticketStatus;

  TicketStatusUpdate({
    required this.ticketStatus,
  });

  factory TicketStatusUpdate.fromJson(Map<String, dynamic> json) =>
      TicketStatusUpdate(
        ticketStatus: json["status"],
      );

  Map<String, dynamic> toJson() => {
        "status": ticketStatus,
      };
}
