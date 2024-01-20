import 'package:trackly_app/src/data/models/Auth/user_role.dart';
import 'package:trackly_app/src/data/models/api_response.dart';
import 'package:trackly_app/src/data/services/repositories/auth_repository.dart';

class AuthProviders {
  Future<bool> loginAccount() async {
    var response = await AuthRepository().loginUser();
    return response;
  }

  Future<bool> logoutAccount() async {
    var response = await AuthRepository().logoutUser();
    return response;
  }

  Future<ApiResponse<List<UserRole>>> getUserRole() async {
    var response = await AuthRepository().getUserRole();
    return response;
  }
}
