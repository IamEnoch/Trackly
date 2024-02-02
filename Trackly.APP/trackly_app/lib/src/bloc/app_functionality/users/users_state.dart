import 'package:equatable/equatable.dart';
import 'package:trackly_app/src/data/models/Auth/user.dart';

class UsersState extends Equatable {
  const UsersState();

  @override
  List<Object> get props => [];
}

final class UsersInitial extends UsersState {}

final class UsersLoading extends UsersState {}

final class UsersEmpty extends UsersState {}

final class UsersSuccess extends UsersState {}

final class UsersFailure extends UsersState {
  final String message;

  const UsersFailure({required this.message});

  @override
  List<Object> get props => [message];
}

//User related states
final class UserLoading extends UsersState {}

final class UserCreated extends UsersState {}

final class UserUpdated extends UsersState {}

final class UserDeleted extends UsersState {}

final class UserFetched extends UsersState {
  final User user;

  const UserFetched({required this.user});

  @override
  List<Object> get props => [user];
}

final class UserFailure extends UsersState {
  final String message;

  const UserFailure({required this.message});

  @override
  List<Object> get props => [message];
}
