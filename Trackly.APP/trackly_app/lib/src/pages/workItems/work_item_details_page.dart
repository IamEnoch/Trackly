import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:intl/intl.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/workItems/work_item_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/workItems/work_item_state.dart';
import 'package:trackly_app/src/data/enumhelper/enums.dart';
import 'package:trackly_app/src/data/models/WorkItems/work_item.dart';
import 'package:trackly_app/src/data/models/WorkItems/work_item_status_update.dart';
import 'package:trackly_app/src/utils/app_colors.dart';
import 'package:trackly_app/src/utils/app_resources.dart';
import 'package:trackly_app/src/utils/widgets/status_card.dart';

import 'package:fluttertoast/fluttertoast.dart';

class WorkItemDetailsPage extends StatefulWidget {
  const WorkItemDetailsPage({super.key});
  //custom logger

  @override
  State<WorkItemDetailsPage> createState() => _WorkItemDetailsPageState();
}

class _WorkItemDetailsPageState extends State<WorkItemDetailsPage> {
  final log = logger(WorkItemDetailsPage);
  @override
  Widget build(BuildContext context) {
    final workItem = ModalRoute.of(context)?.settings.arguments as WorkItem;
    return BlocListener<WorkItemCubit, WorkItemState>(
      bloc: BlocProvider.of<WorkItemCubit>(context),
      listener: (context, state) {
        // TODO: implement listener
        if (state is WorkItemStatusUpdateLoading) {
          log.e('Status update in progress...');
          //Show toast notification
          Fluttertoast.showToast(
            msg: "Status update in progress...",
            toastLength: Toast
                .LENGTH_SHORT, // Duration for which the toast will be shown
            gravity: ToastGravity.BOTTOM, // Position of the toast on the screen

            backgroundColor: Color.fromARGB(
                255, 221, 53, 53), // Background color of the toast
            textColor: Colors.white, // Text color of the toast
            fontSize: 16.0, // Font size of the toast message
          );
        } else if (state is WorkItemStatusUpdateSucess) {
          //Show toast notification
          Fluttertoast.showToast(
            msg: "Status updated successfully",
            toastLength:
                Toast.LENGTH_LONG, // Duration for which the toast will be shown
            gravity: ToastGravity.BOTTOM, // Position of the toast on the screen

            backgroundColor: Colors.green, // Background color of the toast
            textColor: Colors.white, // Text color of the toast
            fontSize: 16.0, // Font size of the toast message
          );

          //Pop the page
          Navigator.of(context).pop();
        } else if (state is WorkItemStatusUpdateFailure) {
          //Show toast notification
          Fluttertoast.showToast(
            msg: "Status update failed",
            toastLength:
                Toast.LENGTH_LONG, // Duration for which the toast will be shown
            gravity: ToastGravity.BOTTOM, // Position of the toast on the screen

            backgroundColor: Colors.red, // Background color of the toast
            textColor: Colors.white, // Text color of the toast
            fontSize: 16.0, // Font size of the toast message
          );
        }
      },
      child: Scaffold(
        backgroundColor: const Color(0xffF5F7FA),
        body: SafeArea(
          child: Padding(
            padding: EdgeInsets.only(
                left: MediaQuery.of(context).size.width * 0.059),
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
                        //Work item cubit set intial state
                        BlocProvider.of<WorkItemCubit>(context)
                            .setInitialState();
                        Navigator.of(context).pop();
                      },
                      icon: const Icon(
                        Icons.arrow_back_sharp,
                      ),
                    ),
                  ),
                  SizedBox(
                    height: MediaQuery.of(context).size.height * 0.0309,
                  ),
                  SizedBox(
                    width: MediaQuery.of(context).size.width * 0.877,
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
                            // SizedBox(
                            //   height: MediaQuery.of(context).size.height * 0.018,
                            // ),
                            Text(
                              'Work Item Name',
                              style: TextStyle(
                                fontFamily: GoogleFonts.poppins().fontFamily,
                                fontWeight: FontWeight.w400,
                                fontSize: 16,
                                color: const Color(0xff474747),
                              ),
                            ),
                            SizedBox(
                              height:
                                  MediaQuery.of(context).size.height * 0.009,
                            ),
                            Text(
                              workItem.title,
                              style: TextStyle(
                                fontFamily: GoogleFonts.poppins().fontFamily,
                                fontWeight: FontWeight.w600,
                                fontSize: 24,
                                color: const Color(0xff121212),
                              ),
                            ),
                            SizedBox(
                              height:
                                  MediaQuery.of(context).size.height * 0.037,
                            ),
                            Container(
                              color: const Color(0xffEDEDED),
                              height: 0.5,
                              width: MediaQuery.of(context).size.width,
                            ),
                            SizedBox(
                              height:
                                  MediaQuery.of(context).size.height * 0.037,
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Text(
                                  'Description',
                                  textAlign: TextAlign.start,
                                  style: TextStyle(
                                    fontFamily:
                                        GoogleFonts.poppins().fontFamily,
                                    fontWeight: FontWeight.w400,
                                    fontSize: 13,
                                    color: const Color(0xff707070),
                                  ),
                                ),
                                const SizedBox(
                                  width: 10,
                                ),
                                Text(
                                  workItem.description,
                                  textAlign: TextAlign.end,
                                  style: AppResources()
                                      .appStyles
                                      .textStyles
                                      .bodyDefaultBold,
                                ),
                              ],
                            ),
                            SizedBox(
                              height: MediaQuery.of(context).size.height * 0.01,
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Text(
                                  'Department',
                                  textAlign: TextAlign.start,
                                  style: TextStyle(
                                    fontFamily:
                                        GoogleFonts.poppins().fontFamily,
                                    fontWeight: FontWeight.w400,
                                    fontSize: 13,
                                    color: const Color(0xff707070),
                                  ),
                                ),
                                Text(
                                  workItem.description,
                                  textAlign: TextAlign.end,
                                  style: AppResources()
                                      .appStyles
                                      .textStyles
                                      .bodyDefaultBold,
                                ),
                              ],
                            ),
                            SizedBox(
                              height: MediaQuery.of(context).size.height * 0.01,
                            ),
                            Container(
                              color: const Color(0xffEDEDED),
                              height: 0.5,
                              width: MediaQuery.of(context).size.width,
                            ),
                            SizedBox(
                              height: MediaQuery.of(context).size.height * 0.01,
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Text(
                                  'Date',
                                  textAlign: TextAlign.start,
                                  style: TextStyle(
                                    fontFamily:
                                        GoogleFonts.poppins().fontFamily,
                                    fontWeight: FontWeight.w400,
                                    fontSize: 13,
                                    color: const Color(0xff707070),
                                  ),
                                ),
                                Text(
                                  DateFormat('dd-MM-yyyy').format(
                                    workItem.createdAt,
                                  ),
                                  textAlign: TextAlign.end,
                                  style: AppResources()
                                      .appStyles
                                      .textStyles
                                      .bodyDefaultBold,
                                ),
                              ],
                            ),
                            SizedBox(
                              height: MediaQuery.of(context).size.height * 0.01,
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Text(
                                  'Time',
                                  textAlign: TextAlign.start,
                                  style: TextStyle(
                                    fontFamily:
                                        GoogleFonts.poppins().fontFamily,
                                    fontWeight: FontWeight.w400,
                                    fontSize: 13,
                                    color: const Color(0xff707070),
                                  ),
                                ),
                                Text(
                                  DateFormat('hh:mm a').format(
                                    workItem.createdAt.toLocal(),
                                  ),
                                  textAlign: TextAlign.end,
                                  style: AppResources()
                                      .appStyles
                                      .textStyles
                                      .bodyDefaultBold,
                                ),
                              ],
                            ),
                            SizedBox(
                              height: MediaQuery.of(context).size.height * 0.01,
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Text(
                                  'Assigned to',
                                  textAlign: TextAlign.start,
                                  style: TextStyle(
                                    fontFamily:
                                        GoogleFonts.poppins().fontFamily,
                                    fontWeight: FontWeight.w400,
                                    fontSize: 13,
                                    color: const Color(0xff707070),
                                  ),
                                ),
                                Text(
                                  'Assigned to',
                                  textAlign: TextAlign.end,
                                  style: AppResources()
                                      .appStyles
                                      .textStyles
                                      .bodyDefaultBold,
                                ),
                              ],
                            ),
                            SizedBox(
                              height: MediaQuery.of(context).size.height * 0.01,
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Text(
                                  'Category',
                                  textAlign: TextAlign.start,
                                  style: TextStyle(
                                    fontFamily:
                                        GoogleFonts.poppins().fontFamily,
                                    fontWeight: FontWeight.w400,
                                    fontSize: 13,
                                    color: const Color(0xff707070),
                                  ),
                                ),
                                Text(
                                  categoryValues.reverse[workItem.category]
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
                              height: MediaQuery.of(context).size.height * 0.01,
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Text(
                                  'Priority',
                                  textAlign: TextAlign.start,
                                  style: TextStyle(
                                    fontFamily:
                                        GoogleFonts.poppins().fontFamily,
                                    fontWeight: FontWeight.w400,
                                    fontSize: 13,
                                    color: const Color(0xff707070),
                                  ),
                                ),
                                Text(
                                  priorityValues.reverse[workItem.priority]
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
                              height: MediaQuery.of(context).size.height * 0.01,
                            ),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Text(
                                  'Status',
                                  textAlign: TextAlign.start,
                                  style: TextStyle(
                                    fontFamily:
                                        GoogleFonts.poppins().fontFamily,
                                    fontWeight: FontWeight.w400,
                                    fontSize: 13,
                                    color: const Color(0xff707070),
                                  ),
                                ),
                                StatusCardWidget(
                                  status: workItemStatusValues
                                      .reverse[workItem.status]
                                      .toString(),
                                )
                              ],
                            ),
                            SizedBox(
                              height: MediaQuery.of(context).size.height * 0.01,
                            ),
                            Container(
                              color: const Color(0xffEDEDED),
                              height: 0.5,
                              width: MediaQuery.of(context).size.width,
                            ),
                            SizedBox(
                              height: MediaQuery.of(context).size.height * 0.01,
                            ),
                          ],
                        ),
                      ),
                    ),
                  ),
                  SizedBox(
                    height: MediaQuery.of(context).size.height * 0.02,
                  ),
                  //Row of buttons
                  Row(
                    mainAxisAlignment: MainAxisAlignment.center,
                    crossAxisAlignment: CrossAxisAlignment.center,
                    children: [
                      SizedBox(
                        width: MediaQuery.of(context).size.width * 0.35,
                        child: ElevatedButton(
                          onPressed: () async {
                            var workItemStatus = WorkItemStatusUpdate(
                              workItemStatus: 'Approved',
                            );
                            //Update to approved
                            BlocProvider.of<WorkItemCubit>(context)
                                .changeWorkItemStatus(
                              workItem.workItemId,
                              workItemStatus,
                            );
                          },
                          style: AppResources().buttonStyles.buttonStyle(
                              backgroundColor: AppColors.blueColor,
                              textColor: Colors.white),
                          child: const Text('Approve'),
                        ),
                      ),
                      SizedBox(
                        width: MediaQuery.of(context).size.width * 0.08,
                      ),
                      SizedBox(
                        width: MediaQuery.of(context).size.width * 0.35,
                        child: ElevatedButton(
                          onPressed: () async {
                            var workItemStatus = WorkItemStatusUpdate(
                              workItemStatus: 'Rejected',
                            );
                            //Update to approved
                            BlocProvider.of<WorkItemCubit>(context)
                                .changeWorkItemStatus(
                              workItem.workItemId,
                              workItemStatus,
                            );
                          },
                          style: AppResources().buttonStyles.buttonStyle(
                              backgroundColor: AppColors.pinkColor,
                              textColor: Colors.white),
                          child: const Text('Reject'),
                        ),
                      ),
                    ],
                  ),
                ],
              ),
            ),
          ),
        ),
      ),
    );
  }
}
