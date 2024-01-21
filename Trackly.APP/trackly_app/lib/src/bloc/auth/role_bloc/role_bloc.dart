import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_bloc.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_event.dart';
import 'package:trackly_app/src/bloc/auth/role_bloc/role_event.dart';
import 'package:trackly_app/src/bloc/auth/role_bloc/role_state.dart';
import 'package:trackly_app/src/data/localstorage/shared_reference_manager.dart';
import 'package:trackly_app/src/data/models/Auth/user_role.dart';
import 'package:trackly_app/src/data/services/providers/auth_provider.dart';

class RoleBloc extends Bloc<RoleEvent, RoleState> {
  //add logger
  final log = logger(RoleBloc);

  // Singleton instance
  static final RoleBloc _instance = RoleBloc._internal();

  factory RoleBloc() {
    return _instance;
  }
  RoleBloc._internal() : super(RoleInitial()) {
    on<AddRoleEvent>(
      (event, emit) async {
        try {
          emit(AddingRoleLoading());
          log.i('Emmited AddingRoleLoading');
          //Get user roles
          final response = await AuthProviders().getUserRole();
          if (response.response == null) {
            emit(const RoleFailure(message: 'Response is null'));
            AuthBloc()
                .add(const LoginFailureEvent(message: 'Response is null'));
            log.e('Emmited Role failure. Response is null');
          } else {
            List<UserRole> userRoles = response.response!;
            log.i('The user role are: $userRoles');
            if (userRoles.isEmpty) {
              emit(const RoleFailure(message: 'No role found'));
              AuthBloc().add(const LoginFailureEvent(message: 'No role found'));
              log.e('Emmited Role failure. No role found');
            } else if (userRoles.length == 1) {
              if (userRoles[0].name == 'admin' ||
                  userRoles[0].name == 'technician') {
                //set in shared preferences
                await SharedPreferencesManager().setRole(value: 'admin');
                emit(RoleAdmin());
                AuthBloc().add(const LoginSuccessEvent());
                log.i("Emmited RoleAdmin or RoleTechncian");
              } else {
                //emit role failure
                emit(const RoleFailure(message: 'Role failure'));
                AuthBloc().add(
                    const LoginFailureEvent(message: 'Unexpected role found'));
                log.e('Emmited Role failure: Unexpected role found');
              }
            } else {
              emit(RoleAdmin());
              AuthBloc().add(const LoginSuccessEvent());
              log.i('Emmited RoleAdmin');
            }
          }
        } catch (e) {
          emit(RoleFailure(message: 'Emmited RoleFailure with exception: $e'));
          AuthBloc().add(LoginFailureEvent(
              message: 'Emmited RoleFailure with exception: $e'));
          log.e('Emmited RoleFailure. Message: $e');
        }
      },
    );

    on<RemoveRoleEvent>(
      (event, emit) {
        emit(RemovingRoleLoading());
        log.i('Emmited RemovingRoleLoading');
        emit(RoleInitial());
        log.i('Emmited RoleInitial');
      },
    );

    on<CheckRoleEvent>(
      (event, emit) async {
        emit(CheckingRoleLoading());
        log.i('Emmited CheckingRoleLoading');
        //Check from shared preferences
        final role = await SharedPreferencesManager().getRole();
        if (role == 'admin') {
          emit(RoleAdmin());
          log.i('Emmited RoleAdmin');
        } else if (role == 'technician') {
          emit(RoleTechnician());
          log.i('Emmited RoleTechnician');
        } else {
          emit(const RoleFailure(message: 'Role failure'));
          log.e('Emmited Role failure: Unexpected role string found');
        }
      },
    );
  }
}
