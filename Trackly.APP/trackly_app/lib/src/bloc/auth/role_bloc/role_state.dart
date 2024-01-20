import 'package:equatable/equatable.dart';
import 'package:flutter/material.dart';

@immutable
abstract class RoleState extends Equatable {
  const RoleState();

  @override
  List<Object> get props => [];
}

class RoleInitial extends RoleState {}

class RoleAdmin extends RoleState {}

class RoleTechnician extends RoleState {}
