import 'package:flutter/material.dart';
import 'package:trackly_app/src/utils/app_resources.dart';

class ButtonStyles {
  ButtonStyle buttonStyle({
    required Color backgroundColor,
  }) {
    return OutlinedButton.styleFrom(
      minimumSize: const Size(70, 55),
      shape: const RoundedRectangleBorder(
        borderRadius: BorderRadius.all(
          Radius.circular(10.0),
        ),
      ),
      backgroundColor: backgroundColor,
      textStyle:
          AppResources().appStyles.textStyles.componentsButtonDefault.copyWith(
                color: Colors.white,
              ),
    );
  }
}
