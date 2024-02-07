import 'package:trackly_app/src/data/models/Auth/user.dart';
import 'package:trackly_app/src/data/models/api_response.dart';
import 'package:trackly_app/src/data/services/repositories/user_repository.dart';

class UserProvider {
  Future<ApiResponse<User>> getUserByUserId(String userId) {
    return UserRepository().getUserByUserId(userId);
  }

  Future<ApiResponse<List<User>>> getAllUsers() {
    return UserRepository().getAllUsers();
  }
}
