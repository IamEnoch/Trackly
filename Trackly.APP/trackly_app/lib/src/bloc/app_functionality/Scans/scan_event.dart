import 'package:equatable/equatable.dart';
import 'package:flutter/material.dart';

@immutable
abstract class ScanEvent extends Equatable {
  const ScanEvent();

  @override
  List<Object> get props => [];
}

//To can scan state event
class CanScanEvent extends ScanEvent {}

//To cannot scan state event
class CannotScanEvent extends ScanEvent {}
