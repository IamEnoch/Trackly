import 'package:trackly_app/src/data/enumhelper/enums.dart';

class Ticket {
  final dynamic id;
  final String title;
  final String description;
  final Status status;
  final Priority priority;
  final Category category;
  final String assignedUser;
  final DateTime createdAt;
  final DateTime? completedAt;
  final DateTime? closedAt;

  Ticket({
    required this.id,
    required this.title,
    required this.description,
    required this.status,
    required this.priority,
    required this.category,
    required this.assignedUser,
    required this.createdAt,
    required this.completedAt,
    required this.closedAt,
  });

  factory Ticket.fromJson(Map<String, dynamic> json) => Ticket(
        id: json["id"],
        title: json["title"],
        description: json["description"],
        status: statusValues.map[json["status"]]!,
        priority: priorityValues.map[json["priority"]]!,
        category: categoryValues.map[json["category"]]!,
        assignedUser: json["assignedUser"],
        createdAt: DateTime.parse(json["createdAt"]),
        completedAt: json["completedAt"] == null
            ? null
            : DateTime.parse(json["completedAt"]),
        closedAt:
            json["closedAt"] == null ? null : DateTime.parse(json["closedAt"]),
      );

  Map<String, dynamic> toJson() => {
        "id": id,
        "title": title,
        "description": description,
        "status": statusValues.reverse[status],
        "priority": priorityValues.reverse[priority],
        "category": categoryValues.reverse[category],
        "assignedUser": assignedUser,
        "createdAt": createdAt.toIso8601String(),
        "completedAt": completedAt?.toIso8601String(),
        "closedAt": closedAt?.toIso8601String(),
      };
}
