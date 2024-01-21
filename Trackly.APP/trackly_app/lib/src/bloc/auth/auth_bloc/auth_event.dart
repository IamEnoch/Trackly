import 'package:equatable/equatable.dart';
import 'package:flutter/material.dart';

@immutable
abstract class AuthEvent extends Equatable {
  const AuthEvent();

  @override
  List<Object> get props => [];
}

class LoginEvent extends AuthEvent {
  const LoginEvent();
}

//get role success
class LoginSuccessEvent extends AuthEvent {
  const LoginSuccessEvent();
}

//get role failure
class LoginFailureEvent extends AuthEvent {
  final String message;

  const LoginFailureEvent({required this.message});

  @override
  List<Object> get props => [message];
}

class LogoutEvent extends AuthEvent {
  const LogoutEvent();
}
