import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:trackly_app/Logging/logger.dart';

class TicketRepository {
  late String basicUrl;
  final log = logger(TicketRepository);

  TicketRepository() {
    basicUrl = dotenv.env['API_URL'] ?? '';
  }
}
