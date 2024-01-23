import 'dart:async';

import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_state.dart';
import 'package:trackly_app/src/data/models/Assets/asset.dart';
import 'package:trackly_app/src/utils/widgets/asset_card.dart';

class AssetsPage extends StatefulWidget {
  const AssetsPage({super.key});

  @override
  State<AssetsPage> createState() => _AssetsPageState();
}

class _AssetsPageState extends State<AssetsPage>
    with SingleTickerProviderStateMixin {
  final ScrollController _scrollController = ScrollController();

  late final AssetCubit assetCubit;

  late final StreamSubscription<List<Asset>> _subscription;

  @override
  void initState() {
    super.initState();
    assetCubit = AssetCubit();
    _subscription = assetCubit.assetStream.listen((data) {
      // Handle data
      //Listen for data
      print('Data received: $data');
      //data used to populate listview in streambuilder

      // _assetStreamController.add(data);
    });
  }

  @override
  void dispose() {
    _subscription.cancel();
    _scrollController.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    // Attach a listener to the scroll controller
    _scrollController.addListener(() {
      // when user tries to scroll

      if (_scrollController.position.pixels ==
          _scrollController.position.maxScrollExtent) {
        assetCubit.fetchNextPage();
      }
    });

    return SafeArea(
      child: Scaffold(
        body: StreamBuilder<List<Asset>>(
          stream: assetCubit.assetStream,
          builder: (context, snapshot) {
            if (snapshot.connectionState == ConnectionState.waiting) {
              // Stream is still loading
              assetCubit.fetchNextPage();
              return Center(
                child: CircularProgressIndicator(),
              );
            } else if (snapshot.hasError) {
              // Stream has encountered an error
              return Center(
                child: Text('Error: ${snapshot.error}'),
              );
            } else if (snapshot.hasData) {
              // Stream has emitted data
              final assets = snapshot.data ?? [];
              return buildListView(assets, context);
            } else {
              return Center(
                child: Text('No data'),
              );
            }
          },
        ),
      ),
    );
  }

  Widget buildListView(List<Asset> assets, BuildContext context) {
    return ListView.builder(
      controller: _scrollController,
      itemCount: assets.length + 1,
      itemBuilder: (context, index) {
        if (index < assets.length) {
          final asset = assets[index];
          return AssetCard(
              // asset: asset,
              // onTap: () {
              //   Navigator.pushNamed(
              //     context,
              //     Routes.assetDetails,
              //     arguments: asset,
              //   );
              // },
              );
        } else {
          // Display a loading indicator at the end of the list
          return Center(
            child: CircularProgressIndicator(),
          );
        }
      },
    );
  }
}
