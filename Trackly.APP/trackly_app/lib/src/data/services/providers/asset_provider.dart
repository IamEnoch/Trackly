import 'package:trackly_app/src/data/models/api_response.dart';
import 'package:trackly_app/src/data/models/asset.dart';
import 'package:trackly_app/src/data/services/repositories/asset_repository.dart';

class AssetProvider {
  Future<ApiResponse<Asset>> getAssetByBarcodeNumber(String barcodeNumber) {
    return AssetRepository().getAssetByBarcodeNumber(barcodeNumber);
  }
}
