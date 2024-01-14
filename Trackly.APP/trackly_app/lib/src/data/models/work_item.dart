class WorkItem {
  String title;
  String description;
  String priority;
  String category;
  String assetId;

  WorkItem({
    required this.title,
    required this.description,
    required this.priority,
    required this.category,
    required this.assetId,
  });

  //Convert the work item to a json object
  Map<String, dynamic> toJson() {
    return {
      'title': title,
      'description': description,
      'priority': priority,
      'category': category,
      'assetId': assetId,
    };
  }

  //Create a work item for from a json object
  factory WorkItem.fromJson(Map<String, dynamic> json) {
    return WorkItem(
      title: json['title'],
      description: json['description'],
      priority: json['priority'],
      category: json['category'],
      assetId: json['assetId'],
    );
  }
}
