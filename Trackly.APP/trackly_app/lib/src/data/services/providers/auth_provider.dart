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
}
