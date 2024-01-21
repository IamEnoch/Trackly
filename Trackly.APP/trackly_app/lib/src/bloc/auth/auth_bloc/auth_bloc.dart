import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_event.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_state.dart';
import 'package:trackly_app/src/bloc/auth/authentication_bloc/authentication_bloc.dart';
import 'package:trackly_app/src/bloc/auth/role_bloc/role_bloc.dart';
import 'package:trackly_app/src/bloc/auth/role_bloc/role_event.dart';
import 'package:trackly_app/src/data/services/providers/auth_provider.dart';

class AuthBloc extends Bloc<AuthEvent, AuthState> {
  //add logger
  final log = logger(AuthBloc);

  //Singleton instanceS
  static final AuthBloc _instance = AuthBloc._internal();

  factory AuthBloc() {
    return _instance;
  }

  AuthBloc._internal() : super(AuthInitial()) {
    on<LoginEvent>((event, emit) async {
      try {
        log.d('LoginLoading event called');
        emit(LoginLoading());
        final user = await AuthProviders().loginAccount();
        if (user) {
          AuthenticationBloc().add(LoginAuthenticationEvent());
          RoleBloc().add(AddRoleEvent());
          //log.d('Login success');
          //emit(LoginSuccess());
        } else {
          log.d('Login failed');
          emit(const LoginFailure(message: 'Login Failed'));
        }
      } catch (e) {
        log.e('Login failure with exception $e');
        emit(LoginFailure(message: e.toString()));
      }
    });

    on<LoginSuccessEvent>((event, emit) {
      emit(LoginSuccess());
      log.d('Emitted Login success');
    });

    on<LoginFailureEvent>((event, emit) {
      emit(LoginFailure(message: event.message));
      log.d('Emitted Login failure');
    });

    on<LogoutEvent>((event, emit) async {
      try {
        emit(LogoutLoading());
        final user = await AuthProviders().logoutAccount();
        if (user) {
          RoleBloc().add(RemoveRoleEvent());
          AuthenticationBloc().add(LogoutAuthenticationEvent());
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
