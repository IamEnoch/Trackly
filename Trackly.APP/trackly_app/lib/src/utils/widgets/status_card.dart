import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:trackly_app/src/data/models/status_color.dart';

class StatusCardWidget extends StatefulWidget {
  final String status;

  StatusCardWidget({
    super.key,
    required this.status,
  });

  @override
  State<StatusCardWidget> createState() => _StatusCardWidgetState();
}

class _StatusCardWidgetState extends State<StatusCardWidget> {
  late StatusColor statusColor;

  @override
  void initState() {
    statusColor = getColorForStatus(widget.status);
    super.initState();
  }

  StatusColor getColorForStatus(String status) {
    switch (status) {
      case 'Open':
        return StatusColor(
          textColor: const Color(0xff000000),
          backgroundColor: const Color(0xffF1C40F),
        );
      case 'InProgress':
        return StatusColor(
          backgroundColor: const Color(0xff3498DB),
        );
      case 'Completed':
        return StatusColor(
          backgroundColor: const Color(0xff27AE60),
        );
      // case 'Reopened':
      //   return StatusColor(
      //     backgroundColor: const Color(0xff9B59B6),
      //   );
      case 'Closed':
        return StatusColor(
          backgroundColor: const Color(0xff27AE60),
          //backgroundColor: const Color(0xff95A5A6),
        );
      default:
        return StatusColor(
          backgroundColor: Colors.grey,
        );
    }
  }

  @override
  Widget build(BuildContext context) {
    return Card(
      shape: RoundedRectangleBorder(
        borderRadius: BorderRadius.circular(13),
      ),
      color: statusColor.backgroundColor,
      child: Center(
        child: Padding(
          padding: const EdgeInsets.fromLTRB(10, 5, 10, 5),
          child: Text(
            widget.status,
            style: TextStyle(
              fontFamily: GoogleFonts.poppins().fontFamily,
              fontWeight: FontWeight.w600,
              fontSize: 10,
              color: statusColor.textColor,
            ),
            maxLines: 1,
            overflow: TextOverflow.ellipsis,
          ),
        ),
      ),
    );
  }
}
