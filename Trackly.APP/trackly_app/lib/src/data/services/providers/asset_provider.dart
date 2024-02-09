import 'package:trackly_app/src/data/models/Assets/asset_update.dart';
import 'package:trackly_app/src/data/models/api_response.dart';
import 'package:trackly_app/src/data/models/Assets/asset.dart';
import 'package:trackly_app/src/data/services/repositories/asset_repository.dart';

class AssetProvider {
  Future<ApiResponse<Asset>> getAssetByBarcodeNumber(String barcodeNumber) {
    return AssetRepository().getAssetByBarcodeNumber(barcodeNumber);
  }

  Future<ApiResponse<List<Asset>?>> getPaginatedAssets(
      int pageNumber, int recordNumber) {
    return AssetRepository().getPaginatedAssets(pageNumber, recordNumber);
  }

  Future<ApiResponse<Asset>> createAsset(Asset asset) {
    return AssetRepository().createAsset(asset);
  }

  Future<ApiResponse<void>> updateAsset(String assetId, AssetUpdate asset) {
    return AssetRepository().updateAsset(assetId, asset);
  }
}
