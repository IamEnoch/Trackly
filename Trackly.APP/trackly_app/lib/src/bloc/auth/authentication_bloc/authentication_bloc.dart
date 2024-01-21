import 'package:bloc/bloc.dart';
import 'package:equatable/equatable.dart';
import 'package:flutter/material.dart';
import 'package:trackly_app/src/bloc/auth/role_bloc/role_bloc.dart';
import 'package:trackly_app/src/bloc/auth/role_bloc/role_event.dart';
import 'package:trackly_app/src/data/localstorage/shared_reference_manager.dart';
part 'authentication_event.dart';
part 'authentication_state.dart';

class AuthenticationBloc
    extends Bloc<AuthenticationEvent, AuthenticationState> {
  // Singleton instance
  static final AuthenticationBloc _instance = AuthenticationBloc._internal();

  factory AuthenticationBloc() {
    return _instance;
  }
  AuthenticationBloc._internal() : super(AuthenticationUnitialized()) {
    on<AppStarted>((event, emit) async {
      emit(AuthenticationLoading());
      try {
        final isLoggedIn = await SharedPreferencesManager().isLoggedIn();

        if (isLoggedIn) {
          //change role state to admin
          RoleBloc().add(CheckRoleEvent());
          emit(AuthenticationAuthenticated());
        } else {
          emit(AuthenticationUnauthenticated());
        }
      } catch (e) {
        emit(AuthenticationFailure(message: e.toString()));
      }
    });

    on<LoginAuthenticationEvent>((event, emit) async {
      emit(AuthenticationLoading());
      Future.delayed(const Duration(seconds: 1));
      emit(AuthenticationAuthenticated());
    });

    on<LogoutAuthenticationEvent>((event, emit) async {
      emit(AuthenticationLoading());
      Future.delayed(const Duration(seconds: 1));
      emit(AuthenticationUnauthenticated());
    });
  }
}
