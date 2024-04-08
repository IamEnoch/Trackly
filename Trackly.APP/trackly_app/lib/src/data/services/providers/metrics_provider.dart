import 'package:trackly_app/src/data/models/Metrics/metrics.dart';
import 'package:trackly_app/src/data/models/api_response.dart';
import 'package:trackly_app/src/data/services/repositories/metrics_repository.dart';

class MetricsProvider {
  Future<ApiResponse<Metrics>> getMetrics() {
    return MetricsRepository().getMetrics();
  }
}
