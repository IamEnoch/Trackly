import 'package:bloc/bloc.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_event.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_state.dart';
import 'package:trackly_app/src/bloc/auth/authentication_bloc/authentication_bloc.dart';

import 'package:trackly_app/src/data/services/providers/auth_provider.dart';

class AuthBloc extends Bloc<AuthEvent, AuthState> {
  AuthBloc() : super(AuthInitial()) {
    on<Login>((event, emit) async {
      try {
        emit(LoginLoading());
        final user = await AuthProviders().loginAccount();
        if (user) {
          AuthenticationBloc().add(LoggedIn());
          emit(LoginSuccess());
        } else {
          emit(const LoginFailure(message: 'Login Failed'));
        }
      } catch (e) {
        emit(LoginFailure(message: e.toString()));
      }
    });

    on<Logout>((event, emit) async {
      try {
        emit(LogoutLoading());
        final user = await AuthProviders().logoutAccount();
        if (user) {
          AuthenticationBloc().add(LoggedOut());
          emit(LogoutSuccess());
        } else {
          emit(const LogoutFailure(message: 'Logout Failed'));
        }
      } catch (e) {
        emit(LogoutFailure(message: e.toString()));
      }
    });
  }
}
