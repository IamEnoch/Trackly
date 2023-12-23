import 'package:shared_preferences/shared_preferences.dart';

class SharedPreferencesManager {
  //Use only one instance of SharedPreferences.getInstance() in the following methods
  //This is done by using a singleton pattern

  // Singleton instance of SharedPreferencesManager
  static final SharedPreferencesManager _instance =
      SharedPreferencesManager._internal();

  SharedPreferencesManager._internal();

  // Factory method to provide the single instance of SharedPreferencesManager
  factory SharedPreferencesManager() {
    return _instance;
  }

  Future<bool> isLoggedIn() async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.getBool('is_logged_in') ?? false;
  }

  Future<bool> setLoggedIn({required bool value}) async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.setBool('is_logged_in', value);
  }

  Future<String> getUserId() async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.getString('userId') ?? '';
  }

  Future<bool> setUserId({required String value}) async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.setString('userId', value);
  }

  Future<String> getUserName() async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.getString('userName') ?? '';
  }

  Future<bool> setUserName({required String value}) async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.setString('userName', value);
  }

  Future<String> getUserEmail() async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.getString('userEmail') ?? '';
  }

  Future<bool> setUserEmail({required String value}) async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.setString('userEmail', value);
  }

  Future<String> getUserPhoneNumber() async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.getString('userPhoneNumber') ?? '';
  }

  Future<bool> setUserPhoneNumber({required String value}) async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.setString('userPhoneNumber', value);
  }

  Future<String> getAuthRefreshToken() async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.getString('refreshToken') ?? '';
  }

  Future<bool> setAuthRefreshToken({required String value}) async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.setString('refreshToken', value);
  }

  Future<String> getAuthAccessToken() async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.getString('accessToken') ?? '';
  }

  Future<bool> setAuthAccessToken({required String value}) async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.setString('accessToken', value);
  }

  Future<String> getAuthIdToken() async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.getString('idToken') ?? '';
  }

  Future<bool> setAuthIdToken({required String value}) async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.setString('idToken', value);
  }

  Future<String> getAuthTokenType() async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.getString('tokenType') ?? '';
  }

  Future<bool> setAuthTokenType({required String value}) async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.setString('tokenType', value);
  }

  Future<Object> getAuthScopes() async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.getStringList('scopes') ?? '';
  }

  Future<bool> setAuthScopes({required List<String> value}) async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.setStringList('scopes', value);
  }

  Future<String> getPictureUrl() async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.getString('userPictureUrl') ?? '';
  }

  Future<bool> setPictureUrl({required String value}) async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.setString('userPictureUrl', value);
  }

  Future<bool> setAppTheme({required bool value}) async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.setBool('app_theme', value);
  }

  Future<bool> getAppTheme() async {
    final prefs = await SharedPreferences.getInstance();
    return prefs.getBool('app_theme') ?? false;
  }
}
