import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_bloc.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_event.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_state.dart';
import 'package:trackly_app/src/bloc/auth/authentication_bloc/authentication_bloc.dart';
import 'package:trackly_app/src/utils/routes.dart';

class HomePage extends StatefulWidget {
  const HomePage({super.key});

  @override
  State<HomePage> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  @override
  Widget build(BuildContext context) {
    return BlocListener<AuthBloc, AuthState>(
      listener: (context, state) {
        // TODO: implement listener
        if (state is LogoutSuccess) {
          Navigator.of(context).pushReplacementNamed(signInRoute);
        }
      },
      child: Scaffold(
        appBar: AppBar(
          title: const Text('name'),
        ),
        body: Center(
            child: Column(
          children: [
            const Text(
              'This is the',
              style: TextStyle(fontSize: 20),
            ),
            ElevatedButton(
                onPressed: () async {
                  context.read<AuthBloc>().add(
                        const LogoutEvent(),
                      );
                },
                child: const Text("Log out"))
          ],
        )),
      ),
    );
  }
}
