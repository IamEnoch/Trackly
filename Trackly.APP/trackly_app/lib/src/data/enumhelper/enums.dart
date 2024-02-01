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

enum Category { hardware, network, other, software }

final categoryValues = EnumValues({
  "Hardware": Category.hardware,
  "Network": Category.network,
  "Other": Category.other,
  "Software": Category.software
});

enum Priority { high, low, medium }

final priorityValues = EnumValues(
    {"High": Priority.high, "Low": Priority.low, "Medium": Priority.medium});

enum Status { closed, completed, inprogress, open }

final statusValues = EnumValues({
  "Closed": Status.closed,
  "Completed": Status.completed,
  "InProgress": Status.inprogress,
  "Open": Status.open
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
