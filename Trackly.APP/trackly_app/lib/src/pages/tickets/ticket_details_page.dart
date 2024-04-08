import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:fluttertoast/fluttertoast.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:intl/intl.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/tickets/tickets_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/tickets/tickets_state.dart';
import 'package:trackly_app/src/data/enumhelper/enums.dart';
import 'package:trackly_app/src/data/models/Tickets/ticket.dart';
import 'package:trackly_app/src/data/models/Tickets/ticket_status_update.dart';
import 'package:trackly_app/src/utils/app_resources.dart';
import 'package:trackly_app/src/utils/widgets/status_card.dart';

class TicketDetailsPage extends StatefulWidget {
  const TicketDetailsPage({super.key});

  @override
  State<TicketDetailsPage> createState() => _TicketDetailsPageState();
}

class _TicketDetailsPageState extends State<TicketDetailsPage> {
  final log = logger(TicketDetailsPage);
  final TicketCubit ticketCubit = TicketCubit();

  @override
  Widget build(BuildContext context) {
    final arguments =
        ModalRoute.of(context)?.settings.arguments as Map<String, dynamic>;

    final ticket = arguments['ticket'] as Ticket;
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
                            ticket.title,
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
                                ticket.description,
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
                                DateFormat('dd/MM/yy').format(ticket.createdAt),
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
                                DateFormat('hh:mm a')
                                    .format(ticket.createdAt)
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
                                priorityValues.reverse[ticket.priority]
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
                          BlocListener<TicketCubit, TicketsState>(
                            listener: (context, state) {
                              if (state is TicketStatusUpdateSuccess) {
                                // Toast notification
                                Fluttertoast.showToast(
                                  msg: 'Status updated successfully',
                                  toastLength: Toast.LENGTH_SHORT,
                                  gravity: ToastGravity.BOTTOM,
                                  timeInSecForIosWeb: 1,
                                  backgroundColor: Colors.green,
                                  textColor: Colors.white,
                                  fontSize: 16.0,
                                );
                                Future.delayed(
                                  const Duration(seconds: 2),
                                  () {
                                    Navigator.of(context).pop();
                                  },
                                );
                              } else if (state is TicketStatusUpdateFailure) {
                                // Toast notification
                                Fluttertoast.showToast(
                                  msg: 'Status update failed',
                                  toastLength: Toast.LENGTH_SHORT,
                                  gravity: ToastGravity.BOTTOM,
                                  timeInSecForIosWeb: 1,
                                  backgroundColor: Colors.red,
                                  textColor: Colors.white,
                                  fontSize: 16.0,
                                );
                              } else if (state is TicketStatusUpdateLoading) {
                                // Toast notification
                                Fluttertoast.showToast(
                                  msg: 'Updating status...',
                                  toastLength: Toast.LENGTH_SHORT,
                                  gravity: ToastGravity.BOTTOM,
                                  timeInSecForIosWeb: 1,
                                  backgroundColor: Colors.blue,
                                  textColor: Colors.white,
                                  fontSize: 16.0,
                                );
                              }
                            },
                            child: Row(
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
                                InkWell(
                                  borderRadius: BorderRadius.circular(15),
                                  onTap: () {
                                    //Inflate the status dialog

                                    showDialog(
                                      context: context,
                                      builder: (context) {
                                        return SizedBox(
                                          width: MediaQuery.of(context)
                                                  .size
                                                  .width *
                                              0.8,
                                          child: AlertDialog(
                                            title: const Text('Status'),
                                            shape: RoundedRectangleBorder(
                                              borderRadius:
                                                  BorderRadius.circular(15),
                                            ),
                                            content: Column(
                                              mainAxisSize: MainAxisSize.min,
                                              children: [
                                                InkWell(
                                                  onTap: () {
                                                    //Alert dialog to confirm
                                                    Navigator.of(context).pop();
                                                    showDialog(
                                                      context: context,
                                                      builder: (context) {
                                                        return AlertDialog(
                                                          title: const Text(
                                                              'Change Status'),
                                                          content: const Text(
                                                              'Are you sure you want to change the status to Open?'),
                                                          actions: [
                                                            TextButton(
                                                              onPressed: () {
                                                                Navigator.of(
                                                                        context)
                                                                    .pop();
                                                              },
                                                              child: const Text(
                                                                'No',
                                                              ),
                                                            ),
                                                            TextButton(
                                                              onPressed: () {
                                                                //Change the status
                                                                ticketCubit
                                                                    .changeTicketStatus(
                                                                  ticket.id,
                                                                  TicketStatusUpdate(
                                                                      ticketStatus:
                                                                          'Open'),
                                                                );
                                                                Navigator.of(
                                                                        context)
                                                                    .pop();
                                                              },
                                                              child: const Text(
                                                                'Yes',
                                                              ),
                                                            ),
                                                          ],
                                                        );
                                                      },
                                                    );
                                                  },
                                                  child: StatusCardWidget(
                                                    status: 'Open',
                                                  ),
                                                ),
                                                InkWell(
                                                  onTap: () {
                                                    //Alert dialog to confirm
                                                    Navigator.of(context).pop();
                                                    showDialog(
                                                      context: context,
                                                      builder: (context) {
                                                        return AlertDialog(
                                                          title: const Text(
                                                              'Change Status'),
                                                          content: const Text(
                                                              'Are you sure you want to change the status to InProgress?'),
                                                          actions: [
                                                            TextButton(
                                                              onPressed: () {
                                                                Navigator.of(
                                                                        context)
                                                                    .pop();
                                                              },
                                                              child: const Text(
                                                                'No',
                                                              ),
                                                            ),
                                                            TextButton(
                                                              onPressed: () {
                                                                //Change the status
                                                                ticketCubit
                                                                    .changeTicketStatus(
                                                                  ticket.id,
                                                                  TicketStatusUpdate(
                                                                      ticketStatus:
                                                                          'InProgress'),
                                                                );
                                                                Navigator.of(
                                                                        context)
                                                                    .pop();
                                                              },
                                                              child: const Text(
                                                                'Yes',
                                                              ),
                                                            ),
                                                          ],
                                                        );
                                                      },
                                                    );
                                                  },
                                                  child: StatusCardWidget(
                                                    status: 'InProgress',
                                                  ),
                                                ),
                                                InkWell(
                                                  onTap: () {
                                                    //Alert dialog to confirm
                                                    Navigator.of(context).pop();
                                                    showDialog(
                                                      context: context,
                                                      builder: (context) {
                                                        return AlertDialog(
                                                          title: const Text(
                                                              'Change Status'),
                                                          content: const Text(
                                                              'Are you sure you want to change the status to Completed?'),
                                                          actions: [
                                                            TextButton(
                                                              onPressed: () {
                                                                Navigator.of(
                                                                        context)
                                                                    .pop();
                                                              },
                                                              child: const Text(
                                                                'No',
                                                              ),
                                                            ),
                                                            TextButton(
                                                              onPressed: () {
                                                                //Change the status
                                                                ticketCubit
                                                                    .changeTicketStatus(
                                                                  ticket.id,
                                                                  TicketStatusUpdate(
                                                                      ticketStatus:
                                                                          'Completed'),
                                                                );
                                                                Navigator.of(
                                                                        context)
                                                                    .pop();
                                                              },
                                                              child: const Text(
                                                                'Yes',
                                                              ),
                                                            ),
                                                          ],
                                                        );
                                                      },
                                                    );
                                                  },
                                                  child: StatusCardWidget(
                                                    status: 'Completed',
                                                  ),
                                                ),
                                              ],
                                            ),
                                            actions: [
                                              TextButton(
                                                onPressed: () {
                                                  Navigator.of(context).pop();
                                                },
                                                child: const Text('Close'),
                                              )
                                            ],
                                          ),
                                        );
                                      },
                                    );
                                  },
                                  child: StatusCardWidget(
                                    status: statusValues.reverse[ticket.status]
                                        .toString(),
                                  ),
                                )
                              ],
                            ),
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
              ],
            ),
          ),
        ),
      ),
    );
  }
}
