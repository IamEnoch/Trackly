import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:trackly_app/src/data/enumhelper/enums.dart';
import 'package:trackly_app/src/data/models/WorkItems/work_item.dart';

class WorkItemCard extends StatefulWidget {
  const WorkItemCard({required this.workItem, super.key});
  final WorkItem workItem;

  @override
  State<WorkItemCard> createState() => _WorkItemCardState();
}

class _WorkItemCardState extends State<WorkItemCard> {
  late String timeAgo;

  @override
  void initState() {
    super.initState();
    updateTimeAgo();
  }

  void updateTimeAgo() {
    Duration difference =
        DateTime.now().difference(widget.workItem.createdAt.toUtc());

    if (difference.inSeconds < 60) {
      timeAgo = "${difference.inSeconds} seconds ago";
    } else if (difference.inMinutes < 60 && difference.inSeconds >= 60) {
      timeAgo = "${difference.inMinutes} minutes ago";
    } else if (difference.inHours < 24 && difference.inMinutes >= 60) {
      timeAgo = "${difference.inHours} hours ago";
    } else if (difference.inDays < 365 && difference.inHours >= 24) {
      // Less than a year
      timeAgo = "${difference.inDays} days ago";
    } else {
      int years = difference.inDays ~/ 365;
      timeAgo = "${years} years ago";
    }

    setState(() {}); // Update the UI with the new time ago value
  }

  @override
  Widget build(BuildContext context) {
    return Container(
      padding: EdgeInsets.all(16),
      decoration: BoxDecoration(
        color: Colors.white,
        borderRadius: BorderRadius.circular(8),
        boxShadow: [
          BoxShadow(
            color: Colors.grey.withOpacity(0.3),
            spreadRadius: 1,
            blurRadius: 2,
            offset: Offset(0, 2),
          ),
        ],
      ),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(
            widget.workItem.title,
            style: const TextStyle(
              color: Color(0xFF292D32),
              fontSize: 15,
              fontFamily: 'Poppins',
              fontWeight: FontWeight.w500,
            ),
          ),
          SizedBox(height: 12),
          Row(
            children: [
              SizedBox(width: 4),
              Text(
                'Priority',
                style: GoogleFonts.poppins(
                  color: Color(0xFFDA3365),
                  textStyle: TextStyle(
                    fontSize: 10,
                    //color: priority == 'High' ? Colors.red : Colors.grey,
                    fontWeight: FontWeight.w400,
                  ),
                ),
              ),
              SizedBox(
                width: MediaQuery.of(context).size.width * 0.03,
              ),
              Text(
                priorityValues.reverse[widget.workItem.priority].toString(),
                style: GoogleFonts.poppins(
                  color: Color(0xFF292D32),
                  textStyle: TextStyle(
                    fontSize: 13,
                    //color: priority == 'High' ? Colors.red : Colors.grey,
                    fontWeight: FontWeight.w500,
                  ),
                ),
              ),
              SizedBox(
                width: MediaQuery.of(context).size.width * 0.17,
              ),
              Text(
                'Time',
                style: GoogleFonts.poppins(
                  color: Color(0xFFDA3365),
                  textStyle: TextStyle(
                    fontSize: 10,
                    //color: priority == 'High' ? Colors.red : Colors.grey,
                    fontWeight: FontWeight.w400,
                  ),
                ),
              ),
              SizedBox(
                width: MediaQuery.of(context).size.width * 0.03,
              ),
              Text(
                timeAgo,
                style: GoogleFonts.poppins(
                  color: Color(0xFF292D32),
                  textStyle: TextStyle(
                    fontSize: 13,
                    //color: priority == 'High' ? Colors.red : Colors.grey,
                    fontWeight: FontWeight.w500,
                  ),
                ),
              ),
            ],
          ),
        ],
      ),
    );
  }
}
