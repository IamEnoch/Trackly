import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';

class TextStyles {
  //Take color as external input
  TextStyle headineH1 = GoogleFonts.poppins(
    fontSize: 39,
    fontWeight: FontWeight.w700,
  );
  TextStyle headineH2 = GoogleFonts.poppins(
    fontSize: 31,
    fontWeight: FontWeight.w700,
  );
  TextStyle headineH3 = GoogleFonts.poppins(
    fontSize: 27,
    fontWeight: FontWeight.w600,
  );
  TextStyle headineH4 = GoogleFonts.poppins(
    fontSize: 23,
    fontWeight: FontWeight.w600,
  );
  TextStyle headineH5 = GoogleFonts.poppins(
    fontSize: 19,
    fontWeight: FontWeight.w700,
  );
  TextStyle headineH6 = GoogleFonts.poppins(
    fontSize: 17,
    fontWeight: FontWeight.w600,
  );

//body text styles
  TextStyle bodyDefault = GoogleFonts.poppins(
    fontSize: 14,
    fontWeight: FontWeight.w400,
  );
  TextStyle bodyDefaultBold = GoogleFonts.poppins(
    fontSize: 15,
    fontWeight: FontWeight.w700,
  );
  TextStyle bodyItalic = GoogleFonts.poppins(
    fontSize: 15,
    fontWeight: FontWeight.w400,
    fontStyle: FontStyle.italic,
  );
  TextStyle bodyInterlined = GoogleFonts.poppins(
    fontSize: 15,
    fontWeight: FontWeight.w400,
  );
  TextStyle bodySmall = GoogleFonts.poppins(
    fontSize: 11,
    fontWeight: FontWeight.w400,
  );
  TextStyle bodyTextInput = GoogleFonts.poppins(
    fontSize: 13,
    fontWeight: FontWeight.w400,
  );

//componenents text styles
  TextStyle componentsButtonDefault = GoogleFonts.poppins(
    fontSize: 12,
    fontWeight: FontWeight.w500,
    color: Colors.white,
  );

  TextStyle componentsButtonBold = GoogleFonts.poppins(
    fontSize: 15,
    fontWeight: FontWeight.w700,
  );
  TextStyle componentsFilter = GoogleFonts.poppins(
    fontSize: 11.5,
    fontWeight: FontWeight.w400,
  );
}
