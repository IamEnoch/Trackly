import 'package:auth0_flutter/auth0_flutter.dart';
import 'package:flutter/material.dart';
import 'package:flutter_dotenv/flutter_dotenv.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_bloc.dart';
import 'package:trackly_app/src/bloc/auth/authentication_bloc/authentication_bloc.dart';
import 'package:trackly_app/src/pages/home_page.dart';
import 'package:trackly_app/src/pages/login_page.dart';
import 'package:trackly_app/src/utils/routes.dart';

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
      ],
      child: BlocBuilder<AuthenticationBloc, AuthenticationState>(
          builder: (context, state) {
        final Widget startPage;
        if (state is AuthenticationAuthenticated) {
          startPage = const HomePage();
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
            colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple),
            useMaterial3: true,
          ),
          home: startPage,
          routes: {
            homePageRoute: (context) => const HomePage(),
            signInRoute: (context) => const MyLoginPage(
                  title: 'This is the login screen',
                ),
          },
        );
      }),
    );
  }
}
