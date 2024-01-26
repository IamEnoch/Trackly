import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/Scans/scan_event.dart';
import 'package:trackly_app/src/bloc/app_functionality/Scans/scan_state.dart';

class ScanBloc extends Bloc<ScanEvent, ScanState> {
  //add logger
  final log = logger(ScanBloc);

  //Singleton instanceS
  static final ScanBloc _instance = ScanBloc._internal();

  factory ScanBloc() {
    return _instance;
  }

  ScanBloc._internal() : super(ScanInitial()) {
    on<CanScanEvent>((event, emit) {
      emit(CanScanState());
    });

    on<CannotScanEvent>((event, emit) {
      emit(CannotScanState());
    });
  }
}
