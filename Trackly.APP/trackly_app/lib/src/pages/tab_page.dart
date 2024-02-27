import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:mobile_scanner/mobile_scanner.dart';
import 'package:trackly_app/src/bloc/auth/role_bloc/role_bloc.dart';
import 'package:trackly_app/src/bloc/auth/role_bloc/role_state.dart';
import 'package:trackly_app/src/pages/assets/assets_page.dart';
import 'package:trackly_app/src/pages/home_page.dart';
import 'package:trackly_app/src/pages/auth/profile_page.dart';
import 'package:trackly_app/src/pages/main_scan_page.dart';
import 'package:trackly_app/src/pages/workItems/work_item_create_page.dart';
import 'package:trackly_app/src/utils/all_constants_imports.dart';
import 'package:trackly_app/src/utils/app_colors.dart';

class TabPage extends StatefulWidget {
  const TabPage({Key? key}) : super(key: key);

  @override
  State<TabPage> createState() => _TabPageState();
}

class _TabPageState extends State<TabPage> {
  int _currentIndex = 0;
  late PageController _pageController;
  final mobileController = MobileScannerController();

  @override
  void initState() {
    super.initState();
    _pageController = PageController();
  }

  @override
  void dispose() {
    _pageController.dispose();
    super.dispose();
  }

  void _disposeTab(int tabIndex) {
    // Add disposal logic for the tab at the given index
    print('Disposing resources for tab $tabIndex');
  }

  @override
  Widget build(BuildContext context) {
    return BlocBuilder<RoleBloc, RoleState>(
      builder: (context, state) {
        if (state is RoleAdmin) {
          return Scaffold(
            body: SizedBox.expand(
              child: PageView(
                controller: _pageController,
                onPageChanged: (index) {
                  if (_currentIndex != index) {
                    _disposeTab(_currentIndex);
                  }
                  _pageController.jumpToPage(index);
                  setState(() => _currentIndex = index);
                },
                children: <Widget>[
                  HomePage(),
                  AssetsPage(),
                  MainScanPage(),
                  HomePage(),
                  ProfilePage(),
                ],
              ),
            ),
            bottomNavigationBar: BottomNavigationBar(
              selectedLabelStyle: TextStyle(
                color: Colors.black,
              ),
              unselectedLabelStyle: TextStyle(
                color: Colors.black,
              ),
              type: BottomNavigationBarType.fixed,
              currentIndex: _currentIndex,
              onTap: (index) {
                setState(() => _currentIndex = index);
                _pageController.jumpToPage(index);
              },
              items: const [
                BottomNavigationBarItem(
                  icon: Icon(Icons.home, color: AppColors.lightGreyColor),
                  label: 'Home',
                ),
                BottomNavigationBarItem(
                  icon: Icon(Icons.menu_book, color: AppColors.lightGreyColor),
                  label: 'Assets',
                ),
                BottomNavigationBarItem(
                  icon: Icon(Icons.handyman, color: AppColors.lightGreyColor),
                  label: 'Work items',
                ),
                BottomNavigationBarItem(
                  icon: Icon(Icons.list_alt_sharp,
                      color: AppColors.lightGreyColor),
                  label: 'Tickets',
                ),
                BottomNavigationBarItem(
                  icon: Icon(Icons.person, color: AppColors.lightGreyColor),
                  label: 'Settings',
                ),
              ],
            ),
          );
        } else {
          return Scaffold(
            body: SizedBox.expand(
              child: PageView(
                controller: _pageController,
                onPageChanged: (index) {
                  if (_currentIndex != index) {
                    _disposeTab(_currentIndex);
                  }
                  _pageController.jumpToPage(index);
                  setState(() => _currentIndex = index);
                },
                children: <Widget>[
                  HomePage(),
                  WorkItemCreatePage(),
                  MainScanPage(),
                  HomePage(),
                  ProfilePage(),
                ],
              ),
            ),
            bottomNavigationBar: BottomNavigationBar(
              selectedLabelStyle: TextStyle(
                color: Colors.black,
              ),
              unselectedLabelStyle: TextStyle(
                color: Colors.black,
              ),
              type: BottomNavigationBarType.fixed,
              currentIndex: _currentIndex,
              onTap: (index) {
                setState(() => _currentIndex = index);
                _pageController.jumpToPage(index);
              },
              items: [
                BottomNavigationBarItem(
                  icon: Icon(Icons.apps, color: Colors.black),
                  label: 'Home',
                ),
                BottomNavigationBarItem(
                  icon: Image.asset(AppAssets.workItemIcon),
                  label: 'Work Item',
                ),
                BottomNavigationBarItem(
                  icon: Image.asset(AppAssets.scanIcon, scale: 1.3),
                  label: 'Scan',
                ),
                BottomNavigationBarItem(
                  icon: Image.asset(AppAssets.ticketsIcon),
                  label: 'Tickets',
                ),
                BottomNavigationBarItem(
                  icon: Icon(Icons.person, color: Colors.black),
                  label: 'Settings',
                ),
              ],
            ),
          );
        }
      },
    );
  }
}
