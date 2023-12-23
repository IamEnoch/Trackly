import 'package:auth0_flutter/auth0_flutter.dart';
import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_bloc.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_event.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_state.dart';
import 'package:trackly_app/src/bloc/auth/authentication_bloc/authentication_bloc.dart';
import 'package:trackly_app/src/utils/all_constants_imports.dart';
import 'package:trackly_app/src/utils/app_resources.dart';
import 'package:trackly_app/src/utils/routes.dart';

class MyLoginPage extends StatefulWidget {
  const MyLoginPage({super.key, required this.title});

  // This widget is the home page of your application. It is stateful, meaning
  // that it has a State object (defined below) that contains fields that affect
  // how it looks.

  // This class is the configuration for the state. It holds the values (in this
  // case the title) provided by the parent (in this case the App widget) and
  // used by the build method of the State. Fields in a Widget subclass are
  // always marked "final".

  final String title;

  @override
  State<MyLoginPage> createState() => _MyLoginPageState();
}

class _MyLoginPageState extends State<MyLoginPage> {
  @override
  Widget build(BuildContext context) {
    return BlocListener<AuthBloc, AuthState>(
      listener: (context, state) {
        // TODO: implement listener
        if (state is LoginSuccess) {
          Navigator.of(context).pushReplacementNamed(tabPageRoute);
        }
      },
      child: Scaffold(
        body: Center(
          child: SafeArea(
            child: Padding(
              padding: const EdgeInsets.only(left: 7.0, right: 7.0),
              child: Column(
                children: <Widget>[
                  SizedBox(
                    height: MediaQuery.of(context).size.height * 0.1,
                  ),
                  //Login picture
                  Image.asset(
                    AppAssets.loginpic,
                    width: MediaQuery.of(context).size.width * 1,
                    height: MediaQuery.of(context).size.height * 0.4,
                  ),
                  SizedBox(
                    height: MediaQuery.of(context).size.height * 0.05,
                  ),
                  Text(
                    'Trackly',
                    style: AppResources().appStyles.textStyles.headineH4,
                  ),
                  SizedBox(
                    height: MediaQuery.of(context).size.height * 0.03,
                  ),
                  //Centered paragraph
                  Text(
                    'Revolutionizing technical fault management for streamlined operations. Log in to create work tickets, manage assets, and expedite issue resolutions for enhanced productivity.',
                    style: AppResources().appStyles.textStyles.componentsFilter,
                    textAlign: TextAlign.center,
                  ),
                  SizedBox(
                    height: MediaQuery.of(context).size.height * 0.06,
                  ),
                  SizedBox(
                    height: MediaQuery.of(context).size.height * 0.06,
                    width: MediaQuery.of(context).size.width * 0.5,
                    child: OutlinedButton(
                      onPressed: () async {
                        context.read<AuthBloc>().add(
                              const Login(),
                            );
                      },
                      style: AppResources()
                          .buttonStyles
                          .buttonStyle(backgroundColor: Colors.black),
                      child: Text(
                        "LOGIN",
                        style: AppResources()
                            .appStyles
                            .textStyles
                            .componentsButtonDefault
                            .copyWith(
                              color: Colors.white,
                            ),
                      ),
                    ),
                  ),
                ],
              ),
            ),
          ),
        ),
      ),
    );
  }
}
