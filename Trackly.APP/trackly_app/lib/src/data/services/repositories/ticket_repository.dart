import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:http/http.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/data/localstorage/shared_reference_manager.dart';
import 'package:trackly_app/src/data/models/api_response.dart';
import 'package:trackly_app/src/data/models/work_item.dart';

import 'package:http/http.dart' as http;
import 'dart:convert' as convert;

class TicketRepository {
  late String basicUrl;
  final log = logger(TicketRepository);

  TicketRepository() {
    basicUrl = dotenv.env['API_URL'] ?? '';
  }

  //Create a work item for a specific asset
  Future<ApiResponse<void>> createWorkItem(WorkItem workItem) async {
    Response? response;
    String authToken = await SharedPreferencesManager().getAuthAccessToken();

    try {
      //Make a POST request to the API
      var uri = Uri.https(basicUrl, '/Tickets/Workitem');
      log.d('The uri is ${uri.toString()}');
      response = await http.post(
        Uri.parse(
          uri.toString(),
        ),
        headers: {
          'Content-Type': 'application/json',
          'Accept': 'text/plain',
          'Authorization': 'Bearer $authToken',
        },
        body: convert.jsonEncode(workItem.toJson()),
      );

      if (response.statusCode != 200) {
        log.e('The status code is ${response.statusCode}');
        return ApiResponse(
            response: null, errorMessage: 'Bad request', error: true);
      } else {
        log.e('The status code is ${response.statusCode}');
        return ApiResponse(response: null, errorMessage: 'error', error: false);
      }
    } catch (e) {
      log.e(e);
      return ApiResponse(response: null, errorMessage: 'No error', error: true);
    }
  }
}
