import 'package:auth0_flutter/auth0_flutter.dart';
import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_bloc.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_event.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_state.dart';
import 'package:trackly_app/src/bloc/auth/authentication_bloc/authentication_bloc.dart';
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
        appBar: AppBar(
          backgroundColor: Theme.of(context).colorScheme.inversePrimary,
          title: Text(widget.title),
        ),
        body: Center(
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            children: <Widget>[
              ElevatedButton(
                  onPressed: () async {
                    context.read<AuthBloc>().add(
                          const Login(),
                        );
                  },
                  child: const Text("Log in"))
            ],
          ),
        ),
      ),
    );
  }
}
