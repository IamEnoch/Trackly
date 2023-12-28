import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_state.dart';
import 'package:trackly_app/src/utils/all_constants_imports.dart';

class ScanPage extends StatelessWidget {
  ScanPage({super.key});
  final log = logger(ScanPage);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: BlocListener<AssetCubit, AssetsState>(
        listener: (context, state) {
          // TODO: implement listener
          if (state is AssetFetched) {
            log.d('Asset fetched');

            //add arugments too from the reposnse
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
          } else if (state is AssetsFailure) {
            log.e('Asset failed');
          } else if (state is AssetsLoading) {
            log.d('Asset loading');
          }
        },
        child: Center(
            child: OutlinedButton(
          onPressed: () {
            context.read<AssetCubit>().fetchAsset('100000000019');
          },
          child: const Text('Scan page'),
        )),
      ),
    );
  }
}
