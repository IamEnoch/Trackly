import 'package:trackly_app/src/data/enumhelper/enums.dart';
import 'package:trackly_app/src/data/models/Tickets/ticket.dart';

class Asset {
  final String barcodeNumber;
  final String assetId;
  final String assetName;
  final AssetCategory category;
  final DepartmentName departmentName;
  final LocationName locationName;
  final String description;
  final DateTime createdAt;
  final DateTime? updatedAt;
  final DateTime? deletedAt;
  final DateTime purchaseDate;
  final String purchaseCost;
  final String storage;
  final String processor;
  final String serialNumber;
  final String ram;
  final String assignedTo;
  final Condition condition;
  List<Ticket> tickets;

  Asset({
    required this.barcodeNumber,
    required this.assetId,
    required this.assetName,
    required this.category,
    required this.departmentName,
    required this.locationName,
    required this.description,
    required this.createdAt,
    required this.updatedAt,
    required this.deletedAt,
    required this.purchaseDate,
    required this.purchaseCost,
    required this.storage,
    required this.processor,
    required this.serialNumber,
    required this.ram,
    required this.assignedTo,
    required this.condition,
    required this.tickets,
  });

  factory Asset.fromJson(Map<String, dynamic> json) {
    return Asset(
      barcodeNumber: json["barcodeNumber"],
      assetId: json["assetId"],
      assetName: json["assetName"],
      category: assetCategoryValues.map[json["category"]]!,
      departmentName: departmentNameValues.map[json["departmentName"]]!,
      locationName: locationNameValues.map[json["locationName"]]!,
      description: json["description"],
      createdAt: DateTime.parse(json["createdAt"]),
      updatedAt: json["updatedAt"],
      deletedAt:
          json["deletedAt"] == null ? null : DateTime.parse(json["deletedAt"]),
      purchaseDate: DateTime.parse(json["purchaseDate"]),
      purchaseCost: json["purchaseCost"],
      storage: json["storage"],
      processor: json["processor"],
      serialNumber: json["serialNumber"],
      ram: json["ram"],
      assignedTo: json["assignedTo"],
      condition: conditionValues.map[json["condition"]]!,
      tickets:
          List<Ticket>.from(json["tickets"].map((x) => Ticket.fromJson(x))),
    );
  }

  Map<String, dynamic> toJson() => {
        "barcodeNumber": barcodeNumber,
        "assetId": assetId,
        "assetName": assetName,
        "category": assetCategoryValues.reverse[category],
        "departmentName": departmentNameValues.reverse[departmentName],
        "locationName": locationNameValues.reverse[locationName],
        "description": description,
        "createdAt":
            "${createdAt.year.toString().padLeft(4, '0')}-${createdAt.month.toString().padLeft(2, '0')}-${createdAt.day.toString().padLeft(2, '0')}",
        "updatedAt": updatedAt,
        "deletedAt":
            "${deletedAt!.year.toString().padLeft(4, '0')}-${deletedAt!.month.toString().padLeft(2, '0')}-${deletedAt!.day.toString().padLeft(2, '0')}",
        "purchaseDate":
            "${purchaseDate.year.toString().padLeft(4, '0')}-${purchaseDate.month.toString().padLeft(2, '0')}-${purchaseDate.day.toString().padLeft(2, '0')}",
        "purchaseCost": purchaseCost,
        "storage": storage,
        "processor": processor,
        "serialNumber": serialNumber,
        "ram": ram,
        "assignedTo": assignedTo,
        "condition": conditionValues.reverse[condition],
        "tickets": List<dynamic>.from(tickets.map((x) => x.toJson())),
      };
}
