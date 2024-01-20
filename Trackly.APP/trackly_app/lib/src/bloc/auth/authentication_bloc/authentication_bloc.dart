import 'package:bloc/bloc.dart';
import 'package:equatable/equatable.dart';
import 'package:flutter/material.dart';
import 'package:trackly_app/src/data/localstorage/shared_reference_manager.dart';
part 'authentication_event.dart';
part 'authentication_state.dart';

class AuthenticationBloc
    extends Bloc<AuthenticationEvent, AuthenticationState> {
  AuthenticationBloc() : super(AuthenticationUnitialized()) {
    on<AppStarted>((event, emit) async {
      emit(AuthenticationLoading());
      try {
        final isLoggedIn = await SharedPreferencesManager().isLoggedIn();

        if (isLoggedIn) {
          emit(AuthenticationAuthenticated());
        } else {
          emit(AuthenticationUnauthenticated());
        }
      } catch (e) {
        emit(AuthenticationFailure(message: e.toString()));
      }
    });

    on<LoginEvent>((event, emit) async {
      emit(AuthenticationLoading());
      Future.delayed(const Duration(seconds: 1));
      emit(AuthenticationAuthenticated());
    });

    on<LogoutEvent>((event, emit) async {
      emit(AuthenticationLoading());
      Future.delayed(const Duration(seconds: 1));
      emit(AuthenticationUnauthenticated());
    });
  }
}
