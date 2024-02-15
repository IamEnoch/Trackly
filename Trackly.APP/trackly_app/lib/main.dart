import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:trackly_app/src/bloc/app_functionality/Scans/scan_bloc.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/users/users_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/workItems/workt_item_cubit.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_bloc.dart';
import 'package:trackly_app/src/bloc/auth/authentication_bloc/authentication_bloc.dart';
import 'package:trackly_app/src/bloc/auth/role_bloc/role_bloc.dart';
import 'package:trackly_app/src/pages/assets/add_asset_page.dart';
import 'package:trackly_app/src/pages/assets/asset_admin_page.dart';
import 'package:trackly_app/src/pages/assets/asset_details_page.dart';
import 'package:trackly_app/src/pages/assets/assets_failure_page.dart';
import 'package:trackly_app/src/pages/assets/assets_success_page.dart';
import 'package:trackly_app/src/pages/assets/edit_asset_page.dart';
import 'package:trackly_app/src/pages/barcode_scan_page.dart';
import 'package:trackly_app/src/pages/home_page.dart';
import 'package:trackly_app/src/pages/auth/login_page.dart';
import 'package:trackly_app/src/pages/main_scan_page.dart';
import 'package:trackly_app/src/pages/tickets/ticket_details_page.dart';
import 'package:trackly_app/src/pages/workItems/work_item_page.dart';
import 'package:trackly_app/src/utils/routes.dart';
import 'package:trackly_app/src/pages/tab_page.dart';
import 'package:trackly_app/src/utils/widgets/splash_screen.dart';

Future<void> main() async {
  await dotenv.load(fileName: ".env");
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MultiBlocProvider(
      providers: [
        BlocProvider(
          create: (context) => AuthenticationBloc()..add(AppStarted()),
        ),
        BlocProvider(
          create: (context) => AuthBloc(),
        ),
        BlocProvider(create: (context) => AssetCubit()),
        BlocProvider(create: (context) => WorkItemCubit()),
        BlocProvider(create: (context) => RoleBloc()),
        BlocProvider(create: (context) => ScanBloc()),
        BlocProvider(
          create: (context) => UsersCubit(),
        )
      ],
      child: BlocBuilder<AuthenticationBloc, AuthenticationState>(
          builder: (context, state) {
        Widget startPage = const SplashScreen();
        if (state is AuthenticationAuthenticated) {
          startPage = const TabPage();
        } else if (state is AuthenticationUnauthenticated) {
          startPage = const MyLoginPage(
            title: 'This is the home page',
          );
        } else if (state is AuthenticationLoading) {
          startPage = const SplashScreen();
        } else if (state is AuthenticationUnitialized) {
          startPage = const SplashScreen();
        }
        return MaterialApp(
          title: 'Flutter Demo',
          debugShowCheckedModeBanner: false,
          themeMode: ThemeMode.system,
          theme: ThemeData(
            scaffoldBackgroundColor: Colors.white,
            colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple),
            useMaterial3: true,
          ),
          home: startPage,
          routes: {
            splashPageRoute: (context) => const SplashScreen(),
            homePageRoute: (context) => const HomePage(),
            signInRoute: (context) => const MyLoginPage(
                  title: 'This is the login screen',
                ),
            tabPageRoute: (context) => const TabPage(),
            assetSuccssPageRoute: (context) => const AssetsSuccessPage(),
            assetFailurePageRoute: (context) => const AssetsFailurePage(),
            assetAdminPageRoute: (context) => AssetAdminPage(),
            mainScanPageRoute: (context) => const MainScanPage(),
            barcodeScanPageRoute: (context) => const BarcodeScanPage(),
            assetDetailsPageRoute: (context) => AssetDetailsPage(),
            ticketDetailsPageRoute: (context) => const TicketDetailsPage(),
            workItemPageRoute: (context) => const WorkItemPage(),
            editAssetPageRoute: (context) => const EditAssetPage(),
            createAssetPageRoute: (context) => const CreateAssetPage(),
          },
        );
      }),
    );
  }
}
