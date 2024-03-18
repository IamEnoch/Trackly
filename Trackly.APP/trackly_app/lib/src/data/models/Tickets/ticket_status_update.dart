class TicketStatusUpdate {
  String ticketStatus;

  TicketStatusUpdate({
    required this.ticketStatus,
  });

  factory TicketStatusUpdate.fromJson(Map<String, dynamic> json) =>
      TicketStatusUpdate(
        ticketStatus: json["workItemStatus"],
      );

  Map<String, dynamic> toJson() => {
        "workItemStatus": ticketStatus,
      };
}
