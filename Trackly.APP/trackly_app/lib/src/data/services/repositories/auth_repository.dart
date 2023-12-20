import 'package:auth0_flutter/auth0_flutter.dart';
import 'package:flutter/material.dart';
import 'package:shared_preferences/shared_preferences.dart';
import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:trackly_app/src/data/localstorage/shared_reference_manager.dart';

class AuthRepository {
  late String domain;
  late String clientId;
  late Auth0 auth0;

  AuthRepository() {
    domain = dotenv.env['AUTH0_DOMAIN'] ?? '';
    clientId = dotenv.env['AUTH0_CLIENT_ID'] ?? '';
    auth0 = Auth0(domain, clientId);
  }

  //Login user by opening Auth0 login page in a browser and storing user data in SharedPreferences
  Future<bool> loginUser() async {
    try {
      final credentials = await auth0.webAuthentication().login();

      if (credentials != null) {
        await storeUserData(credentials, true);
        debugPrint("Login Successful");
        return true;
      } else {
        debugPrint("Login failed");
        return false;
      }
    } catch (e) {
      debugPrint('Login error: $e');
      return false;
    }
  }

  //Logout user by clearing all stored user data from SharedPreferences and clearing Auth0 session
  Future<bool> logoutUser() async {
    try {
      SharedPreferences prefs = await SharedPreferences.getInstance();
      await prefs.clear(); // Clear all stored user data from SharedPreferences
      await auth0.webAuthentication().logout(); // Clear Auth0 session
      debugPrint("Logout Successful");

      return true;
    } catch (e) {
      debugPrint('Logout error: $e');
      return false;
      // Handle logout errors or show appropriate messages
    }
  }
}

Future<void> storeUserData(Credentials credentials, bool loginStatus) async {
  //Intialize SharedPreferences manager
  SharedPreferencesManager sharedPreferencesManager =
      SharedPreferencesManager();

  // Storing auth credentials from Credentials
  sharedPreferencesManager.setLoggedIn(value: loginStatus);
  sharedPreferencesManager.setAuthAccessToken(value: credentials.accessToken);
  sharedPreferencesManager.setAuthIdToken(value: credentials.idToken);
  sharedPreferencesManager.setAuthRefreshToken(
      value: credentials.refreshToken ?? '');
  sharedPreferencesManager.setAuthTokenType(value: credentials.tokenType);
  sharedPreferencesManager.setAuthScopes(value: credentials.scopes.toList());

  // Storing user profile data from Credentials
  sharedPreferencesManager.setUserId(value: credentials.user.sub);
  sharedPreferencesManager.setUserName(value: credentials.user.name ?? '');
  sharedPreferencesManager.setUserEmail(value: credentials.user.email ?? '');
  sharedPreferencesManager.setUserPhoneNumber(
      value: credentials.user.phoneNumber ?? '');
  sharedPreferencesManager.setPictureUrl(
      value: credentials.user.pictureUrl?.toString() ?? '');
}
