class ApiResponse<T> {
  final T? response;
  final bool error;
  final String errorMessage;

  ApiResponse({
    required this.response,
    this.error = false,
    required this.errorMessage,
  });
}
