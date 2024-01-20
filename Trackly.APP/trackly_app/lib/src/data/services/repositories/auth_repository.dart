import 'package:auth0_flutter/auth0_flutter.dart';
import 'package:flutter/material.dart';
import 'package:http/http.dart';
import 'package:shared_preferences/shared_preferences.dart';
import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/data/localstorage/shared_reference_manager.dart';
import 'package:trackly_app/src/data/models/Auth/user_role.dart';
import 'package:trackly_app/src/data/models/api_response.dart';

import 'package:http/http.dart' as http;
import 'dart:convert' as convert;

class AuthRepository {
  late String domain;
  late String clientId;
  late String audience;
  late Auth0 auth0;

  late String basicUrl;

  //logger
  final log = logger(AuthRepository);

  AuthRepository() {
    domain = dotenv.env['AUTH0_DOMAIN'] ?? '';
    clientId = dotenv.env['AUTH0_CLIENT_ID'] ?? '';
    audience = dotenv.env['AUTH0_AUDIENCE'] ?? '';
    basicUrl = dotenv.env['API_URL'] ?? '';
    auth0 = Auth0(domain, clientId);
  }

  //Login user by opening Auth0 login page in a browser and storing user data in SharedPreferences
  Future<bool> loginUser() async {
    try {
      final credentials =
          await auth0.webAuthentication().login(audience: audience);

      if (credentials != null) {
        await storeUserData(credentials, true);
        debugPrint("Login Successful");
        //log all the credentials details
        log.i('The access token is ${credentials.accessToken}');
        log.i('The id token is${credentials.idToken}');
        log.i('The refresh token is ${credentials.refreshToken}');
        log.i('The token type${credentials.tokenType}');
        log.i('The user is ${credentials.user}');
        log.i('The scopes are ${credentials.scopes}');

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
      log.i('Logged out successfully');

      return true;
    } catch (e) {
      log.e('Logout error: $e');
      return false;
      // Handle logout errors or show appropriate messages
    }
  }

  //Get user role from API
  Future<ApiResponse<List<UserRole>>> getUserRole() async {
    String userId = await SharedPreferencesManager().getUserId();
    String authToken = await SharedPreferencesManager().getAuthAccessToken();

    try {
      //Make a GET request to the API
      var uri = Uri.http(basicUrl, '/users/$userId/role');
      log.d('The uri to get user role is ${uri.toString()}');
      var result = await http.get(
        Uri.parse(
          uri.toString(),
        ),
        headers: {
          'Content-Type': 'application/json',
          'Accept': 'text/plain',
          'Authorization': 'Bearer $authToken',
        },
      );

      if (result.statusCode != 200) {
        log.i(
            'The status code while getting user role is ${result.statusCode}');
        return ApiResponse(
            response: null, errorMessage: 'Bad request', error: true);
      } else {
        log.i(
            'The status code while getting user role is ${result.statusCode}');

        List<UserRole> userRoles = UserRole.userRoleListFromJson(result.body);

        return ApiResponse<List<UserRole>>(
            response: userRoles, errorMessage: 'error', error: false);
      }
    } catch (e) {
      log.e(e);
      return ApiResponse(response: null, errorMessage: 'No error', error: true);
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
