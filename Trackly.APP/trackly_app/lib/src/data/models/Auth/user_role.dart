import 'dart:convert';

class UserRole {
  String id;
  String name;
  String description;

  UserRole({
    required this.id,
    required this.name,
    required this.description,
  });

  factory UserRole.fromJson(Map<String, dynamic> json) => UserRole(
        id: json["id"],
        name: json["name"],
        description: json["description"],
      );

  Map<String, dynamic> toJson() => {
        "id": id,
        "name": name,
        "description": description,
      };

  static List<UserRole> userRoleListFromJson(String str) =>
      List<UserRole>.from(json.decode(str).map((x) => UserRole.fromJson(x)));

  static userRoleListToJson(List<UserRole> data) =>
      json.encode(List<dynamic>.from(data.map((x) => x.toJson())));
}
