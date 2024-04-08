import 'package:equatable/equatable.dart';
import 'package:trackly_app/src/data/models/Metrics/metrics.dart';

class MetricsState extends Equatable {
  const MetricsState();

  @override
  List<Object> get props => [];
}

class MetricsInitial extends MetricsState {}

class MetricsLoading extends MetricsState {}

//Metrics success
class MetricsSuccess extends MetricsState {
  final Metrics metrics;

  const MetricsSuccess({required this.metrics});

  @override
  List<Object> get props => [metrics];
}

//Metrics failure
class MetricsFailure extends MetricsState {
  final String message;

  const MetricsFailure({required this.message});

  @override
  List<Object> get props => [message];
}
