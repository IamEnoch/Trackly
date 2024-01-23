import 'dart:convert';

import 'package:trackly_app/src/data/models/Assets/asset.dart';

PagedAssets pagedAssetsFromJson(String str) =>
    PagedAssets.fromJson(json.decode(str));

String pagedAssetsToJson(PagedAssets data) => json.encode(data.toJson());

class PagedAssets {
  final int pageNumber;
  final int totalCount;
  final int recordNumber;
  final List<Asset> items;

  PagedAssets({
    required this.pageNumber,
    required this.totalCount,
    required this.recordNumber,
    required this.items,
  });

  factory PagedAssets.fromJson(Map<String, dynamic> json) => PagedAssets(
        pageNumber: json["pageNumber"],
        totalCount: json["totalCount"],
        recordNumber: json["recordNumber"],
        items: List<Asset>.from(json["items"].map((x) => Asset.fromJson(x))),
      );

  Map<String, dynamic> toJson() => {
        "pageNumber": pageNumber,
        "totalCount": totalCount,
        "recordNumber": recordNumber,
        "items": List<dynamic>.from(items.map((x) => x.toJson())),
      };
}
