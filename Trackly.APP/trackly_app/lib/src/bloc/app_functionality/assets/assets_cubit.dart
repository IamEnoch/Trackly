import 'dart:async';

import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_state.dart';
import 'package:trackly_app/src/data/models/Assets/asset.dart';
import 'package:trackly_app/src/data/models/Assets/asset_update.dart';
import 'package:trackly_app/src/data/models/api_response.dart';
import 'package:trackly_app/src/data/services/providers/asset_provider.dart';

class AssetCubit extends Cubit<AssetState> {
  ///Singleton instance
  static final AssetCubit _instance = AssetCubit._internal();

  factory AssetCubit() {
    return _instance;
  }
  AssetCubit._internal() : super(AssetsInitial());
  final log = logger(AssetCubit);

  //update asset
  Future<void> updateAsset(String assetId, AssetUpdate asset) async {
    emit(AssetLoading());
    try {
      var response = await AssetProvider().updateAsset(assetId, asset);
      if (response.error) {
        log.e('The asset was not updated');
        emit(AssetFailure(message: response.errorMessage));
        log.e(response.errorMessage);
        return;
      } else {
        log.d('The asset was updated');
        emit(AssetUpdated());
      }
    } on Exception catch (e) {
      emit(AssetFailure(message: e.toString()));
    }
  }

  Future<void> createWorkItem(Asset asset) async {
    emit(AssetLoading());
    try {
      var response = await AssetProvider().createAsset(asset);
      if (response.error) {
        log.e('The work item was not created');
        emit(AssetFailure(message: response.errorMessage));
        log.e(response.errorMessage);
        return;
      } else {
        log.d('The work item was created');
        emit(AssetCreated());
      }
    } on Exception catch (e) {
      emit(AssetFailure(message: e.toString()));
    }
  }

  Future<List<Asset>> getAssets(int currentPage, int pageSize) async {
    try {
      emit(AssetsLoading());

      // Api call
      ApiResponse<List<Asset>?> assets =
          await AssetProvider().getPaginatedAssets(currentPage, pageSize);

      // Check if there are assets. If not, do not fetch data again
      if (assets.response!.isEmpty) {
        emit(AssetsEmpty());
        //return an empty list of type asset
        return <Asset>[];
      }

      emit(AssetsSuccess());
      return assets.response!;
    } catch (error) {
      // Handle errors
      emit(AssetsFailure(message: error.toString()));
      return <Asset>[];
    }
  }

  // @override
  // Future<void> close() {
  //   _assetStreamController.close();
  //   return super.close();
  // }

  Future<void> fetchAsset(String id) async {
    emit(AssetLoading());
    try {
      final response = await AssetProvider().getAssetByBarcodeNumber(id);
      if (response.error) {
        emit(AssetFailure(message: response.errorMessage));
        log.e(response.errorMessage);
        return;
      } else if (response.response == null) {
        emit(const AssetFailure(message: 'No asset found'));
        log.e('No asset found');
        log.e(response.errorMessage);
        return;
      } else {
        emit(AssetFetched(asset: response.response!));
        log.d('The response is ${response.response}');
      }
    } on Exception catch (e) {
      emit(AssetFailure(message: e.toString()));
    }
  }

  void toAssetInitial() {
    emit(AssetsInitial());
  }
}
