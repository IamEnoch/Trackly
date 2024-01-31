import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_bloc.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_event.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_state.dart';
import 'package:trackly_app/src/utils/all_constants_imports.dart';
import 'package:trackly_app/src/utils/app_resources.dart';

class MyLoginPage extends StatefulWidget {
  const MyLoginPage({super.key, required this.title});

  final String title;

  @override
  State<MyLoginPage> createState() => _MyLoginPageState();
}

class _MyLoginPageState extends State<MyLoginPage> {
  //add logger
  final log = logger(MyLoginPage);
  @override
  Widget build(BuildContext context) {
    return MultiBlocListener(
      listeners: [
        BlocListener<AuthBloc, AuthState>(
          bloc: AuthBloc(),
          listener: (context, authState) {
            if (authState is LoginSuccess) {
              log.d('Login success from login page bloc listener');
              log.d(
                  'Navigating to tab page from login page bloc listener as admin');
              Navigator.of(context).pushReplacementNamed(tabPageRoute);
            } else if (authState is LoginLoading) {
              log.d('The auth state is ${authState.toString()}');
            } else {
              log.d('The auth state is ${authState.toString()}');
            }
          },
        ),
        // BlocListener<RoleBloc, RoleState>(
        //   listener: (context, roleState) {
        //     if (roleState is RoleAdmin) {
        //       log.d(
        //           'Navigating to tab page from login page bloc listener as admin');
        //       Navigator.of(context).pushReplacementNamed(tabPageRoute);
        //     } else if (roleState is RoleTechnician) {
        //       log.d(
        //           'Navigating to tab page from login page bloc listener as technician');
        //       Navigator.of(context).pushReplacementNamed(tabPageRoute);
        //     } else {
        //       Navigator.of(context).pushReplacementNamed(tabPageRoute);
        //       log.d('Logging out : Role bloc listener');
        //     }
        //   },
        // ),
      ],
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
                              const LoginEvent(),
                            );
                      },
                      style: AppResources()
                          .buttonStyles
                          .buttonStyle(backgroundColor: Colors.black),
                      child: BlocBuilder<AuthBloc, AuthState>(
                        builder: (context, state) {
                          if (state is LoginLoading) {
                            //return spinner
                            return const CircularProgressIndicator(
                              color: Colors.white,
                            );
                          }
                          return Text(
                            "LOGIN",
                            style: AppResources()
                                .appStyles
                                .textStyles
                                .componentsButtonDefault
                                .copyWith(
                                  color: Colors.white,
                                ),
                          );
                        },
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
