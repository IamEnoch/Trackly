import 'package:intl/intl.dart';

class Ticket {
  String title;
  String description;
  String status;
  String priority;
  String category;
  String assignedUser;
  String createdAt;
  String date;
  String time;

  Ticket({
    required this.title,
    required this.description,
    required this.status,
    required this.priority,
    required this.category,
    required this.assignedUser,
    required this.createdAt,
    required this.date,
    required this.time,
  });

  factory Ticket.fromJson(Map<String, dynamic> json) {
    //created time is in this format(2023-10-02T22:00:10.8161816). Want to create date/time from createdAt
    String createdAt = json['createdAt'];
    DateTime parsedCreatedAt = DateTime.parse(createdAt);
    //Date string only
    final dateString = DateFormat.yMMMd().format(parsedCreatedAt);
    final timeString = DateFormat.jm().format(parsedCreatedAt);

    // String date = DateFormat.yMMMd().format(parsedCreatedAt);
    // String time = DateFormat.jm().format(parsedCreatedAt);

    return Ticket(
      title: json['title'],
      description: json['description'],
      status: json['status'],
      priority: json['priority'],
      category: json['category'],
      assignedUser: json['assignedUser'],
      createdAt: dateString,
      date: dateString,
      time: timeString,
    );
  }
}
