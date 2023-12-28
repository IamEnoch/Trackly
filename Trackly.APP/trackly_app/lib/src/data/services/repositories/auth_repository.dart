import 'package:auth0_flutter/auth0_flutter.dart';
import 'package:flutter/material.dart';
import 'package:shared_preferences/shared_preferences.dart';
import 'package:flutter_dotenv/flutter_dotenv.dart';

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

  SharedPreferences prefs = await SharedPreferences.getInstance();

  //Store using SharedPreferences.getInstance() instead
  //of using SharedPreferencesManager() to avoid
  //multiple instances of SharedPreferences

  // Storing user data from Credentials.user
  await prefs.setBool('is_logged_in', loginStatus);
  await prefs.setString('userId', credentials.user.sub);
  await prefs.setString('userName', credentials.user.name ?? '');
  await prefs.setString('userEmail', credentials.user.email ?? '');
  await prefs.setString('userPhoneNumber', credentials.user.phoneNumber ?? '');
  await prefs.setString(
      'pictureUrl', credentials.user.pictureUrl?.toString() ?? '');

  // Storing auth credentials from Credentials
  await prefs.setString('refreshToken', credentials.refreshToken ?? '');
  await prefs.setString('accessToken', credentials.accessToken);
  await prefs.setString('idToken', credentials.idToken);
  await prefs.setString('tokenType', credentials.tokenType);
  await prefs.setStringList('scopes', credentials.scopes.toList());
}
