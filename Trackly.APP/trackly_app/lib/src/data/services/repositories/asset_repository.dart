import 'dart:async';

import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:http/http.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/data/localstorage/shared_reference_manager.dart';
import 'package:trackly_app/src/data/models/Assets/asset_create.dart';
import 'package:trackly_app/src/data/models/Assets/asset_update.dart';
import 'package:trackly_app/src/data/models/api_response.dart';
import 'package:trackly_app/src/data/models/Assets/asset.dart';

import 'package:http/http.dart' as http;
import 'dart:convert' as convert;

import 'package:trackly_app/src/data/models/paged_items.dart';

class AssetRepository {
  late String basicUrl;
  final log = logger(AssetRepository);

  AssetRepository() {
    basicUrl = dotenv.env['API_URL'] ?? '';
  }

  //Get list of assets from paginated assets
  Future<ApiResponse<List<Asset>?>> getPaginatedAssets(
      int pageNumber, int pageSize) async {
    Response? response;
    String authToken = await SharedPreferencesManager().getAuthAccessToken();

    try {
      //Make a GET request to the API
      var uri = Uri.http(basicUrl, '/assets/paged',
          {'pageNumber': '$pageNumber', 'pageSize': '$pageSize'});

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

      var decodedResponse = PageedAssets.fromJson(jsonResponse);

      log.e('The decoded response is $decodedResponse');

      return ApiResponse<List<Asset>>(
          response: decodedResponse.items,
          errorMessage: 'No error',
          error: false);
    } catch (e) {
      log.e('The error is $e');
      return ApiResponse(
          response: null, errorMessage: 'No error', error: false);
    }
  }

  //Update asset by assetId and assetUpdate model class
  Future<ApiResponse<void>> updateAsset(
      String assetId, AssetUpdate asset) async {
    Response? response;
    String authToken = await SharedPreferencesManager().getAuthAccessToken();

    try {
      //Make a PUT request to the API
      var uri = Uri.http(basicUrl, '/assets/$assetId');
      response = await http.put(
        Uri.parse(
          uri.toString(),
        ),
        headers: {
          'Content-Type': 'application/json',
          'Accept': 'application/json',
          'Authorization': 'Bearer $authToken',
        },
        body: convert.jsonEncode(asset.toJson()),
      );

      if (response.statusCode != 200) {
        log.e('The status code is ${response.statusCode}');
        log.e('The auth token is ${authToken}');
        log.e('The base uri is ${basicUrl}');
        return ApiResponse(
            response: null, errorMessage: 'Error occured', error: true);
      }
      log.e('The response is $response');
      var jsonResponse =
          await convert.jsonDecode(response.body) as Map<String, dynamic>;
      //var itemCount = jsonResponse['totalItems'];

      log.e('The json response is $jsonResponse');

      //var decodedResponse = Asset.fromJson(jsonResponse);

      //log.e('The decoded response is $decodedResponse');

      return ApiResponse(
          response: null, errorMessage: 'No error', error: false);
    } catch (e) {
      log.e('Error: Exception occured => $e');
      return ApiResponse(
          response: null,
          errorMessage: 'Error occured while updating asset',
          error: true);
    }
  }

  //Create an asset
  Future<ApiResponse<Asset>> createAsset(AssetCreate asset) async {
    Response? response;
    String authToken = await SharedPreferencesManager().getAuthAccessToken();

    try {
      //Make a POST request to the API
      var uri = Uri.http(basicUrl, '/assets');
      response = await http.post(
        Uri.parse(
          uri.toString(),
        ),
        headers: {
          'Content-Type': 'application/json',
          'Accept': 'application/json',
          'Authorization': 'Bearer $authToken',
        },
        body: convert.jsonEncode(asset.toJson()),
      );

      if (response.statusCode != 200) {
        log.e('The status code is ${response.statusCode}');
        log.e('The auth token is ${authToken}');
        log.e('The base uri is ${basicUrl}');
        return ApiResponse(
            response: null, errorMessage: 'Error occured', error: true);
      }
      log.e('The response is $response');
      var jsonResponse =
          await convert.jsonDecode(response.body) as Map<String, dynamic>;
      //var itemCount = jsonResponse['totalItems'];

      log.e('The json response is $jsonResponse');

      // var decodedResponse = Asset.fromJson(jsonResponse);

      // log.e('The decoded response is $decodedResponse');

      return ApiResponse(
          response: null, errorMessage: 'No error', error: false);
    } catch (e) {
      log.e(e);
      return ApiResponse(
          response: null,
          errorMessage: 'Error occured while creating asset',
          error: true);
    }
  }

  //Get a specific asset by barcode number
  Future<ApiResponse<Asset>> getAssetByBarcodeNumber(
      String barcodeNumber) async {
    Response? response;
    String authToken = await SharedPreferencesManager().getAuthAccessToken();

    try {
      //Make a GET request to the API
      var uri = Uri.http(basicUrl, '/assets/$barcodeNumber');
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
            response: null, errorMessage: 'Error occured', error: true);
      }
      log.e('The response is $response');
      var jsonResponse =
          await convert.jsonDecode(response.body) as Map<String, dynamic>;

      log.e('The json response is $jsonResponse');

      var decodedResponse = Asset.fromJson(jsonResponse);

      log.e('The decoded response is $decodedResponse');

      return ApiResponse(
          response: decodedResponse, errorMessage: 'No error', error: false);
    } catch (e) {
      log.e(e);
      return ApiResponse(
          response: null,
          errorMessage: 'Error occured while creating asset',
          error: true);
    }
  }
}
