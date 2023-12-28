import 'package:logger/logger.dart';

var logger = (Type type) => Logger(printer: CustomPrinter(type.toString()));

//Define a custom printer
class CustomPrinter extends LogPrinter {
  final String className;

  CustomPrinter(this.className);

  @override
  List<String> log(LogEvent event) {
    final color = PrettyPrinter.levelColors[event.level];
    final emoji = PrettyPrinter.levelEmojis[event.level];
    final message = event.message;

    return [color!('$emoji: $className => $message')];
  }
}
