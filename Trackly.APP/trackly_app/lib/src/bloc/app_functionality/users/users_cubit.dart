import 'dart:async';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/users/users_state.dart';
import 'package:trackly_app/src/data/services/providers/user_provicder.dart';

class UsersCubit extends Cubit<UsersState> {
  ///Singleton instance
  static final UsersCubit _instance = UsersCubit._internal();

  factory UsersCubit() {
    return _instance;
  }
  UsersCubit._internal() : super(UsersInitial());
  final log = logger(UsersCubit);

  //Fetch users
  Future<void> fetchUsers() async {
    emit(UsersLoading());
    try {
      final response = await UserProvider().getAllUsers();
      if (response.error) {
        emit(UsersFailure(message: response.errorMessage));
        log.e(response.errorMessage);
        return;
      } else if (response.response == null) {
        emit(const UsersFailure(message: 'No asset found'));
        log.e('No asset found');
        log.e(response.errorMessage);
        return;
      } else {
        emit(UsersFetched(users: response.response!));
        log.d('The response is ${response.response}');
      }
    } on Exception catch (e) {
      emit(UsersFailure(message: e.toString()));
    }
  }

  Future<void> fetchUser(String userId) async {
    emit(UserLoading());
    try {
      final response = await UserProvider().getUserByUserId(userId);
      if (response.error) {
        emit(UserFailure(message: response.errorMessage));
        log.e(response.errorMessage);
        return;
      } else if (response.response == null) {
        emit(const UserFailure(message: 'No asset found'));
        log.e('No asset found');
        log.e(response.errorMessage);
        return;
      } else {
        emit(UserFetched(user: response.response!));
        log.d('The response is ${response.response}');
      }
    } on Exception catch (e) {
      emit(UserFailure(message: e.toString()));
    }
  }

  void toUserInitial() {
    emit(UsersInitial());
  }
}
