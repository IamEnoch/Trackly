import 'package:flutter/material.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/Scans/scan_bloc.dart';
import 'package:mobile_scanner/mobile_scanner.dart';

class BarcodeScanPage extends StatefulWidget {
  const BarcodeScanPage({super.key});

  @override
  State<BarcodeScanPage> createState() => _BarcodeScanPageState();
}

class _BarcodeScanPageState extends State<BarcodeScanPage> {
  final log = logger(BarcodeScanPage);

  // Function to reinitialize controllers
  final ScanBloc scanBloc = ScanBloc();

  @override
  Widget build(BuildContext context) {
    //final MobileScannerController cameraController = MobileScannerController();
    return Scaffold(
      appBar: AppBar(
        title: const Text('Mobile Scanner'),
      ),
      body: SafeArea(
        child: MobileScanner(
          //Overlay widget for barcode scanner
          //Darken the area outside the conta
          overlay: Center(
            child: Container(
              width: 300,
              height: 150,
              decoration: BoxDecoration(
                border: Border.all(
                  color: Colors.red,
                  width: 2,
                ),
              ),
            ),
          ),
          controller: MobileScannerController(
              detectionSpeed: DetectionSpeed.normal,
              detectionTimeoutMs: 500,
              useNewCameraSelector: false),
          onDetect: (capture) {
            var barcode = capture.barcodes.last;
            log.e('Detected barcode: ${barcode.rawValue}');
            Navigator.pop(context, barcode.rawValue);
          },
        ),
      ),
    );
  }
}
