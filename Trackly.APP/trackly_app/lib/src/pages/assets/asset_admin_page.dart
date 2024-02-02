import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:intl/intl.dart';
import 'package:share_plus/share_plus.dart';
import 'package:trackly_app/src/bloc/app_functionality/Scans/scan_bloc.dart';
import 'package:trackly_app/src/bloc/app_functionality/Scans/scan_event.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/users/users_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/users/users_state.dart';
import 'package:trackly_app/src/data/enumhelper/enums.dart';
import 'package:trackly_app/src/data/models/Assets/asset.dart';
import 'package:trackly_app/src/utils/all_constants_imports.dart';
import 'package:trackly_app/src/utils/app_colors.dart';
import 'package:trackly_app/src/utils/app_resources.dart';

class AssetAdminPage extends StatelessWidget {
  AssetAdminPage({super.key});

  String subject = 'This is a subject I want to add';

  void _onShare(BuildContext context, String assetDetails) async {
    await Share.share(
      assetDetails,
      subject: subject,
      //sharePositionOrigin: box!.localToGlobal(Offset.zero) & box.size
    );
  }

  @override
  Widget build(BuildContext context) {
    final arguments =
        ModalRoute.of(context)?.settings.arguments as Map<String, dynamic>;
    final asset = arguments['asset'] as Asset;
    String username;
    return BlocBuilder<UsersCubit, UsersState>(
      builder: (context, state) {
        if (state is UserLoading) {
          return const Scaffold(
              body: Center(child: CircularProgressIndicator()));
        } else if (state is UserFailure) {
          return Scaffold(
            body: Center(
              child: Text(state.message),
            ),
          );
        } else if (state is UsersInitial) {
          UsersCubit().fetchUser(asset.assignedTo);
          return const Scaffold(
              body: Center(child: CircularProgressIndicator()));
        } else {
          username = (state as UserFetched).user.username;
          return Scaffold(
            backgroundColor: const Color(0xffF5F7FA),
            body: SafeArea(
              child: Padding(
                padding: EdgeInsets.only(
                    left: MediaQuery.of(context).size.width * 0.059,
                    right: MediaQuery.of(context).size.width * 0.059),
                child: SingleChildScrollView(
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
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
                              bottom:
                                  MediaQuery.of(context).size.height * 0.028,
                              left: MediaQuery.of(context).size.width * 0.0610,
                              right: MediaQuery.of(context).size.width * 0.0610,
                            ),
                            child: Column(
                              children: [
                                Text(
                                  'Asset Name',
                                  style: AppResources()
                                      .appStyles
                                      .textStyles
                                      .bodyDefault,
                                ),
                                SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.009,
                                ),
                                Text(
                                  asset.assetName,
                                  style: AppResources()
                                      .appStyles
                                      .textStyles
                                      .headineH4,
                                ),
                                SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.037,
                                ),
                                Container(
                                  color: const Color(0xffEDEDED),
                                  height: 0.5,
                                  width: MediaQuery.of(context).size.width,
                                ),
                                SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.037,
                                ),
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Flexible(
                                      flex: 2,
                                      child: Text(
                                        'Asset Name',
                                        textAlign: TextAlign.start,
                                        style: AppResources()
                                            .appStyles
                                            .textStyles
                                            .bodySmall,
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
                                        arguments['assetName'],
                                        textAlign: TextAlign.end,
                                        style: AppResources()
                                            .appStyles
                                            .textStyles
                                            .bodyDefaultBold,
                                        maxLines: 1,
                                        overflow: TextOverflow.ellipsis,
                                      ),
                                    ),
                                  ],
                                ),
                                SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.005,
                                ),
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Text(
                                      'Barcode Number',
                                      textAlign: TextAlign.start,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodySmall,
                                    ),
                                    Text(
                                      arguments['barcodeNumber'],
                                      textAlign: TextAlign.end,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodyDefaultBold,
                                    ),
                                  ],
                                ),

                                SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.005,
                                ),
                                //Serial Number
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Text(
                                      'Serial Number',
                                      textAlign: TextAlign.start,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodySmall,
                                    ),
                                    Text(
                                      asset.serialNumber.toString(),
                                      textAlign: TextAlign.end,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodyDefaultBold,
                                    ),
                                  ],
                                ),
                                SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.005,
                                ),
                                //Assigned To
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Text(
                                      'Assigned To',
                                      textAlign: TextAlign.start,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodySmall,
                                    ),
                                    Text(
                                      username,
                                      textAlign: TextAlign.end,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodyDefaultBold,
                                    ),
                                  ],
                                ),
                                SizedBox(
                                  height:
                                      MediaQuery.of(context).size.height * 0.02,
                                ),
                                Container(
                                  color: const Color(0xffEDEDED),
                                  height: 0.5,
                                  width: MediaQuery.of(context).size.width,
                                ),
                                SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.005,
                                ),
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Flexible(
                                      flex: 2,
                                      child: Text(
                                        'Category',
                                        textAlign: TextAlign.start,
                                        style: AppResources()
                                            .appStyles
                                            .textStyles
                                            .bodySmall,
                                        maxLines: 1,
                                        overflow: TextOverflow.ellipsis,
                                      ),
                                    ),
                                    Flexible(
                                      flex: 3,
                                      child: Text(
                                        assetCategoryValues
                                            .reverse[arguments['assetCategory']]
                                            .toString(),
                                        textAlign: TextAlign.end,
                                        style: AppResources()
                                            .appStyles
                                            .textStyles
                                            .bodyDefaultBold,
                                        maxLines: 1,
                                        overflow: TextOverflow.ellipsis,
                                      ),
                                    ),
                                  ],
                                ),
                                SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.005,
                                ),
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Text(
                                      'Department',
                                      textAlign: TextAlign.start,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodySmall,
                                    ),
                                    Text(
                                      departmentNameValues
                                          .reverse[arguments['assetDepartment']]
                                          .toString(),
                                      textAlign: TextAlign.end,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodyDefaultBold,
                                    ),
                                  ],
                                ),
                                SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.005,
                                ),
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Text(
                                      'Location',
                                      textAlign: TextAlign.start,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodySmall,
                                    ),
                                    Text(
                                      locationNameValues
                                          .reverse[arguments['assetLocation']]
                                          .toString(),
                                      textAlign: TextAlign.end,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodyDefaultBold,
                                    ),
                                  ],
                                ),
                                SizedBox(
                                  height:
                                      MediaQuery.of(context).size.height * 0.02,
                                ),
                                //End of cost
                                //Storage
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Text(
                                      'Storage',
                                      textAlign: TextAlign.start,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodySmall,
                                    ),
                                    Text(
                                      asset.storage.toString(),
                                      textAlign: TextAlign.end,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodyDefaultBold,
                                    ),
                                  ],
                                ),
                                SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.005,
                                ),
                                //End of storage
                                //Processor
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Text(
                                      'Processor',
                                      textAlign: TextAlign.start,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodySmall,
                                    ),
                                    Text(
                                      asset.processor.toString(),
                                      textAlign: TextAlign.end,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodyDefaultBold,
                                    ),
                                  ],
                                ),
                                SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.005,
                                ),
                                //End of processor
                                //Ram
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Text(
                                      'Ram',
                                      textAlign: TextAlign.start,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodySmall,
                                    ),
                                    Text(
                                      asset.ram.toString(),
                                      textAlign: TextAlign.end,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodyDefaultBold,
                                    ),
                                  ],
                                ),
                                SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.005,
                                ),
                                //Cost
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Text(
                                      'Purchase Cost',
                                      textAlign: TextAlign.start,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodySmall,
                                    ),
                                    Text(
                                      asset.purchaseCost.toString(),
                                      textAlign: TextAlign.end,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodyDefaultBold,
                                    ),
                                  ],
                                ),

                                //End of assigned to
                                //Condition
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Text(
                                      'Condition',
                                      textAlign: TextAlign.start,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodySmall,
                                    ),
                                    Text(
                                      conditionValues.reverse[
                                                  arguments['condition']] ==
                                              null
                                          ? '-'
                                          : conditionValues
                                              .reverse[arguments['condition']]
                                              .toString(),
                                      textAlign: TextAlign.end,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodyDefaultBold,
                                    ),
                                  ],
                                ),
                                SizedBox(
                                  height:
                                      MediaQuery.of(context).size.height * 0.02,
                                ),
                                //End of ram
                                //The other desired items to be displayed
                                //are to be added here
                                //Dates
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Text(
                                      'Purchase Date',
                                      textAlign: TextAlign.start,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodySmall,
                                    ),
                                    Text(
                                      //Parse the date to a readable format
                                      DateFormat('dd-MM-yyyy HH:mm:ss')
                                          .format(asset.purchaseDate),
                                      textAlign: TextAlign.end,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodyDefaultBold,
                                    ),
                                  ],
                                ),
                                SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.005,
                                ),
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Text(
                                      'Created At',
                                      textAlign: TextAlign.start,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodySmall,
                                    ),
                                    Text(
                                      DateFormat('dd-MM-yyyy HH:mm:ss')
                                          .format(asset.createdAt),
                                      textAlign: TextAlign.end,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodyDefaultBold,
                                    ),
                                  ],
                                ),
                                SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.005,
                                ),
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Text(
                                      'Updated At',
                                      textAlign: TextAlign.start,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodySmall,
                                    ),
                                    Text(
                                      asset.updatedAt == null
                                          ? '-'
                                          : DateFormat('dd-MM-yyyy HH:mm:ss')
                                              .format(asset.updatedAt!),
                                      textAlign: TextAlign.end,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodyDefaultBold,
                                    ),
                                  ],
                                ),
                                SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.005,
                                ),
                                Row(
                                  mainAxisAlignment:
                                      MainAxisAlignment.spaceBetween,
                                  children: [
                                    Text(
                                      'Deleted At',
                                      textAlign: TextAlign.start,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodySmall,
                                    ),
                                    Text(
                                      asset.deletedAt == null
                                          ? '-'
                                          : DateFormat('dd-MM-yyyy HH:mm:ss')
                                              .format(asset.deletedAt!),
                                      textAlign: TextAlign.end,
                                      style: AppResources()
                                          .appStyles
                                          .textStyles
                                          .bodyDefaultBold,
                                    ),
                                  ],
                                ),
                                SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.005,
                                ),
                                //End of dates

                                Container(
                                  color: const Color(0xffEDEDED),
                                  height: 0.5,
                                  width: MediaQuery.of(context).size.width,
                                ),
                                SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.0187,
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
                      Center(
                        child: DecoratedBox(
                          decoration: const BoxDecoration(
                            color: Color(0xffDEDEDE),
                            borderRadius: BorderRadius.all(
                              Radius.circular(23),
                            ),
                          ),
                          child: Container(
                            margin: const EdgeInsets.all(0.05),
                            height: MediaQuery.of(context).size.height * 0.06,
                            width: MediaQuery.of(context).size.width,
                            child: OutlinedButton(
                              onPressed: () async {
                                Navigator.pushNamed(
                                  context,
                                  editAssetPageRoute,
                                  //send the asset as an argument
                                  arguments: {
                                    'assetName': arguments['assetName'],
                                    'assetCategory': arguments['assetCategory'],
                                    'assetDepartment':
                                        arguments['assetDepartment'],
                                    'assetLocation': arguments['assetLocation'],
                                    'barcodeNumber': arguments['barcodeNumber'],
                                    'asset': arguments['asset'] as Asset,
                                  },
                                );
                              },
                              style: AppResources().buttonStyles.buttonStyle(
                                    backgroundColor: AppColors.pinkColor,
                                  ),
                              child: Text(
                                "EDIT ASSET",
                                style: AppResources()
                                    .appStyles
                                    .textStyles
                                    .bodyDefaultBold
                                    .copyWith(
                                      color: Colors.white,
                                    ),
                              ),
                            ),
                          ),
                        ),
                      ),

                      SizedBox(
                        height: MediaQuery.of(context).size.height * 0.0187,
                      ),
                      Center(
                        child: DecoratedBox(
                          decoration: const BoxDecoration(
                            color: Color(0xffDEDEDE),
                            borderRadius: BorderRadius.all(Radius.circular(23)),
                          ),
                          child: Container(
                            margin: const EdgeInsets.all(0.05),
                            width: MediaQuery.of(context).size.width,
                            child: TextButton.icon(
                              style: AppResources().buttonStyles.buttonStyle(
                                  backgroundColor: Color(0xffDEDEDE)),
                              onPressed: () async {
                                // Add your button action here
                                String assetDetails =
                                    'Asset name: ${arguments['assetName']}\nAsset tag: ${arguments['assetName']}\nSerial number: ${arguments['assetName']}\nCondition: ${arguments['assetName']}\nRam: ${arguments['assetName']}\n';
                                _onShare(context, assetDetails);
                              },
                              icon: const Icon(
                                Icons.share,
                                color: Color(0xff3D3D3D),
                              ),
                              label: const Text(
                                'Share Asset Details',
                                style: TextStyle(color: Color(0xff3D3D3D)),
                              ),
                            ),
                          ),
                        ),
                      ),
                      SizedBox(
                        height: MediaQuery.of(context).size.height * 0.0187,
                      ),
                      Center(
                        child: DecoratedBox(
                          decoration: const BoxDecoration(
                            color: Color(0xffDEDEDE),
                            borderRadius: BorderRadius.all(Radius.circular(23)),
                          ),
                          child: Container(
                            width: MediaQuery.of(context).size.width,
                            margin: const EdgeInsets.all(0.05),
                            child: TextButton.icon(
                              style: AppResources().buttonStyles.buttonStyle(
                                  backgroundColor: Color(0xffDEDEDE)),
                              onPressed: () async {
                                // Add your button action here
                                Navigator.of(context).pushNamed(
                                  assetDetailsPageRoute,
                                  arguments: {
                                    'tickets': arguments['tickets'],
                                    'assetName': arguments['assetName'],
                                    'department': arguments['assetDepartment'],
                                  },
                                );
                              },
                              icon: const Icon(
                                Icons.notes_outlined,
                                color: Color(0xff3D3D3D),
                              ),
                              label: const Text(
                                'Asset Details',
                                style: TextStyle(color: Color(0xff3D3D3D)),
                              ),
                            ),
                          ),
                        ),
                      ),
                      SizedBox(
                        height: MediaQuery.of(context).size.height * 0.0587,
                      ),
                    ],
                  ),
                ),
              ),
            ),
          );
        }
      },
    );
  }
}
