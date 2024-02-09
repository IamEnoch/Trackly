// To parse this JSON data, do
//
//     final user = userFromJson(jsonString);

import 'dart:convert';

AssetUpdate userFromJson(String str) => AssetUpdate.fromJson(json.decode(str));

String userToJson(AssetUpdate data) => json.encode(data.toJson());

class AssetUpdate {
  final String? barcodeNumber;
  final String? assetName;
  final String? category;
  final String? department;
  final String? location;
  final String? condition;
  final String? ram;
  final String? serialNumber;
  final String? assignedToId;
  final String? processor;
  final String? storage;
  final String? description;
  final DateTime? deletedAt;

  AssetUpdate({
    required this.barcodeNumber,
    required this.assetName,
    required this.category,
    required this.department,
    required this.location,
    required this.condition,
    required this.ram,
    required this.serialNumber,
    required this.assignedToId,
    required this.processor,
    required this.storage,
    required this.description,
    required this.deletedAt,
  });

  factory AssetUpdate.fromJson(Map<String, dynamic> json) => AssetUpdate(
        barcodeNumber: json["barcodeNumber"],
        assetName: json["assetName"],
        category: json["category"],
        department: json["department"],
        location: json["location"],
        condition: json["condition"],
        ram: json["ram"],
        serialNumber: json["serialNumber"],
        assignedToId: json["assignedToId"],
        processor: json["processor"],
        storage: json["storage"],
        description: json["description"],
        deletedAt: json["deletedAt"] == null
            ? null
            : DateTime.parse(json["deletedAt"]),
      );

  Map<String, dynamic> toJson() => {
        "barcodeNumber": barcodeNumber,
        "assetName": assetName,
        "category": category,
        "department": department,
        "location": location,
        "condition": condition,
        "ram": ram,
        "serialNumber": serialNumber,
        "assignedToId": assignedToId,
        "processor": processor,
        "storage": storage,
        "description": description,
        "deletedAt": deletedAt?.toIso8601String(),
      };
}
