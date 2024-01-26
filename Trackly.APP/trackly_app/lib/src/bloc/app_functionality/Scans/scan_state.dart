import 'package:equatable/equatable.dart';
import 'package:flutter/material.dart';

@immutable
abstract class ScanState extends Equatable {
  const ScanState();

  @override
  List<Object> get props => [];
}

//Initial state
class ScanInitial extends ScanState {}

//Can scan state
class CanScanState extends ScanState {}

//Cannot scan state
class CannotScanState extends ScanState {}
