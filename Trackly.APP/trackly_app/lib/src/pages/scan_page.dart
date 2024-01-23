import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
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
  MobileScannerController cameraController = MobileScannerController();

  @override
  void initState() {
    cameraController.start();
    super.initState();
  }

  @override
  void dispose() {
    cameraController.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Mobile Scanner'),
        actions: [
          IconButton(
            color: Colors.white,
            icon: ValueListenableBuilder(
              valueListenable: cameraController.torchState,
              builder: (context, state, child) {
                switch (state as TorchState) {
                  case TorchState.off:
                    return const Icon(Icons.flash_off, color: Colors.grey);
                  case TorchState.on:
                    return const Icon(Icons.flash_on, color: Colors.yellow);
                }
              },
            ),
            iconSize: 32.0,
            onPressed: () => cameraController.toggleTorch(),
          ),
          IconButton(
            color: Colors.grey,
            icon: ValueListenableBuilder(
              valueListenable: cameraController.cameraFacingState,
              builder: (context, state, child) {
                switch (state as CameraFacing) {
                  case CameraFacing.front:
                    return const Icon(Icons.camera_front);
                  case CameraFacing.back:
                    return const Icon(Icons.camera_rear);
                }
              },
            ),
            iconSize: 32.0,
            onPressed: () => cameraController.switchCamera(),
          ),
        ],
      ),
      body: SafeArea(
        child: BlocListener<AssetCubit, AssetState>(
          listener: (context, state) {
            if (state is AssetsLoading) {
              //show loading indicator
              log.d('Asset loading');
            } else if (state is AssetsFailure) {
              //navigate to asset failure page
              Navigator.of(context).pushNamed(
                assetFailurePageRoute,
              );
            } else if (state is AssetFetched) {
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
            }
          },
          child: BlocBuilder<AssetCubit, AssetState>(builder: (context, state) {
            if (state is AssetsLoading) {
              return const Center(child: CircularProgressIndicator());
            } else {
              return MobileScanner(
                // fit: BoxFit.contain,
                controller: cameraController,
                onDetect: (capture) {
                  final Barcode barcode = capture.barcodes.first;
                  context.read<AssetCubit>().fetchAsset(barcode.rawValue!);
                },
              );
            }
          }),
        ),
      ),
    );
    // body: BlocListener<AssetCubit, AssetState>(
    //   listener: (context, state) {
    //     // TODO: implement listener
    //     if (state is AssetFetched) {
    //       log.d('Asset fetched');

    //       //add arugments too from the reposnse
    //       Navigator.of(context).pushNamed(
    //         assetSuccssPageRoute,
    //         arguments: {
    //           'barcodeNumber': state.asset.barcodeNumber,
    //           'assetName': state.asset.assetName,
    //           'assetCategory': state.asset.category,
    //           'assetDepartment': state.asset.departmentName,
    //           'assetLocation': state.asset.locationName,
    //           'tickets': state.asset.tickets
    //         },
    //       );
    //     } else if (state is AssetsFailure) {
    //       Navigator.of(context).pushNamed(
    //         assetFailurePageRoute,
    //       );
    //       log.e('Asset Not found');
    //     } else if (state is AssetsLoading) {
    //       log.d('Asset loading');
    //     }
    //   },
    //   child: Center(
    //       child: OutlinedButton(
    //     onPressed: () async {
    //       // String barcodeScanRes = await FlutterBarcodeScanner.scanBarcode(
    //       //     '#ff6666', 'Cancel', true, ScanMode.BARCODE);
    //       //context.read<AssetCubit>().fetchAsset('100000000019');
    //       //context.read<AssetCubit>().fetchAsset(barcodeScanRes);
    //     },
    //     child: const Text('Scan page'),
    //   )),
    // ),
  }
}
