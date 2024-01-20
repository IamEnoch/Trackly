import 'package:equatable/equatable.dart';
import 'package:flutter/material.dart';

@immutable
abstract class RoleEvent extends Equatable {
  const RoleEvent();

  @override
  List<Object> get props => [];
}

class AddRoleEvent extends RoleEvent {}

class RemoveRoleEvent extends RoleEvent {}
