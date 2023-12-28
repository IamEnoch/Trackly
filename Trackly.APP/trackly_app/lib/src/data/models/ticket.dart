class Ticket {
  String title;
  String description;
  String status;
  String priority;
  String category;
  String assignedUser;

  Ticket({
    required this.title,
    required this.description,
    required this.status,
    required this.priority,
    required this.category,
    required this.assignedUser,
  });

  factory Ticket.fromJson(Map<String, dynamic> json) {
    return Ticket(
      title: json['title'],
      description: json['description'],
      status: json['status'],
      priority: json['priority'],
      category: json['category'],
      assignedUser: json['assignedUser'],
    );
  }
}
