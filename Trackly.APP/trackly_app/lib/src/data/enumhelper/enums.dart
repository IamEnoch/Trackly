enum DepartmentName { finance, hr, it }

final departmentNameValues = EnumValues({
  "Finance": DepartmentName.finance,
  "HR": DepartmentName.hr,
  "IT": DepartmentName.it
});

enum LocationName { home, office, other }

final locationNameValues = EnumValues({
  "Home": LocationName.home,
  "Office": LocationName.office,
  "Other": LocationName.other
});

enum Category { Hardware, Network, Other, Software }

final categoryValues = EnumValues({
  "Hardware": Category.Hardware,
  "Network": Category.Network,
  "Other": Category.Other,
  "Software": Category.Software
});

enum Priority { High, Low, Medium }

final priorityValues = EnumValues({
  "High": Priority.High,
  "Low": Priority.Low,
  "Medium": Priority.Medium,
});

enum TicketStatus { Closed, Completed, Inprogress, Open }

final statusValues = EnumValues({
  "Closed": TicketStatus.Closed,
  "Completed": TicketStatus.Completed,
  "InProgress": TicketStatus.Inprogress,
  "Open": TicketStatus.Open
});

enum WorkItemStatus { pending, approved, rejected }

final workItemStatusValues = EnumValues({
  "Pending": WorkItemStatus.pending,
  "Approved": WorkItemStatus.approved,
  "Rejected": WorkItemStatus.rejected,
});

enum AssetCategory {
  DESKTOP,
  LAPTOP,
  MONITOR,
  OTHER,
  PRINTER,
  PROJECTOR,
  SCANNER
}

final assetCategoryValues = EnumValues({
  "Desktop": AssetCategory.DESKTOP,
  "Laptop": AssetCategory.LAPTOP,
  "Monitor": AssetCategory.MONITOR,
  "Other": AssetCategory.OTHER,
  "Printer": AssetCategory.PRINTER,
  "Projector": AssetCategory.PROJECTOR,
  "Scanner": AssetCategory.SCANNER
});

enum Condition { BROKEN, FAIR, GOOD, NEW, POOR }

final conditionValues = EnumValues({
  "Broken": Condition.BROKEN,
  "Fair": Condition.FAIR,
  "Good": Condition.GOOD,
  "New": Condition.NEW,
  "Poor": Condition.POOR
});

class EnumValues<T> {
  Map<String, T> map;
  late Map<T, String> reverseMap;

  EnumValues(this.map);

  Map<T, String> get reverse {
    reverseMap = map.map((k, v) => MapEntry(v, k));
    return reverseMap;
  }
}
