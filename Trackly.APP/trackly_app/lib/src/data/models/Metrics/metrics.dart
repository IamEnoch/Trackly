class Metrics {
  int totalAssets;
  int assetsUnderMaintenance;
  int assetsNotUnderMaintenance;
  int totalTickets;
  AssetConditionMetrics assetConditionMetrics;
  TicketStatusMetrics ticketStatusMetrics;

  Metrics({
    required this.totalAssets,
    required this.assetsUnderMaintenance,
    required this.assetsNotUnderMaintenance,
    required this.totalTickets,
    required this.assetConditionMetrics,
    required this.ticketStatusMetrics,
  });

  factory Metrics.fromJson(Map<String, dynamic> json) => Metrics(
        totalAssets: json["totalAssets"],
        assetsUnderMaintenance: json["assetsUnderMaintenance"],
        assetsNotUnderMaintenance: json["assetsNotUnderMaintenance"],
        totalTickets: json["totalTickets"],
        assetConditionMetrics:
            AssetConditionMetrics.fromJson(json["assetsConditionMetrics"]),
        ticketStatusMetrics:
            TicketStatusMetrics.fromJson(json["ticketsStatusMetrics"]),
      );

  Map<String, dynamic> toJson() => {
        "totalAssets": totalAssets,
        "assetsUnderMaintenance": assetsUnderMaintenance,
        "assetsNotUnderMaintenance": assetsNotUnderMaintenance,
        "totalTickets": totalTickets,
        "assetsConditionMetrics": assetConditionMetrics,
        "ticketsStatusMetrics": ticketStatusMetrics,
      };
}

class AssetConditionMetrics {
  int New;
  int Good;
  int Fair;
  int Broken;
  int Poor;

  AssetConditionMetrics({
    required this.New,
    required this.Good,
    required this.Fair,
    required this.Broken,
    required this.Poor,
  });

  factory AssetConditionMetrics.fromJson(Map<String, dynamic> json) =>
      AssetConditionMetrics(
        New: json["new"],
        Good: json["good"],
        Fair: json["fair"],
        Broken: json["broken"],
        Poor: json["poor"],
      );

  Map<String, dynamic> toJson() => {
        "new": New,
        "good": Good,
        "fair": Fair,
        "broken": Broken,
        "poor": Poor,
      };
}

class TicketStatusMetrics {
  int open;
  int closed;
  int inProgress;
  int completed;

  TicketStatusMetrics({
    required this.open,
    required this.closed,
    required this.inProgress,
    required this.completed,
  });

  factory TicketStatusMetrics.fromJson(Map<String, dynamic> json) =>
      TicketStatusMetrics(
        open: json["open"],
        inProgress: json["inProgress"],
        completed: json["completed"],
        closed: json["closed"],
      );

  Map<String, dynamic> toJson() => {
        "open": open,
        "inProgress": inProgress,
        "completed": completed,
        "closed": closed,
      };
}
