import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/Scans/scan_bloc.dart';
import 'package:trackly_app/src/bloc/app_functionality/Scans/scan_event.dart';
import 'package:trackly_app/src/bloc/app_functionality/Scans/scan_state.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_state.dart';
import 'package:trackly_app/src/utils/all_constants_imports.dart';

import 'package:mobile_scanner/mobile_scanner.dart';

class ScanPage extends StatefulWidget {
  ScanPage({super.key});

  @override
  State<ScanPage> createState() => _ScanPageState();
}

class _ScanPageState extends State<ScanPage> {
  final log = logger(ScanPage);

  bool _canScan = true;

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
        child: BlocListener<AssetCubit, AssetState>(
          listener: (context, state) {
            if (state is AssetsLoading) {
              //show loading indicator
              log.d('Asset loading');
            } else if (state is AssetsFailure) {
              ScanBloc().add(CannotScanEvent());
              setState(() {
                _canScan = false;
              });
              //navigate to asset failure page
              Navigator.of(context).pushNamed(
                assetFailurePageRoute,
              );
            } else if (state is AssetFetched) {
              ScanBloc().add(CannotScanEvent());
              setState(() {
                _canScan = false;
              });
              //navigate to asset success page
              Navigator.of(context).pushNamed(
                assetSuccssPageRoute,
                arguments: {
                  'barcodeNumber': state.asset.barcodeNumber,
                  'assetName': state.asset.assetName,
                  'assetCategory': state.asset.category,
                  'assetDepartment': state.asset.departmentName,
                  'assetLocation': state.asset.locationName,
                  'tickets': state.asset.tickets
                },
              );
            } else if (state is AssetsInitial) {
              setState(() {
                _canScan = true;
              });
            }
          },
          child: BlocBuilder<AssetCubit, AssetState>(builder: (context, state) {
            if (state is AssetsLoading) {
              return const Center(child: CircularProgressIndicator());
            } else {
              return MobileScanner(
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
                    detectionTimeoutMs: 1000,
                    useNewCameraSelector: false),
                onDetect: (capture) {
                  var barcode = capture.barcodes.last;
                  log.e('Detected barcode: ${barcode.rawValue}');
                  if (_canScan) {
                    context.read<AssetCubit>().fetchAsset(barcode.rawValue!);
                  }
                },
              );
            }
          }),
        ),
      ),
    );
  }
}
