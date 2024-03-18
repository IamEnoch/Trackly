import 'package:trackly_app/src/data/models/Assets/asset.dart';
import 'package:trackly_app/src/data/models/Tickets/ticket.dart';
import 'package:trackly_app/src/data/models/WorkItems/work_item.dart';

// PagedItems pagedAssetsFromJson(String str) =>
//     PagedItems.fromJson(json.decode(str));

//String pagedAssetsToJson(PagedItems data) => json.encode(data.toJson());

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
}

class PagedWorkItems {
  final int pageNumber;
  final int totalCount;
  final int recordNumber;
  final List<WorkItem> items;

  PagedWorkItems({
    required this.pageNumber,
    required this.totalCount,
    required this.recordNumber,
    required this.items,
  });

  factory PagedWorkItems.fromJson(Map<String, dynamic> json) => PagedWorkItems(
        pageNumber: json["pageNumber"],
        totalCount: json["totalCount"],
        recordNumber: json["recordNumber"],
        items:
            List<WorkItem>.from(json["items"].map((x) => WorkItem.fromJson(x))),
      );
}

class PagedTickets {
  final int pageNumber;
  final int totalCount;
  final int recordNumber;
  final List<Ticket> items;

  PagedTickets({
    required this.pageNumber,
    required this.totalCount,
    required this.recordNumber,
    required this.items,
  });

  factory PagedTickets.fromJson(Map<String, dynamic> json) => PagedTickets(
        pageNumber: json["pageNumber"],
        totalCount: json["totalCount"],
        recordNumber: json["recordNumber"],
        items: List<Ticket>.from(json["items"].map((x) => Ticket.fromJson(x))),
      );
}
