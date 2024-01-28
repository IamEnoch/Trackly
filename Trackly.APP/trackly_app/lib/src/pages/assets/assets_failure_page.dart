import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:trackly_app/src/bloc/app_functionality/Scans/scan_bloc.dart';
import 'package:trackly_app/src/bloc/app_functionality/Scans/scan_event.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_cubit.dart';
import 'package:trackly_app/src/utils/all_constants_imports.dart';
import 'package:trackly_app/src/utils/app_resources.dart';

class AssetsFailurePage extends StatelessWidget {
  const AssetsFailurePage({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: const Color(0xffF5F7FA),
      body: SafeArea(
        child: Padding(
          padding: EdgeInsets.only(
              left: MediaQuery.of(context).size.width * 0.059,
              right: MediaQuery.of(context).size.width * 0.059),
          child: SingleChildScrollView(
            child:
                Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
              SizedBox(
                height: MediaQuery.of(context).size.height * 0.0409,
              ),
              SizedBox(
                width: 35,
                height: 35,
                child: IconButton(
                    onPressed: () {
                      ScanBloc().add(CanScanEvent());
                      AssetCubit().toAssetInitial();
                      Navigator.of(context).pop();
                    },
                    icon: const Icon(Icons.arrow_back_sharp)),
              ),
              SizedBox(
                height: MediaQuery.of(context).size.height * 0.0309,
              ),
              SizedBox(
                //width: MediaQuery.of(context).size.width * 0.877,
                child: Card(
                  color: const Color(0xffFFFFFF),
                  elevation: 3,
                  shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(24)),
                  child: Container(
                    padding: EdgeInsets.only(
                      top: MediaQuery.of(context).size.height * 0.028,
                      bottom: MediaQuery.of(context).size.height * 0.028,
                      left: MediaQuery.of(context).size.width * 0.0610,
                      right: MediaQuery.of(context).size.width * 0.0610,
                    ),
                    child: Column(
                      children: [
                        Image.asset(
                          AppAssets.failureIcon,
                          width: 56,
                          height: 56,
                        ),
                        SizedBox(
                          height: MediaQuery.of(context).size.height * 0.018,
                        ),
                        Text(
                          'Asset Not Found',
                          style:
                              AppResources().appStyles.textStyles.bodyDefault,
                        ),
                        SizedBox(
                          height: MediaQuery.of(context).size.height * 0.009,
                        ),
                        Text(
                          '-',
                          style: AppResources().appStyles.textStyles.headineH4,
                        ),
                        SizedBox(
                          height: MediaQuery.of(context).size.height * 0.037,
                        ),
                        Container(
                          color: const Color(0xffEDEDED),
                          height: 0.5,
                          width: MediaQuery.of(context).size.width,
                        ),
                        SizedBox(
                          height: MediaQuery.of(context).size.height * 0.037,
                        ),
                        Row(
                          mainAxisAlignment: MainAxisAlignment.spaceBetween,
                          children: [
                            Flexible(
                              flex: 2,
                              child: Text(
                                'Asset Name',
                                textAlign: TextAlign.start,
                                style: TextStyle(
                                  fontFamily: GoogleFonts.poppins().fontFamily,
                                  fontWeight: FontWeight.w400,
                                  fontSize: 13,
                                  color: const Color(0xff707070),
                                ),
                                maxLines: 1,
                                overflow: TextOverflow.ellipsis,
                              ),
                            ),
                            const SizedBox(
                              width: 10,
                            ),
                            Flexible(
                              flex: 3,
                              child: Text(
                                '-',
                                textAlign: TextAlign.end,
                                style: AppResources()
                                    .appStyles
                                    .textStyles
                                    .bodyInterlined,
                                maxLines: 1,
                                overflow: TextOverflow.ellipsis,
                              ),
                            ),
                          ],
                        ),
                        SizedBox(
                          height: MediaQuery.of(context).size.height * 0.005,
                        ),
                        Row(
                          mainAxisAlignment: MainAxisAlignment.spaceBetween,
                          children: [
                            Text(
                              'Barcode Number',
                              textAlign: TextAlign.start,
                              style: TextStyle(
                                fontFamily: GoogleFonts.poppins().fontFamily,
                                fontWeight: FontWeight.w400,
                                fontSize: 13,
                                color: const Color(0xff707070),
                              ),
                            ),
                            Text(
                              '-',
                              textAlign: TextAlign.end,
                              style: TextStyle(
                                fontFamily: GoogleFonts.poppins().fontFamily,
                                fontWeight: FontWeight.w600,
                                fontSize: 14,
                                color: const Color(0xff121212),
                              ),
                            ),
                          ],
                        ),
                        SizedBox(
                          height: MediaQuery.of(context).size.height * 0.005,
                        ),
                        Container(
                          color: const Color(0xffEDEDED),
                          height: 0.5,
                          width: MediaQuery.of(context).size.width,
                        ),
                        SizedBox(
                          height: MediaQuery.of(context).size.height * 0.005,
                        ),
                        Row(
                          mainAxisAlignment: MainAxisAlignment.spaceBetween,
                          children: [
                            Flexible(
                              flex: 2,
                              child: Text(
                                'Category',
                                textAlign: TextAlign.start,
                                style: TextStyle(
                                  fontFamily: GoogleFonts.poppins().fontFamily,
                                  fontWeight: FontWeight.w400,
                                  fontSize: 13,
                                  color: const Color(0xff707070),
                                ),
                                maxLines: 1,
                                overflow: TextOverflow.ellipsis,
                              ),
                            ),
                            Flexible(
                              flex: 3,
                              child: Text(
                                '-',
                                textAlign: TextAlign.end,
                                style: TextStyle(
                                  fontFamily: GoogleFonts.poppins().fontFamily,
                                  fontWeight: FontWeight.w600,
                                  fontSize: 14,
                                  color: const Color(0xff121212),
                                ),
                                maxLines: 1,
                                overflow: TextOverflow.ellipsis,
                              ),
                            ),
                          ],
                        ),
                        SizedBox(
                          height: MediaQuery.of(context).size.height * 0.005,
                        ),
                        Row(
                          mainAxisAlignment: MainAxisAlignment.spaceBetween,
                          children: [
                            Text(
                              'Department',
                              textAlign: TextAlign.start,
                              style: TextStyle(
                                fontFamily: GoogleFonts.poppins().fontFamily,
                                fontWeight: FontWeight.w400,
                                fontSize: 13,
                                color: const Color(0xff707070),
                              ),
                            ),
                            Text(
                              '-',
                              textAlign: TextAlign.end,
                              style: TextStyle(
                                fontFamily: GoogleFonts.poppins().fontFamily,
                                fontWeight: FontWeight.w600,
                                fontSize: 14,
                                color: const Color(0xff121212),
                              ),
                            ),
                          ],
                        ),
                        SizedBox(
                          height: MediaQuery.of(context).size.height * 0.005,
                        ),
                        Row(
                          mainAxisAlignment: MainAxisAlignment.spaceBetween,
                          children: [
                            Text(
                              'Location',
                              textAlign: TextAlign.start,
                              style: TextStyle(
                                fontFamily: GoogleFonts.poppins().fontFamily,
                                fontWeight: FontWeight.w400,
                                fontSize: 13,
                                color: const Color(0xff707070),
                              ),
                            ),
                            Text(
                              '-',
                              textAlign: TextAlign.end,
                              style: TextStyle(
                                fontFamily: GoogleFonts.poppins().fontFamily,
                                fontWeight: FontWeight.w600,
                                fontSize: 14,
                                color: const Color(0xff121212),
                              ),
                            ),
                          ],
                        ),
                        SizedBox(
                          height: MediaQuery.of(context).size.height * 0.0187,
                        ),
                        Container(
                          color: const Color(0xffEDEDED),
                          height: 0.5,
                          width: MediaQuery.of(context).size.width,
                        ),
                        SizedBox(
                          height: MediaQuery.of(context).size.height * 0.0187,
                        ),
                      ],
                    ),
                  ),
                ),
              ),
              // SizedBox(
              //   height: MediaQuery.of(context).size.height * 0.0387,
              // ),
              // Center(
              //   child: DecoratedBox(
              //     decoration: const BoxDecoration(
              //       color: Color(0xffDEDEDE),
              //       borderRadius: BorderRadius.all(Radius.circular(23)),
              //     ),
              //     child: Container(
              //       margin: const EdgeInsets.all(0.05),
              //       width: MediaQuery.of(context).size.width,
              //       child: TextButton.icon(
              //         style: AppResources()
              //             .buttonStyles
              //             .buttonStyle(backgroundColor: Color(0xffDEDEDE)),
              //         onPressed: () async {
              //           showModalBottomSheet(
              //             context: context,
              //             builder: (context) {
              //               return SingleChildScrollView(
              //                 child: SizedBox(
              //                   child: Padding(
              //                     padding: const EdgeInsets.all(50.0),
              //                     child: Center(
              //                       child: Column(
              //                         mainAxisAlignment:
              //                             MainAxisAlignment.end,
              //                         mainAxisSize: MainAxisSize.min,
              //                         children: <Widget>[
              //                           Text(arguments['assetName']),
              //                         ],
              //                       ),
              //                     ),
              //                   ),
              //                 ),
              //               );
              //             },
              //           );
              //         },
              //         icon: const Icon(
              //           Icons.copy,
              //           color: Color(0xff3D3D3D),
              //         ),
              //         label: const Text(
              //           'Inflate more details',
              //           style: TextStyle(color: Color(0xff3D3D3D)),
              //         ),
              //       ),
              //     ),
              //   ),
              // ),
              SizedBox(
                height: MediaQuery.of(context).size.height * 0.0187,
              ),
            ]),
          ),
        ),
      ),
    );
  }
}
