import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:intl/intl.dart';
import 'package:trackly_app/src/data/enumhelper/enums.dart';
import 'package:trackly_app/src/data/models/Tickets/ticket.dart';
import 'package:trackly_app/src/utils/app_resources.dart';
import 'package:trackly_app/src/utils/widgets/status_card.dart';

class TicketDetailsPage extends StatefulWidget {
  const TicketDetailsPage({super.key});

  @override
  State<TicketDetailsPage> createState() => _TicketDetailsPageState();
}

class _TicketDetailsPageState extends State<TicketDetailsPage> {
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
                          Row(
                            mainAxisAlignment: MainAxisAlignment.spaceBetween,
                            children: [
                              Text(
                                'Status',
                                textAlign: TextAlign.start,
                                style: TextStyle(
                                  fontFamily: GoogleFonts.poppins().fontFamily,
                                  fontWeight: FontWeight.w400,
                                  fontSize: 13,
                                  color: const Color(0xff707070),
                                ),
                              ),
                              StatusCardWidget(
                                status: statusValues.reverse[ticket.status]
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
              ],
            ),
          ),
        ),
      ),
    );
  }
}
