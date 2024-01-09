import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';

class TextStyles {
  //Take color as external input
  TextStyle headineH1 = TextStyle(
    fontFamily: GoogleFonts.poppins().fontFamily,
    fontSize: 39,
    fontWeight: FontWeight.w700,
  );
  TextStyle headineH2 = TextStyle(
    fontFamily: GoogleFonts.poppins().fontFamily,
    fontSize: 31,
    fontWeight: FontWeight.w700,
  );
  TextStyle headineH3 = TextStyle(
    fontFamily: GoogleFonts.poppins().fontFamily,
    fontSize: 27,
    fontWeight: FontWeight.w600,
  );
  TextStyle headineH4 = TextStyle(
    fontFamily: GoogleFonts.poppins().fontFamily,
    fontSize: 23,
    fontWeight: FontWeight.w600,
  );
  TextStyle headineH5 = TextStyle(
    fontFamily: GoogleFonts.poppins().fontFamily,
    fontSize: 19,
    fontWeight: FontWeight.w700,
  );
  TextStyle headineH6 = TextStyle(
    fontFamily: GoogleFonts.poppins().fontFamily,
    fontSize: 17,
    fontWeight: FontWeight.w600,
  );

//body text styles
  TextStyle bodyDefault = TextStyle(
    fontFamily: GoogleFonts.poppins().fontFamily,
    fontSize: 13,
    fontWeight: FontWeight.w400,
  );
  TextStyle bodyDefaultBold = TextStyle(
    fontFamily: GoogleFonts.poppins().fontFamily,
    fontSize: 13,
    fontWeight: FontWeight.w600,
  );
  TextStyle bodyItalic = TextStyle(
    fontFamily: GoogleFonts.poppins().fontFamily,
    fontSize: 13,
    fontWeight: FontWeight.w400,
    fontStyle: FontStyle.italic,
  );
  TextStyle bodyInterlined = TextStyle(
    fontFamily: GoogleFonts.poppins().fontFamily,
    fontSize: 15,
    fontWeight: FontWeight.w400,
  );
  TextStyle bodySmall = TextStyle(
    fontFamily: GoogleFonts.poppins().fontFamily,
    fontSize: 11,
    fontWeight: FontWeight.w400,
  );
  TextStyle bodyTextInput = TextStyle(
    fontFamily: GoogleFonts.poppins().fontFamily,
    fontSize: 13,
    fontWeight: FontWeight.w400,
  );

//componenents text styles
  TextStyle componentsButtonDefault = TextStyle(
    fontFamily: GoogleFonts.poppins().fontFamily,
    fontSize: 12,
    fontWeight: FontWeight.w500,
    color: Colors.white,
  );

  TextStyle componentsButtonBold = TextStyle(
    fontFamily: GoogleFonts.poppins().fontFamily,
    fontSize: 15,
    fontWeight: FontWeight.w700,
  );
  TextStyle componentsFilter = TextStyle(
    fontFamily: GoogleFonts.poppins().fontFamily,
    fontSize: 11.5,
    fontWeight: FontWeight.w400,
  );
}
