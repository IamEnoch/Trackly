import 'package:equatable/equatable.dart';
import 'package:trackly_app/src/data/models/Assets/asset.dart';

class AssetState extends Equatable {
  const AssetState();

  @override
  List<Object> get props => [];
}

final class AssetsInitial extends AssetState {}

final class AssetsLoading extends AssetState {}

final class AssetsEmpty extends AssetState {}

final class AssetsSuccess extends AssetState {}

final class AssetsFailure extends AssetState {
  final String message;

  const AssetsFailure({required this.message});

  @override
  List<Object> get props => [message];
}

//Asset related states
final class AssetLoading extends AssetState {}

final class AssetCreated extends AssetState {}

final class AssetUpdated extends AssetState {}

final class AssetDeleted extends AssetState {}

final class AssetFetched extends AssetState {
  final Asset asset;

  const AssetFetched({required this.asset});

  @override
  List<Object> get props => [asset];
}

final class AssetFailure extends AssetState {
  final String message;

  const AssetFailure({required this.message});

  @override
  List<Object> get props => [message];
}
