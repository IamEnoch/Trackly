import 'package:equatable/equatable.dart';
import 'package:trackly_app/src/data/models/asset.dart';

sealed class AssetsState extends Equatable {
  const AssetsState();

  @override
  List<Object> get props => [];
}

final class AssetsInitial extends AssetsState {}

final class AssetsLoading extends AssetsState {}

final class AssetsSuccess extends AssetsState {
  final List<Asset> assets;

  const AssetsSuccess({required this.assets});

  @override
  List<Object> get props => [assets];
}

final class AssetFetched extends AssetsState {
  final Asset asset;

  const AssetFetched({required this.asset});

  @override
  List<Object> get props => [asset];
}

final class AssetCreated extends AssetsState {}

final class AssetUpdated extends AssetsState {}

final class AssetDeleted extends AssetsState {}

final class AssetsFailure extends AssetsState {
  final String message;

  const AssetsFailure({required this.message});

  @override
  List<Object> get props => [message];
}
