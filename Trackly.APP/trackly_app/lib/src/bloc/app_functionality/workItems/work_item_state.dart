import 'package:equatable/equatable.dart';

class WorkItemState extends Equatable {
  const WorkItemState();

  @override
  List<Object> get props => [];
}

//WorkItem states
class WorkItemInitial extends WorkItemState {}

class WorkItemLoading extends WorkItemState {}

class WorkItemCreated extends WorkItemState {}

class WorkItemStatusUpdateLoading extends WorkItemState {}

class WorkItemStatusUpdateSucess extends WorkItemState {}

class WorkItemStatusUpdateFailure extends WorkItemState {
  final String message;

  const WorkItemStatusUpdateFailure({required this.message});

  @override
  List<Object> get props => [message];
}

class WorkItemFailure extends WorkItemState {
  final String message;

  const WorkItemFailure({required this.message});

  @override
  List<Object> get props => [message];
}

//WorkItems states
class WorkItemsLoading extends WorkItemState {}

class WorkItemsEmpty extends WorkItemState {}

class WorkItemsSuccess extends WorkItemState {}

class WorkItemsFailure extends WorkItemState {
  final String message;

  const WorkItemsFailure({required this.message});

  @override
  List<Object> get props => [message];
}
