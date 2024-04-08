import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:http/http.dart';
import 'package:trackly_app/Logging/logger.dart';

import 'package:http/http.dart' as http;
import 'package:trackly_app/src/data/localstorage/shared_reference_manager.dart';
import 'package:trackly_app/src/data/models/Metrics/metrics.dart';
import 'dart:convert' as convert;

import 'package:trackly_app/src/data/models/api_response.dart';

class MetricsRepository {
  late String basicUrl;
  final log = logger(MetricsRepository);

  MetricsRepository() {
    basicUrl = dotenv.env['API_URL'] ?? '';
  }

  //Get the metrics data for the dashboard(User metrics model)
  Future<ApiResponse<Metrics>> getMetrics() async {
    String authToken = await SharedPreferencesManager().getAuthAccessToken();

    try {
      //Make a GET request to the API
      var uri = Uri.http(basicUrl, '/metrics');
      log.d('The uri is ${uri.toString()}');
      Response response = await http.get(
        Uri.parse(
          uri.toString(),
        ),
        headers: {
          'Content-Type': 'application/json',
          'Accept': 'application/json',
          'Authorization': 'Bearer $authToken',
        },
      );

      if (response.statusCode != 200) {
        log.e('The status code is ${response.statusCode}');
        return ApiResponse(
            response: null, errorMessage: 'Bad request', error: true);
      } else {
        log.e('The status code is ${response.statusCode}');
        var jsonResponse = convert.jsonDecode(response.body);
        Metrics metrics = Metrics.fromJson(jsonResponse);
        return ApiResponse(
            response: metrics, errorMessage: 'No error', error: false);
      }
    } catch (e) {
      log.e(e);
      return ApiResponse(response: null, errorMessage: 'No error', error: true);
    }
  }
}
