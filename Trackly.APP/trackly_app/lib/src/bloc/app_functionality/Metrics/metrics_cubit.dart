import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/Metrics/metrics_state.dart';
import 'package:trackly_app/src/data/services/providers/metrics_provider.dart';

class MetricsCubit extends Cubit<MetricsState> {
  ///Singleton instance
  static final MetricsCubit _instance = MetricsCubit._internal();

  factory MetricsCubit() {
    return _instance;
  }
  MetricsCubit._internal() : super(MetricsInitial());
  final log = logger(MetricsCubit);

  //Get the metrics
  Future<void> getMetrics() async {
    emit(MetricsLoading());
    try {
      //Get the metrics
      var response = await MetricsProvider().getMetrics();
      if (response.error) {
        log.e('The metrics were not fetched');
        emit(
          MetricsFailure(message: response.errorMessage),
        );
        log.e(response.errorMessage);
        return;
      } else {
        log.d('The metrics were fetched');
        emit(
          MetricsSuccess(metrics: response.response!),
        );
      }
    } on Exception catch (e) {
      emit(
        MetricsFailure(message: e.toString()),
      );
    }
  }

  //To metrics initial
  void toMetricsInitial() {
    emit(MetricsInitial());
  }
}
