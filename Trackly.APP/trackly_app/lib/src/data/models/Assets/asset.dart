import 'package:trackly_app/src/data/enumhelper/enums.dart';
import 'package:trackly_app/src/data/models/Tickets/ticket.dart';

class Asset {
  String barcodeNumber;
  String assetId;
  String assetName;
  String category;
  String departmentName;
  String locationName;
  List<Ticket> tickets;

  Asset({
    required this.barcodeNumber,
    required this.assetName,
    required this.assetId,
    required this.category,
    required this.departmentName,
    required this.locationName,
    required this.tickets,
  });

  factory Asset.fromJson(Map<String, dynamic> json) {
    return Asset(
      barcodeNumber: json['barcodeNumber'],
      assetId: json['assetId'],
      assetName: json['assetName'],
      category: json['category'],
      departmentName: json['departmentName'],
      locationName: json['locationName'],
      tickets:
          List<Ticket>.from(json["tickets"].map((x) => Ticket.fromJson(x))),
    );
  }

  Map<String, dynamic> toJson() => {
        "barcodeNumber": barcodeNumber,
        "assetId": assetId,
        "assetName": assetName,
        "category": category,
        "departmentName": departmentNameValues.reverse[departmentName],
        "locationName": locationNameValues.reverse[locationName],
        "tickets": List<dynamic>.from(tickets.map((x) => x.toJson())),
      };
}
