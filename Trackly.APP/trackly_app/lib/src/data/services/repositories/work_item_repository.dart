import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:http/http.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/data/localstorage/shared_reference_manager.dart';
import 'package:trackly_app/src/data/models/WorkItems/work_item_create.dart';
import 'package:trackly_app/src/data/models/api_response.dart';
import 'package:trackly_app/src/data/models/WorkItems/work_item.dart';

import 'package:http/http.dart' as http;
import 'dart:convert' as convert;

class WorkItemRepository {
  late String basicUrl;
  final log = logger(WorkItemRepository);

  WorkItemRepository() {
    basicUrl = dotenv.env['API_URL'] ?? '';
  }

  //Create a work item for a specific asset
  Future<ApiResponse<void>> createWorkItem(WorkItemCreate workItem) async {
    Response? response;
    String authToken = await SharedPreferencesManager().getAuthAccessToken();

    try {
      //Make a POST request to the API
      var uri = Uri.http(basicUrl, '/workitems');
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

  //Get paginated work items
  Future<ApiResponse<List<WorkItem>>> getWorkItems(
      int pageNumber, int pageSize) async {
    Response? response;
    String authToken = await SharedPreferencesManager().getAuthAccessToken();

    try {
      //Make a GET request to the API
      var uri = Uri.http(
        basicUrl,
        '/workitems/pending/paged',
        {'pageNumber': '$pageNumber', 'pageSize': '$pageSize'},
      );

      log.e('The uri is $uri');
      response = await http.get(
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
            response: [], errorMessage: 'Bad request', error: true);
      } else {
        log.e('The status code is ${response.statusCode}');
        var jsonResponse = convert.jsonDecode(response.body);
        List<WorkItem> workItems = [];
        for (var item in jsonResponse) {
          workItems.add(WorkItem.fromJson(item));
        }
        return ApiResponse(
            response: workItems, errorMessage: 'error', error: false);
      }
    } catch (e) {
      log.e(e);
      return ApiResponse(response: [], errorMessage: 'No error', error: true);
    }
  }
}
