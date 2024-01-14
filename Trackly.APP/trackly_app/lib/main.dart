import 'package:flutter/material.dart';
import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/workItems/workt_item_cubit.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_bloc.dart';
import 'package:trackly_app/src/bloc/auth/authentication_bloc/authentication_bloc.dart';
import 'package:trackly_app/src/pages/assets/asset_details_page.dart';
import 'package:trackly_app/src/pages/assets/assets_success_page.dart';
import 'package:trackly_app/src/pages/home_page.dart';
import 'package:trackly_app/src/pages/auth/login_page.dart';
import 'package:trackly_app/src/pages/scan_page.dart';
import 'package:trackly_app/src/pages/tickets/ticket_details_page.dart';
import 'package:trackly_app/src/pages/tickets/work_item_page.dart';
import 'package:trackly_app/src/utils/routes.dart';
import 'package:trackly_app/tab_page.dart';

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
          lazy: false,
          create: (context) => AuthenticationBloc()..add(AppStarted()),
        ),
        BlocProvider(
          lazy: false,
          create: (context) => AuthBloc(),
        ),
        BlocProvider(create: (context) => AssetCubit()),
        BlocProvider(create: (context) => WorkItemCubit()),
      ],
      child: BlocBuilder<AuthenticationBloc, AuthenticationState>(
          builder: (context, state) {
        final Widget startPage;
        if (state is AuthenticationAuthenticated) {
          startPage = const TabPage();
        } else if (state is AuthenticationUnauthenticated) {
          startPage = const MyLoginPage(
            title: 'This is the home page',
          );
        } else {
          startPage = const MyLoginPage(
            title: 'This is the home page',
          );
        }
        return MaterialApp(
          title: 'Flutter Demo',
          theme: ThemeData(
            scaffoldBackgroundColor: Colors.white,
            colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple),
            useMaterial3: true,
          ),
          home: startPage,
          routes: {
            homePageRoute: (context) => const HomePage(),
            signInRoute: (context) => const MyLoginPage(
                  title: 'This is the login screen',
                ),
            tabPageRoute: (context) => const TabPage(),
            assetSuccssPageRoute: (context) => const AssetsSuccessPage(),
            ScanPageRoute: (context) => ScanPage(),
            assetDetailsPageRoute: (context) => AssetDetailsPage(),
            ticketDetailsPageRoute: (context) => const TicketDetailsPage(),
            workItemPageRoute: (context) => const WorkItemPage(),
          },
        );
      }),
    );
  }
}
