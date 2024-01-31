import 'package:flutter/material.dart';
import 'package:trackly_app/src/data/models/Assets/asset.dart';

class AssetCardSmall extends StatefulWidget {
  const AssetCardSmall({required this.asset, super.key});
  final Asset asset;

  @override
  State<AssetCardSmall> createState() => _AssetCardSmallState();
}

class _AssetCardSmallState extends State<AssetCardSmall> {
  @override
  Widget build(BuildContext context) {
    return Card(
      color: Colors.white,
      elevation: 0.7, // Set the elevation as needed
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(5)),
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text(
              widget.asset.assetName,
              style: const TextStyle(
                color: Color(0xFF292D32),
                fontSize: 14,
                fontFamily: 'Poppins',
                fontWeight: FontWeight.w500,
              ),
            ),
            SizedBox(
              height: MediaQuery.of(context).size.height * 0.015,
            ),
            Row(
              children: [
                Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    const Text(
                      'Location',
                      style: TextStyle(
                        color: Color(0xFFD93264),
                        fontSize: 10,
                        fontFamily: 'Poppins',
                        fontWeight: FontWeight.w400,
                      ),
                    ),
                    Text(
                      widget.asset.locationName,
                      style: const TextStyle(
                        color: Color(0xFF292D32),
                        fontSize: 13,
                        fontFamily: 'Poppins',
                        fontWeight: FontWeight.w500,
                      ),
                    ),
                  ],
                ),
                SizedBox(
                  width: MediaQuery.of(context).size.width * 0.17,
                ),
                Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    const Text(
                      'Department',
                      style: TextStyle(
                        color: Color(0xFFD93264),
                        fontSize: 10,
                        fontFamily: 'Poppins',
                        fontWeight: FontWeight.w400,
                      ),
                    ),
                    Text(
                      widget.asset.departmentName,
                      style: const TextStyle(
                        color: Color(0xFF292D32),
                        fontSize: 13,
                        fontFamily: 'Poppins',
                        fontWeight: FontWeight.w500,
                      ),
                    ),
                  ],
                ),
                SizedBox(
                  width: MediaQuery.of(context).size.width * 0.17,
                ),
                Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    const Text(
                      'Category',
                      style: TextStyle(
                        color: Color(0xFFD93264),
                        fontSize: 10,
                        fontFamily: 'Poppins',
                        fontWeight: FontWeight.w400,
                      ),
                    ),
                    Text(
                      widget.asset.category,
                      style: const TextStyle(
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
          ],
        ),
      ),
    );
  }
}
