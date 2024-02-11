// To parse this JSON data, do
//
//     final assetCreate = assetCreateFromJson(jsonString);

import 'dart:convert';

AssetCreate assetCreateFromJson(String str) =>
    AssetCreate.fromJson(json.decode(str));

String assetCreateToJson(AssetCreate data) => json.encode(data.toJson());

class AssetCreate {
  final String barcodeNumber;
  final String assetName;
  final String category;
  final String departmentName;
  final String locationName;
  final String serialNumber;
  final String? description;
  final String condition;
  final String? ram;
  final String assignedTo;
  final String? processor;
  final String? storage;
  final double purchaseCost;
  final DateTime purchaseDate;

  AssetCreate({
    required this.barcodeNumber,
    required this.assetName,
    required this.category,
    required this.departmentName,
    required this.locationName,
    required this.serialNumber,
    required this.description,
    required this.condition,
    required this.ram,
    required this.assignedTo,
    required this.processor,
    required this.storage,
    required this.purchaseCost,
    required this.purchaseDate,
  });

  factory AssetCreate.fromJson(Map<String, dynamic> json) => AssetCreate(
        barcodeNumber: json["barcodeNumber"],
        assetName: json["assetName"],
        category: json["category"],
        departmentName: json["departmentName"],
        locationName: json["locationName"],
        serialNumber: json["serialNumber"],
        description: json["description"],
        condition: json["condition"],
        ram: json["ram"],
        assignedTo: json["assignedTo"],
        processor: json["processor"],
        storage: json["storage"],
        purchaseCost: json["purchaseCost"],
        purchaseDate: DateTime.parse(json["purchaseDate"]),
      );

  Map<String, dynamic> toJson() => {
        "barcodeNumber": barcodeNumber,
        "assetName": assetName,
        "category": category,
        "departmentName": departmentName,
        "locationName": locationName,
        "serialNumber": serialNumber,
        "description": description,
        "condition": condition,
        "ram": ram,
        "assignedTo": assignedTo,
        "processor": processor,
        "storage": storage,
        "purchaseCost": purchaseCost,
        "purchaseDate": purchaseDate.toIso8601String(),
      };
}
