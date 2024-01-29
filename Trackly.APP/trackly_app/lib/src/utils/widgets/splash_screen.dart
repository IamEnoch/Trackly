import 'package:flutter/material.dart';
import 'package:lottie/lottie.dart';
import 'package:trackly_app/src/utils/all_constants_imports.dart';

class SplashScreen extends StatefulWidget {
  const SplashScreen({super.key});

  @override
  State<SplashScreen> createState() => _SplashScreenState();
}

class _SplashScreenState extends State<SplashScreen> {
  @override
  Widget build(BuildContext context) {
    return Lottie.asset(
      AppAssets.loadingAnimation,
      repeat: true,
      animate: true,
    );
  }
}
