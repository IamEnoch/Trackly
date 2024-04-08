import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:intl/intl.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/data/localstorage/shared_reference_manager.dart';
import 'package:trackly_app/src/data/models/Tickets/ticket.dart';
import 'package:trackly_app/src/utils/all_constants_imports.dart';
import 'package:trackly_app/src/utils/widgets/status_card.dart';

class TicketSmallCard extends StatefulWidget {
  final Ticket ticket;
  final String departmentName;
  const TicketSmallCard({
    super.key,
    required this.ticket,
    required this.departmentName,
  });

  @override
  State<TicketSmallCard> createState() => _TicketSmallCardState();
}

class _TicketSmallCardState extends State<TicketSmallCard> {
  final log = logger(TicketSmallCard);

  @override
  Widget build(BuildContext context) {
    return Card(
      color: const Color(0xffFFFFFF),
      elevation: 1,
      // shape: RoundedRectangleBorder(
      //     borderRadius: BorderRadius.circular(24)),
      child: InkWell(
        onTap: () async {
          //Determine if role is admin or technician form shared prefs
          //If admin, navigate to admin ticket details page
          //If technician, navigate to technician ticket details page
          final String role = await SharedPreferencesManager().getRole();

          if (role == 'admin') {
            Navigator.of(context).pushNamed(
              adminTicketDetailsPageRoute,
              arguments: {
                'ticket': widget.ticket,
              },
            );
          } else {
            Navigator.of(context).pushNamed(
              ticketDetailsPageRoute,
              arguments: {
                'ticket': widget.ticket,
              },
            );
          }
        },
        borderRadius: BorderRadius.circular(10),
        child: Container(
          width: MediaQuery.of(context).size.width,
          padding: EdgeInsets.only(
            top: MediaQuery.of(context).size.height * 0.005,
            bottom: MediaQuery.of(context).size.height * 0.005,
            left: MediaQuery.of(context).size.width * 0.025,
            right: MediaQuery.of(context).size.width * 0.015,
          ),
          child: Row(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              Expanded(
                flex: 1,
                child: Text(
                  '#${widget.ticket.title}',
                  style: TextStyle(
                    fontFamily: GoogleFonts.poppins().fontFamily,
                    fontWeight: FontWeight.w400,
                    fontSize: 12,
                    color: const Color(0xff474747),
                  ),
                  maxLines: 1,
                  overflow: TextOverflow.ellipsis,
                ),
              ),
              SizedBox(
                width: MediaQuery.of(context).size.width * 0.045,
              ),
              Expanded(
                flex: 1,
                child: Text(
                  '${widget.departmentName}',
                  style: TextStyle(
                    fontFamily: GoogleFonts.poppins().fontFamily,
                    fontWeight: FontWeight.w400,
                    fontSize: 11,
                    color: const Color(0xff121212),
                  ),
                  maxLines: 1,
                  overflow: TextOverflow.ellipsis,
                ),
              ),
              SizedBox(
                width: MediaQuery.of(context).size.width * 0.035,
              ),
              Expanded(
                flex: 1,
                child: Text(
                  DateFormat('d/M/y').format(widget.ticket.createdAt),
                  style: TextStyle(
                    fontFamily: GoogleFonts.poppins().fontFamily,
                    fontWeight: FontWeight.w400,
                    fontSize: 12,
                    color: const Color(0xff121212),
                  ),
                  maxLines: 1,
                  overflow: TextOverflow.ellipsis,
                ),
              ),
              SizedBox(
                width: MediaQuery.of(context).size.width * 0.029,
              ),
              Expanded(
                flex: 1,
                child: StatusCardWidget(
                  status: widget.ticket.status.name,
                ),
              )
            ],
          ),
        ),
      ),
    );
  }
}
