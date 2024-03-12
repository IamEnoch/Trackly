class WorkItemStatusUpdate {
  String workItemStatus;

  WorkItemStatusUpdate({
    required this.workItemStatus,
  });

  factory WorkItemStatusUpdate.fromJson(Map<String, dynamic> json) =>
      WorkItemStatusUpdate(
        workItemStatus: json["workItemStatus"],
      );

  Map<String, dynamic> toJson() => {
        "workItemStatus": workItemStatus,
      };
}
