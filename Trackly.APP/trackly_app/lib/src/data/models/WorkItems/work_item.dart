// To parse this JSON data, do
//
//     final assetCreate = assetCreateFromJson(jsonString);

import 'dart:convert';

import 'package:trackly_app/src/data/enumhelper/enums.dart';

WorkItem assetCreateFromJson(String str) => WorkItem.fromJson(json.decode(str));

String assetCreateToJson(WorkItem data) => json.encode(data.toJson());

class WorkItem {
  final String workItemId;
  final String title;
  final String description;
  final Status status;
  final Priority priority;
  final Category category;
  final String? creatorUserId;
  final String assetId;
  final DateTime createdAt;

  WorkItem({
    required this.workItemId,
    required this.title,
    required this.description,
    required this.status,
    required this.priority,
    required this.category,
    required this.creatorUserId,
    required this.assetId,
    required this.createdAt,
  });

  factory WorkItem.fromJson(Map<String, dynamic> json) => WorkItem(
        workItemId: json["workItemId"],
        title: json["title"],
        description: json["description"],
        status: statusValues.map[json["status"]]!,
        priority: priorityValues.map[json["priority"]]!,
        category: categoryValues.map[json["category"]]!,
        creatorUserId: json["creatorUserId"],
        assetId: json["assetId"],
        createdAt: DateTime.parse(json["createdAt"]),
      );

  Map<String, dynamic> toJson() => {
        "workItemId": workItemId,
        "title": title,
        "description": description,
        "status": statusValues.reverse[status],
        "priority": priorityValues.reverse[priority],
        "category": categoryValues.reverse[category],
        "creatorUserId": creatorUserId,
        "assetId": assetId,
        "createdAt":
            "${createdAt.year.toString().padLeft(4, '0')}-${createdAt.month.toString().padLeft(2, '0')}-${createdAt.day.toString().padLeft(2, '0')}",
      };
}
