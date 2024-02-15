import 'package:flutter/material.dart';
import 'package:trackly_app/src/data/enumhelper/enums.dart';
import 'package:trackly_app/src/data/models/Assets/asset.dart';

class WorkItemCard extends StatefulWidget {
  const WorkItemCard({super.key});

  @override
  State<WorkItemCard> createState() => _WorkItemCardState();
}

class _WorkItemCardState extends State<WorkItemCard> {
  @override
  Widget build(BuildContext context) {
    return InkWell(
      onTap: () {
        // Navigate to the detailed page for this work item
      },
      child: Container(
        padding: EdgeInsets.all(16),
        margin: EdgeInsets.symmetric(vertical: 8, horizontal: 16),
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
              'title',
              style: TextStyle(
                fontSize: 18,
                fontWeight: FontWeight.bold,
              ),
            ),
            SizedBox(height: 12),
            Row(
              children: [
                Icon(
                  Icons.circle,
                  size: 12,
                  //color: status == 'In Progress' ? Colors.blue : Colors.grey,
                ),
                SizedBox(width: 4),
                Text(
                  'status',
                  style: TextStyle(
                    fontSize: 14,
                    //color: status == 'In Progress' ? Colors.blue : Colors.grey,
                    fontWeight: FontWeight.w500,
                  ),
                ),
                SizedBox(width: 16),
                Icon(
                  Icons.priority_high,
                  size: 16,
                  //color: priority == 'High' ? Colors.red : Colors.grey,
                ),
                SizedBox(width: 4),
                Text(
                  'priority',
                  style: TextStyle(
                    fontSize: 14,
                    //color: priority == 'High' ? Colors.red : Colors.grey,
                    fontWeight: FontWeight.w500,
                  ),
                ),
              ],
            ),
          ],
        ),
      ),
    );
  }
}
