import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:http/http.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/data/localstorage/shared_reference_manager.dart';
import 'package:trackly_app/src/data/models/Tickets/ticket.dart';
import 'package:trackly_app/src/data/models/Tickets/ticket_status_update.dart';
import 'package:trackly_app/src/data/models/api_response.dart';

import 'package:http/http.dart' as http;
import 'dart:convert' as convert;

import 'package:trackly_app/src/data/models/paged_items.dart';

class TicketRepository {
  late String basicUrl;
  final log = logger(TicketRepository);

  TicketRepository() {
    basicUrl = dotenv.env['API_URL'] ?? '';
  }

  //Update the status of the ticket
  Future<ApiResponse<void>> changeTicketStatus(
      String id, TicketStatusUpdate ticketStatusUpdate) async {
    Response? response;
    String authToken = await SharedPreferencesManager().getAuthAccessToken();

    try {
      //Make a POST request to the API
      var uri = Uri.http(basicUrl, '/tickets/${id}/status');
      log.d('The uri is ${uri.toString()}');
      response = await http.put(
        Uri.parse(
          uri.toString(),
        ),
        headers: {
          'Content-Type': 'application/json',
          'Accept': 'text/plain',
          'Authorization': 'Bearer $authToken',
        },
        body: convert.jsonEncode(ticketStatusUpdate.toJson()),
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

  //Get list of assets from paginated assets
  Future<ApiResponse<List<Ticket>?>> getCompletedPaginatedTickets(
      int pageNumber, int pageSize) async {
    Response? response;
    String authToken = await SharedPreferencesManager().getAuthAccessToken();

    try {
      //Make a GET request to the API
      var uri = Uri.http(basicUrl, '/tickets/completed',
          {'PageNumber': '$pageNumber', 'PageSize': '$pageSize'});

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
        log.e('The auth token is ${authToken}');
        log.e('The base uri is ${basicUrl}');
        return ApiResponse(
            response: null, errorMessage: 'No error', error: false);
      }
      log.e('The response is $response');
      var jsonResponse =
          await convert.jsonDecode(response.body) as Map<String, dynamic>;
      //var itemCount = jsonResponse['totalItems'];

      log.e('The json response is $jsonResponse');

      var decodedResponse = PagedTickets.fromJson(jsonResponse);

      log.e('The decoded response is $decodedResponse');

      return ApiResponse<List<Ticket>>(
          response: decodedResponse.items,
          errorMessage: 'No error',
          error: false);
    } catch (e) {
      log.e('The error is $e');
      return ApiResponse(
          response: null, errorMessage: 'No error', error: false);
    }
  }
}
