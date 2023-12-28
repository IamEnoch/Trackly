import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_state.dart';
import 'package:trackly_app/src/data/services/providers/asset_provider.dart';

class AssetCubit extends Cubit<AssetsState> {
  AssetCubit() : super(AssetsInitial());
  final log = logger(AssetCubit);

  // Future<void> fetchAssets() async {
  //   emit(AssetsLoading());
  //   try {
  //     final assets = await assetProvider.();
  //     emit(AssetsSuccess(assets: assets));
  //   } on Exception catch (e) {
  //     emit(AssetsFailure(message: e.toString()));
  //   }
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

  // Future<void> createAsset(Asset asset) async {
  //   emit(AssetsLoading());
  //   try {
  //     await assetProvider.createAsset(asset);
  //     emit(AssetCreated());
  //   } on Exception catch (e) {
  //     emit(AssetsFailure(message: e.toString()));
  //   }
  // }

  // Future<void> updateAsset(Asset asset) async {
  //   emit(AssetsLoading());
  //   try {
  //     await assetProvider.updateAsset(asset);
  //     emit(AssetUpdated());
  //   } on Exception catch (e) {
  //     emit(AssetsFailure(message: e.toString()));
  //   }
  // }

  // Future<void> deleteAsset(String id) async {
  //   emit(AssetsLoading());
  //   try {
  //     await assetProvider.deleteAsset(id);
  //     emit(AssetDeleted());
  //   } on Exception catch (e) {
  //     emit(AssetsFailure(message: e.toString()));
  //   }
  // }
}
