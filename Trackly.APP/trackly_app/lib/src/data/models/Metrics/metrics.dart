class Metrics {
  int totalAssets;
  int assetsUnderMaintenance;
  int assetsNotUnderMaintenance;
  int totalTickets;

  Metrics({
    required this.totalAssets,
    required this.assetsUnderMaintenance,
    required this.assetsNotUnderMaintenance,
    required this.totalTickets,
  });

  factory Metrics.fromJson(Map<String, dynamic> json) => Metrics(
        totalAssets: json["totalAssets"],
        assetsUnderMaintenance: json["assetsUnderMaintenance"],
        assetsNotUnderMaintenance: json["assetsNotUnderMaintenance"],
        totalTickets: json["totalTickets"],
      );

  Map<String, dynamic> toJson() => {
        "totalAssets": totalAssets,
        "assetsUnderMaintenance": assetsUnderMaintenance,
        "assetsNotUnderMaintenance": assetsNotUnderMaintenance,
        "totalTickets": totalTickets,
      };
}
