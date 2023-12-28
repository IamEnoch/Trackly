import 'package:trackly_app/src/data/models/ticket.dart';

class Asset {
  String barcodeNumber;
  String assetName;
  String category;
  String departmentName;
  String locationName;
  List<Ticket> tickets;

  Asset({
    required this.barcodeNumber,
    required this.assetName,
    required this.category,
    required this.departmentName,
    required this.locationName,
    required this.tickets,
  });

  factory Asset.fromJson(Map<String, dynamic> json) {
    List<dynamic> ticketList = json['tickets'];
    List<Ticket> parsedTickets =
        ticketList.map((ticket) => Ticket.fromJson(ticket)).toList();

    return Asset(
      barcodeNumber: json['barcodeNumber'],
      assetName: json['assetName'],
      category: json['category'],
      departmentName: json['departmentName'],
      locationName: json['locationName'],
      tickets: parsedTickets,
    );
  }
}
