import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/data/models/Tickets/ticket.dart';
import 'package:trackly_app/src/utils/widgets/ticket_small_card.dart';

class AssetDetailsPage extends StatelessWidget {
  AssetDetailsPage({super.key});

  final log = logger(AssetDetailsPage);

  @override
  Widget build(BuildContext context) {
    final arguments =
        ModalRoute.of(context)?.settings.arguments as Map<String, dynamic>;

    final List<Ticket?> tickets = arguments['tickets'];
    final String assetName = arguments['assetName'];
    final String departmentName = arguments['department'];

    //log.e('The ticekts are: ${tickets[1]}');

    return Scaffold(
      backgroundColor: const Color(0xffF5F7FA),
      body: SingleChildScrollView(
        child: SafeArea(
          child: Padding(
            padding: EdgeInsets.only(
                left: MediaQuery.of(context).size.width * 0.059),
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
                    elevation: 1,
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
                          SizedBox(
                            height: MediaQuery.of(context).size.height * 0.018,
                          ),
                          Text(
                            'Tickets Under Asset:',
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
                            assetName,
                            style: TextStyle(
                              fontFamily: GoogleFonts.poppins().fontFamily,
                              fontWeight: FontWeight.w600,
                              fontSize: 24,
                              color: const Color(0xff121212),
                            ),
                          ),
                        ],
                      ),
                    ),
                  ),
                ),
                SizedBox(
                  height: MediaQuery.of(context).size.height * 0.0209,
                ),
                ListView.builder(
                  physics: const NeverScrollableScrollPhysics(),
                  shrinkWrap: true,
                  itemCount: tickets.length,
                  itemBuilder: (context, index) {
                    return Container(
                      padding: EdgeInsets.only(
                        right: MediaQuery.of(context).size.width * 0.0610,
                      ),
                      margin: const EdgeInsets.fromLTRB(0, 0, 0, 4),
                      child: TicketSmallCard(
                        ticket: tickets.elementAt(index)!,
                        departmentName: departmentName,
                      ),
                    );
                  },
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
