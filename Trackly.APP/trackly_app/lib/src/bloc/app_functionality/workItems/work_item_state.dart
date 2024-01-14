import 'package:equatable/equatable.dart';

class WorkItemState extends Equatable {
  const WorkItemState();

  @override
  List<Object> get props => [];
}

class WorkItemInitial extends WorkItemState {}

class WorkItemLoading extends WorkItemState {}

class WorkItemCreated extends WorkItemState {}

class WorkItemFailure extends WorkItemState {
  final String message;

  const WorkItemFailure({required this.message});

  @override
  List<Object> get props => [message];
}
