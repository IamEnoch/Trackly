import 'package:bloc/bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/auth/authentication_bloc/authentication_bloc.dart';
import 'package:trackly_app/src/bloc/auth/role_bloc/role_event.dart';
import 'package:trackly_app/src/bloc/auth/role_bloc/role_state.dart';
import 'package:trackly_app/src/data/models/Auth/user_role.dart';
import 'package:trackly_app/src/data/services/providers/auth_provider.dart';

class RoleBloc extends Bloc<RoleEvent, RoleState> {
  //add logger
  final log = logger(RoleBloc);
  RoleBloc() : super(RoleInitial()) {
    on<AddRoleEvent>(
      (event, emit) async {
        //emit(AuthenticationLoading());
        try {
          //Get user roles
          final response = await AuthProviders().getUserRole();
          //if response is null, call event to logout using context.read
          if (response.response == null) {
            emit(RoleInitial());
            log.i('The reponse body is ${response.response}');
            log.i("Emmited RoleInitial");
          } else {
            //check whether list has anything.
            //Roles are admin and technician
            //If admin string == admin, emit admin state
            //If technician string == technicial, emit technician state
            //If none, logout and emit role initial
            //if both, emit admin state
            List<UserRole> userRoles = response.response!;
            if (userRoles.isEmpty) {
              emit(RoleInitial());
              log.i("Emmited RoleInitial");
            } else if (userRoles.length == 1) {
              if (userRoles[0].name == "admin") {
                emit(RoleAdmin());
                log.i("Emmited RoleAdmin");
              } else if (userRoles[0].name == "technician") {
                emit(RoleTechnician());
                log.i("Emmited RoleTechnician");
              } else {
                AuthenticationBloc().add(LoginEvent());
                emit(RoleInitial());
              }
            } else {
              emit(RoleAdmin());
              log.i("Emmited RoleAdmin");
            }
          }
        } catch (e) {
          emit(RoleInitial());
          log.i("Emmited RoleInitial");
        }
      },
    );

    on<RemoveRoleEvent>(
      (event, emit) {
        emit(RoleInitial());
        log.i("Emmited RoleInitial");
      },
    );
  }
}
