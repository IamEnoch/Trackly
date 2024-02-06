import 'package:flutter/material.dart';
import 'package:trackly_app/src/utils/app_resources.dart';

class TextFieldStyles {
  InputDecoration inputDecoration({String labelText = 'default'}) {
    return InputDecoration(
      border: OutlineInputBorder(
        borderRadius: BorderRadius.circular(15),
      ),
      labelText: labelText,
      labelStyle: AppResources().appStyles.textStyles.bodyTextInput,
    );
  }

  //Style of the input field
}
