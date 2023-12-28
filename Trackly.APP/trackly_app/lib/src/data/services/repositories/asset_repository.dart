import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:http/http.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/data/localstorage/shared_reference_manager.dart';
import 'package:trackly_app/src/data/models/api_response.dart';
import 'package:trackly_app/src/data/models/asset.dart';

import 'package:http/http.dart' as http;
import 'dart:convert' as convert;

class AssetRepository {
  late String basicUrl;
  final log = logger(AssetRepository);

  AssetRepository() {
    basicUrl = dotenv.env['API_URL'] ?? '';
  }

  //Get a specific asset by barcode number
  Future<ApiResponse<Asset>> getAssetByBarcodeNumber(
      String barcodeNumber) async {
    Response? response;
    String authToken = await SharedPreferencesManager().getAuthAccessToken();

    try {
      //Make a GET request to the API
      var uri = Uri.https(basicUrl, 'AssetManagement/assets/$barcodeNumber');
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

      var decodedResponse = Asset.fromJson(jsonResponse);

      log.e('The decoded response is $decodedResponse');

      return ApiResponse(
          response: decodedResponse, errorMessage: 'No error', error: false);
    } catch (e) {
      log.e(e);
      return ApiResponse(
          response: null, errorMessage: 'No error', error: false);
    }
  }
}
