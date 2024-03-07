import 'dart:convert';

import 'package:trackly_app/src/data/models/Assets/asset.dart';
import 'package:trackly_app/src/data/models/WorkItems/work_item.dart';

// PagedItems pagedAssetsFromJson(String str) =>
//     PagedItems.fromJson(json.decode(str));

//String pagedAssetsToJson(PagedItems data) => json.encode(data.toJson());

class PageedAssets {
  final int pageNumber;
  final int totalCount;
  final int recordNumber;
  final List<Asset> items;

  PageedAssets({
    required this.pageNumber,
    required this.totalCount,
    required this.recordNumber,
    required this.items,
  });

  factory PageedAssets.fromJson(Map<String, dynamic> json) => PageedAssets(
        pageNumber: json["pageNumber"],
        totalCount: json["totalCount"],
        recordNumber: json["recordNumber"],
        items: List<Asset>.from(json["items"].map((x) => Asset.fromJson(x))),
      );
}

class PageedWorkItems {
  final int pageNumber;
  final int totalCount;
  final int recordNumber;
  final List<WorkItem> items;

  PageedWorkItems({
    required this.pageNumber,
    required this.totalCount,
    required this.recordNumber,
    required this.items,
  });

  factory PageedWorkItems.fromJson(Map<String, dynamic> json) =>
      PageedWorkItems(
        pageNumber: json["pageNumber"],
        totalCount: json["totalCount"],
        recordNumber: json["recordNumber"],
        items:
            List<WorkItem>.from(json["items"].map((x) => WorkItem.fromJson(x))),
      );
}
