import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:fluttertoast/fluttertoast.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:trackly_app/src/bloc/app_functionality/tickets/tickets_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/tickets/tickets_state.dart';
import 'package:trackly_app/src/data/enumhelper/enums.dart';
import 'package:trackly_app/src/data/models/Tickets/ticket.dart';
import 'package:trackly_app/src/data/models/Tickets/ticket_status_update.dart';
import 'package:trackly_app/src/utils/app_resources.dart';
import 'package:trackly_app/src/utils/widgets/status_card.dart';

class AdminTicketDetailsPage extends StatefulWidget {
  const AdminTicketDetailsPage({super.key});

  @override
  State<AdminTicketDetailsPage> createState() => _AdminTicketDetailsPageState();
}

class _AdminTicketDetailsPageState extends State<AdminTicketDetailsPage> {
  @override
  Widget build(BuildContext context) {
    final arguments =
        ModalRoute.of(context)?.settings.arguments as Map<String, Ticket>;
    return Scaffold(
      backgroundColor: const Color(0xffF5F7FA),
      body: SafeArea(
        child: Padding(
          padding: EdgeInsets.only(
            left: MediaQuery.of(context).size.width * 0.059,
            right: MediaQuery.of(context).size.width * 0.059,
          ),
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
                            'Ticket',
                            style: TextStyle(
                              fontFamily: GoogleFonts.poppins().fontFamily,
                              fontWeight: FontWeight.w400,
                              fontSize: 16,
                              color: const Color(0xff474747),
                            ),
                          ),
                          SizedBox(
                            height: MediaQuery.of(context).size.height * 0.009,
                          ),
                          Text(
                            '#Funny',
                            style: TextStyle(
                              fontFamily: GoogleFonts.poppins().fontFamily,
                              fontWeight: FontWeight.w600,
                              fontSize: 24,
                              color: const Color(0xff121212),
                            ),
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
                              Text(
                                'Description',
                                textAlign: TextAlign.start,
                                style: TextStyle(
                                  fontFamily: GoogleFonts.poppins().fontFamily,
                                  fontWeight: FontWeight.w400,
                                  fontSize: 13,
                                  color: const Color(0xff707070),
                                ),
                              ),
                              const SizedBox(
                                width: 10,
                              ),
                              Text(
                                arguments['ticket']!.description,
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
                                  fontFamily: GoogleFonts.poppins().fontFamily,
                                  fontWeight: FontWeight.w400,
                                  fontSize: 13,
                                  color: const Color(0xff707070),
                                ),
                              ),
                              Text(
                                'Department',
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
                                  fontFamily: GoogleFonts.poppins().fontFamily,
                                  fontWeight: FontWeight.w400,
                                  fontSize: 13,
                                  color: const Color(0xff707070),
                                ),
                              ),
                              Text(
                                arguments['ticket']!.createdAt.toString(),
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
                                  fontFamily: GoogleFonts.poppins().fontFamily,
                                  fontWeight: FontWeight.w400,
                                  fontSize: 13,
                                  color: const Color(0xff707070),
                                ),
                              ),
                              Text(
                                arguments['ticket']!.createdAt.toString(),
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
                                  fontFamily: GoogleFonts.poppins().fontFamily,
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
                                'Branch',
                                textAlign: TextAlign.start,
                                style: TextStyle(
                                  fontFamily: GoogleFonts.poppins().fontFamily,
                                  fontWeight: FontWeight.w400,
                                  fontSize: 13,
                                  color: const Color(0xff707070),
                                ),
                              ),
                              Text(
                                'Branch',
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
                                  fontFamily: GoogleFonts.poppins().fontFamily,
                                  fontWeight: FontWeight.w400,
                                  fontSize: 13,
                                  color: const Color(0xff707070),
                                ),
                              ),
                              Text(
                                arguments['ticket']!.priority.name,
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
                                style: AppResources()
                                    .appStyles
                                    .textStyles
                                    .bodyDefaultBold,
                              ),
                              StatusCardWidget(
                                status: arguments['ticket']!.status.name,
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
                //Row of two elevated buttons, Approve and reject
                BlocListener<TicketCubit, TicketsState>(
                  bloc: TicketCubit(),
                  listener: (context, state) async {
                    // TODO: implement listener
                    if (state is TicketStatusUpdateSuccess) {
                      //Toast to show success and navigate back
                      //Show toast notification
                      Fluttertoast.showToast(
                        msg: "Status updated successfully",
                        toastLength: Toast
                            .LENGTH_LONG, // Duration for which the toast will be shown
                        gravity: ToastGravity
                            .BOTTOM, // Position of the toast on the screen

                        backgroundColor:
                            Colors.green, // Background color of the toast
                        textColor: Colors.white, // Text color of the toast
                        fontSize: 16.0, // Font size of the toast message
                      );

                      //Pop the page
                      await Future.delayed(const Duration(seconds: 2));
                      Navigator.of(context).pop();
                    } else if (state is TicketStatusUpdateFailure) {
                      //Toast to show failure and navigate back
                      //Show toast notification
                      Fluttertoast.showToast(
                        msg: "Status update failed",
                        toastLength: Toast
                            .LENGTH_SHORT, // Duration for which the toast will be shown
                        gravity: ToastGravity
                            .BOTTOM, // Position of the toast on the screen

                        backgroundColor:
                            Colors.red, // Background color of the toast
                        textColor: Colors.white, // Text color of the toast
                        fontSize: 16.0, // Font size of the toast message
                      );

                      //Pop the page
                      await Future.delayed(const Duration(seconds: 2));
                      Navigator.of(context).pop();
                    } else if (state is TicketStatusUpdateLoading) {
                      //Show toast notification
                      Fluttertoast.showToast(
                        msg: "Status update loading",
                        toastLength: Toast
                            .LENGTH_SHORT, // Duration for which the toast will be shown
                        gravity: ToastGravity
                            .BOTTOM, // Position of the toast on the screen

                        backgroundColor:
                            Colors.grey, // Background color of the toast
                        textColor: Colors.white, // Text color of the toast
                        fontSize: 16.0, // Font size of the toast message
                      );
                    }
                  },
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                    children: [
                      ElevatedButton(
                        onPressed: () {
                          //TODO: Implement approve button
                          //Update to ticket close
                          final TicketStatusUpdate ticketStatusUpdate =
                              TicketStatusUpdate(
                            ticketStatus: 'Closed',
                          );

                          //Change status via ticket cubit
                          TicketCubit().changeTicketStatus(
                            arguments['ticket']!.id,
                            ticketStatusUpdate,
                          );
                        },
                        style: ElevatedButton.styleFrom(
                          backgroundColor: const Color(0xff1573FE),
                          shape: RoundedRectangleBorder(
                            borderRadius: BorderRadius.circular(24),
                          ),
                          padding: EdgeInsets.symmetric(
                            horizontal: MediaQuery.of(context).size.width * 0.1,
                            vertical:
                                MediaQuery.of(context).size.height * 0.018,
                          ),
                        ),
                        child: Text(
                          'APPROVE',
                          style: TextStyle(
                            fontFamily: GoogleFonts.poppins().fontFamily,
                            fontWeight: FontWeight.w600,
                            fontSize: 13,
                            color: Colors.white,
                          ),
                        ),
                      ),
                      ElevatedButton(
                        onPressed: () {
                          //TODO: Implement approve button
                          //Update to ticket close
                          final TicketStatusUpdate ticketStatusUpdate =
                              TicketStatusUpdate(
                            ticketStatus: 'Open',
                          );

                          //Change status via ticket cubit
                          TicketCubit().changeTicketStatus(
                            arguments['ticket']!.id,
                            ticketStatusUpdate,
                          );
                        },
                        style: ElevatedButton.styleFrom(
                          backgroundColor: const Color(0xffDA3365),
                          shape: RoundedRectangleBorder(
                            borderRadius: BorderRadius.circular(24),
                          ),
                          padding: EdgeInsets.symmetric(
                            horizontal: MediaQuery.of(context).size.width * 0.1,
                            vertical:
                                MediaQuery.of(context).size.height * 0.018,
                          ),
                        ),
                        child: Text(
                          'REJECT',
                          style: TextStyle(
                            fontFamily: GoogleFonts.poppins().fontFamily,
                            fontWeight: FontWeight.w600,
                            fontSize: 13,
                            color: Colors.white,
                          ),
                        ),
                      ),
                    ],
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
