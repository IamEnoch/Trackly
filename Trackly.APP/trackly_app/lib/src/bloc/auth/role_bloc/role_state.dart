import 'package:equatable/equatable.dart';
import 'package:flutter/material.dart';

@immutable
abstract class RoleState extends Equatable {
  const RoleState();

  @override
  List<Object> get props => [];
}

class RoleInitial extends RoleState {}

class AddingRoleLoading extends RoleState {}

class RemovingRoleLoading extends RoleState {}

class CheckingRoleLoading extends RoleState {}

class RoleAdmin extends RoleState {}

class RoleTechnician extends RoleState {}

class RoleFailure extends RoleState {
  final String message;

  const RoleFailure({required this.message});

  @override
  List<Object> get props => [message];
}
