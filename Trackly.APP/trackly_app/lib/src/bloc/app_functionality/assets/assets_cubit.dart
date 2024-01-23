import 'dart:async';

import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_state.dart';
import 'package:trackly_app/src/data/models/Assets/asset.dart';
import 'package:trackly_app/src/data/services/providers/asset_provider.dart';

class AssetCubit extends Cubit<AssetState> {
  final StreamController<List<Asset>> _assetStreamController =
      StreamController<List<Asset>>.broadcast();
  Stream<List<Asset>> get assetStream => _assetStreamController.stream;

  ///Singleton instanceS
  static final AssetCubit _instance = AssetCubit._internal();

  factory AssetCubit() {
    return _instance;
  }
  AssetCubit._internal() : super(AssetsInitial()) {
    //fetchNextPage();
  }
  final log = logger(AssetCubit);
  final int pageSize = 10;
  int currentPage = 1;
  bool fetchingData = true;

  void fetchNextPage() async {
    try {
      if (!fetchingData) return;
      emit(AssetsLoading());

      // Api call
      var assets =
          await AssetProvider().getPaginatedAssets(currentPage, pageSize);

      // Check if there are assets. If not, do not fetch data again
      if (assets.response!.isEmpty) {
        fetchingData = false;
        emit(AssetsEmpty());
        return;
      }

      emit(AssetsSuccess());
      // Add the new assets to the existing stream
      _assetStreamController.add(assets.response!);

      currentPage++;
    } catch (error) {
      // Handle errors
      emit(AssetsFailure(message: error.toString()));
    } finally {
      fetchingData = false;
    }
  }

  // @override
  // Future<void> close() {
  //   _assetStreamController.close();
  //   return super.close();
  // }

  Future<void> fetchAsset(String id) async {
    emit(AssetsLoading());
    try {
      final response = await AssetProvider().getAssetByBarcodeNumber(id);
      if (response.error) {
        emit(AssetsFailure(message: response.errorMessage));
        log.e(response.errorMessage);
        return;
      } else if (response.response == null) {
        emit(AssetsFailure(message: 'No asset found'));
        log.e('No asset found');
        log.e(response.errorMessage);
        return;
      } else {
        emit(AssetFetched(asset: response.response!));
        log.d('The response is ${response.response}');
      }
    } on Exception catch (e) {
      emit(AssetsFailure(message: e.toString()));
    }
  }
}
