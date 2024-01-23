import 'package:flutter/material.dart';

class AssetCard extends StatefulWidget {
  const AssetCard({super.key});

  @override
  State<AssetCard> createState() => _AssetCardState();
}

class _AssetCardState extends State<AssetCard> {
  @override
  Widget build(BuildContext context) {
    return Card(
      elevation: 0, // Set the elevation as needed
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(5)),
      child: const Padding(
        padding: const EdgeInsets.all(8.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text(
              'Dell Monitor',
              style: TextStyle(
                color: Color(0xFF292D32),
                fontSize: 14,
                fontFamily: 'Poppins',
                fontWeight: FontWeight.w500,
              ),
            ),
            SizedBox(height: 8),
            Text(
              'Location',
              style: TextStyle(
                color: Color(0xFFD93264),
                fontSize: 10,
                fontFamily: 'Poppins',
                fontWeight: FontWeight.w400,
              ),
            ),
            Text(
              'RC Lab 1',
              style: TextStyle(
                color: Color(0xFF292D32),
                fontSize: 13,
                fontFamily: 'Poppins',
                fontWeight: FontWeight.w500,
              ),
            ),
            SizedBox(height: 8),
            Row(
              children: [
                Expanded(
                  child: Text(
                    'Department',
                    style: TextStyle(
                      color: Color(0xFFD93264),
                      fontSize: 10,
                      fontFamily: 'Poppins',
                      fontWeight: FontWeight.w400,
                    ),
                  ),
                ),
                Text(
                  'CS Dept.',
                  style: TextStyle(
                    color: Color(0xFF292D32),
                    fontSize: 13,
                    fontFamily: 'Poppins',
                    fontWeight: FontWeight.w500,
                  ),
                ),
              ],
            ),
            SizedBox(height: 8),
            Row(
              children: [
                Expanded(
                  child: Text(
                    'Category',
                    style: TextStyle(
                      color: Color(0xFFD93264),
                      fontSize: 10,
                      fontFamily: 'Poppins',
                      fontWeight: FontWeight.w400,
                    ),
                  ),
                ),
                Text(
                  'Monitor',
                  style: TextStyle(
                    color: Color(0xFF292D32),
                    fontSize: 13,
                    fontFamily: 'Poppins',
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
