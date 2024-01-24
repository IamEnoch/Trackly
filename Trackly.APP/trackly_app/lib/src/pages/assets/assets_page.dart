import 'dart:async';

import 'package:flutter/material.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_cubit.dart';
import 'package:trackly_app/src/data/models/Assets/asset.dart';
import 'package:trackly_app/src/utils/widgets/asset_card.dart';

import 'package:infinite_scroll_pagination/infinite_scroll_pagination.dart';

class AssetsPage extends StatefulWidget {
  const AssetsPage({super.key});

  @override
  State<AssetsPage> createState() => _AssetsPageState();
}

class _AssetsPageState extends State<AssetsPage> {
  final AssetCubit assetCubit = AssetCubit();

  static const _pageSize = 7;

  final PagingController<int, Asset> _pagingController =
      PagingController(firstPageKey: 0);

  @override
  void initState() {
    _pagingController.addPageRequestListener((pageKey) async {
      await _fetchPage(pageKey);
    });
    super.initState();
  }

  @override
  void dispose() {
    _pagingController.dispose();
    super.dispose();
  }

  Future<void> _fetchPage(int pageKey) async {
    try {
      final newItems = await assetCubit.getAssets(pageKey, _pageSize);
      final isLastPage = newItems.length < _pageSize;
      if (isLastPage) {
        _pagingController.appendLastPage(newItems);
      } else {
        final nextPageKey = ++pageKey;
        _pagingController.appendPage(newItems, nextPageKey);
      }
    } catch (error) {
      _pagingController.error = error;
    }
  }

  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: PagedListView<int, Asset>(
        pagingController: _pagingController,
        builderDelegate: PagedChildBuilderDelegate<Asset>(
          itemBuilder: (context, item, index) => AssetCard(
            asset: item,
            // onTap: () {
            //   Navigator.pushNamed(
            //     context,
            //     Routes.assetDetails,
            //     arguments: asset,
            //   );
            // },
          ),
          firstPageErrorIndicatorBuilder: (_) =>
              const CircularProgressIndicator(),
          newPageErrorIndicatorBuilder: (_) => const Text('Fetching assets'),
          firstPageProgressIndicatorBuilder: (_) =>
              const Text('Fetching assets'),
          newPageProgressIndicatorBuilder: (_) =>
              const CircularProgressIndicator(),
          noItemsFoundIndicatorBuilder: (_) =>
              const CircularProgressIndicator(),
          noMoreItemsIndicatorBuilder: (_) => const CircularProgressIndicator(),
        ),
      ),
    );
  }
}
