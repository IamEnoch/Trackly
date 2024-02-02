import 'package:flutter/material.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/users/users_cubit.dart';
import 'package:trackly_app/src/data/models/Assets/asset.dart';
import 'package:trackly_app/src/utils/all_constants_imports.dart';
import 'package:trackly_app/src/utils/app_colors.dart';
import 'package:trackly_app/src/utils/app_resources.dart';
import 'package:trackly_app/src/utils/widgets/asset_card_small.dart';

class AssetsPage extends StatefulWidget {
  const AssetsPage({super.key});

  @override
  State<AssetsPage> createState() => _AssetsPageState();
}

class _AssetsPageState extends State<AssetsPage> {
  final log = logger(AssetsPage);
  final AssetCubit assetCubit = AssetCubit();

  static const _pageSize = 7;
  int _currentPage = 1;
  bool _isLoading = false;
  bool _fetchFuther = true;
  List<Asset> _assetList = [];
  List<Asset> _filteredAssetList = []; // List for storing filtered assets
  String? _error;

  final ScrollController _scrollController = ScrollController();
  final TextEditingController _searchController = TextEditingController();

  @override
  void initState() {
    super.initState();
    _fetchPage(_currentPage);

    _scrollController.addListener(_onScroll);
    _searchController.addListener(_onSearchChanged);
  }

  // Fetches a page of assets
  Future<void> _fetchPage(int pageKey) async {
    setState(() {
      _isLoading = true;
      _error = null;
    });

    try {
      final newItems = await assetCubit.getAssets(pageKey, _pageSize);

      setState(() {
        if (newItems.isEmpty) {
          _fetchFuther = false;
          _isLoading = false;
        } else {
          _assetList.addAll(newItems);
          _filteredAssetList =
              _assetList; // Initialize filtered list with all assets
          _isLoading = false;
          _currentPage++;
        }
      });
    } catch (e) {
      setState(() {
        _isLoading = false;
        _error = e.toString();
      });
    }
  }

  // Called when the user scrolls to the bottom of the list
  void _onScroll() {
    log.d('Pixels: ${_scrollController.position.pixels}');
    log.d('MaxScrollExtent: ${_scrollController.position.maxScrollExtent}');
    if (_scrollController.position.pixels ==
        _scrollController.position.maxScrollExtent) {
      if (_assetList.length % _pageSize == 0) {
        if (_fetchFuther) {
          log.d('Fetching page $_currentPage');
          _fetchPage(_currentPage);
        }
        log.d('Fetching page $_currentPage');
      } else {
        _fetchFuther = false;
        log.d('No more pages to fetch');
      }
    }
  }

  // Called when the user changes the search text
  void _onSearchChanged() {
    // Filter the asset list based on the search text
    final searchText = _searchController.text.toLowerCase();
    setState(() {
      if (searchText.isEmpty) {
        // If search text is empty, display the entire list
        _filteredAssetList = _assetList;
      } else {
        // If search text is not empty, filter the list
        _filteredAssetList = _assetList
            .where(
                (asset) => asset.assetName.toLowerCase().contains(searchText))
            .toList();
      }
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      floatingActionButton: FloatingActionButton(
        onPressed: () {},
        backgroundColor: AppColors.pinkColor,
        child: const Icon(
          Icons.add,
          color: Colors.white,
        ),
      ),
      body: RefreshIndicator(
        onRefresh: () async {
          _currentPage = 1;
          _assetList.clear();
          _fetchFuther = true;
          await _fetchPage(_currentPage);
        },
        child: SafeArea(
          child: Padding(
            padding: const EdgeInsets.symmetric(horizontal: 16),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.start,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                SizedBox(height: MediaQuery.of(context).size.height * 0.02),
                //Assets Page Title
                Text(
                  'Assets',
                  style: AppResources().appStyles.textStyles.headineH4,
                ),
                SizedBox(height: MediaQuery.of(context).size.height * 0.02),
                //search bar
                SearchBar(
                  //on tap pop up keyboard
                  onTap: () {
                    //pop up keyboard
                  },
                  controller: _searchController,
                  hintText: 'Search for assets',
                  onChanged: (value) {},
                  //leading icon
                  leading: const Icon(
                    Icons.line_weight_rounded,
                    color: AppColors.lightGreyColor,
                    weight: 10,
                  ),
                  //Two trailing icons. I for seatch and one image asset
                  trailing: [
                    const Icon(
                      Icons.search,
                      color: AppColors.lightGreyColor,
                    ),
                    SizedBox(width: MediaQuery.of(context).size.width * 0.04),
                    InkWell(
                      child: Image.asset(AppAssets.scanIcon, scale: 1.3),
                      onTap: () {},
                    )
                  ],
                ),
                SizedBox(height: MediaQuery.of(context).size.height * 0.03),
                Expanded(
                  child: ListView.builder(
                    controller: _scrollController,
                    itemCount: _filteredAssetList.length + (_isLoading ? 1 : 0),
                    itemBuilder: (BuildContext context, int index) {
                      if (index == _assetList.length) {
                        // Loading Indicator
                        return _isLoading
                            ? const Center(
                                child: CircularProgressIndicator(),
                              )
                            : Container(); // Return an empty container if not loading
                      } else {
                        // Asset Item
                        return Column(
                          children: [
                            InkWell(
                              onTap: () {
                                UsersCubit().toUserInitial();
                                Navigator.of(context).pushNamed(
                                  assetAdminPageRoute,
                                  arguments: {
                                    'barcodeNumber':
                                        _filteredAssetList[index].barcodeNumber,
                                    'assetName':
                                        _filteredAssetList[index].assetName,
                                    'assetCategory':
                                        _filteredAssetList[index].category,
                                    'assetDepartment': _filteredAssetList[index]
                                        .departmentName,
                                    'assetLocation':
                                        _filteredAssetList[index].locationName,
                                    'tickets':
                                        _filteredAssetList[index].tickets,
                                    'asset': _filteredAssetList[index]
                                  },
                                );
                              },
                              child: AssetCardSmall(
                                  asset: _filteredAssetList[index]),
                            ),
                            const SizedBox(height: 10),
                          ],
                        );
                      }
                    },
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
