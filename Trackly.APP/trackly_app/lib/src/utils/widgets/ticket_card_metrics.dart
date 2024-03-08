import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';

import 'package:syncfusion_flutter_charts/charts.dart' as charts;

class TicketCardMetricWidget extends StatefulWidget {
  const TicketCardMetricWidget({super.key});

  @override
  State<TicketCardMetricWidget> createState() => _TicketCardMetricWidgetState();
}

class _TicketCardMetricWidgetState extends State<TicketCardMetricWidget> {
  late List<_ChartData> data;
  late charts.TooltipBehavior _tooltip;

  double totalAssets = 500;
  double underMaintenace = 200;
  late double operative;

  @override
  void initState() {
    data = [
      _ChartData('David', 25),
      _ChartData('Steve', 38),
      _ChartData('Jack', 34),
      _ChartData('Others', 52)
    ];
    _tooltip = charts.TooltipBehavior(enable: true);

    operative = totalAssets - underMaintenace;
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return Card(
      color: Color(0xFFFFFFFF),
      elevation: 1, // Set the elevation as needed
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(15)),
      child: Padding(
        padding: const EdgeInsets.only(left: 15.0, right: 15.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            SizedBox(
              height: MediaQuery.of(context).size.height * 0.02,
            ),
            Text(
              'Tickets',
              style: GoogleFonts.poppins(
                fontSize: 20,
                fontWeight: FontWeight.w600,
                color: Color(0xFF292D32),
              ),
            ),
            SizedBox(
              height: MediaQuery.of(context).size.height * 0.01,
            ),
            charts.SfCircularChart(
                tooltipBehavior: _tooltip,
                centerX: "20%",
                centerY: "35%",
                margin: const EdgeInsets.only(
                    bottom: 0, top: 10, left: 10, right: 10),
                annotations: <charts.CircularChartAnnotation>[
                  charts.CircularChartAnnotation(
                    horizontalAlignment: charts.ChartAlignment.far,
                    verticalAlignment: charts.ChartAlignment.center,
                    height: "94%",
                    width: "133%",
                    widget: Column(
                      children: [
                        Text(
                          totalAssets.toInt().toString(),
                          style: GoogleFonts.poppins(
                            fontSize: 14,
                            fontWeight: FontWeight.w700,
                            color: Color(0xFF292D32),
                          ),
                        ),
                        SizedBox(
                          height: MediaQuery.of(context).size.height * 0.01,
                        ),
                        Text(
                          "Total",
                          style: GoogleFonts.poppins(
                            fontSize: 12,
                            fontWeight: FontWeight.w400,
                            color: Color(0xFF292D32),
                          ),
                        )
                      ],
                    ),
                  )
                ],
                legend: charts.Legend(
                  isVisible: true,
                  itemPadding: 2,
                  position: charts.LegendPosition.right,
                  orientation: charts.LegendItemOrientation.vertical,
                  overflowMode: charts.LegendItemOverflowMode.wrap,
                  // Templating the legend item
                  legendItemBuilder:
                      (String name, dynamic series, dynamic point, int index) {
                    return SizedBox(
                      height: 60,
                      child: Row(
                        children: <Widget>[
                          Container(
                            width: MediaQuery.of(context).size.width * 0.06,
                            height: MediaQuery.of(context).size.height * 0.005,
                            //corners to have a radius
                            decoration: BoxDecoration(
                              borderRadius: BorderRadius.circular(5),
                              color: Colors.red,
                            ),
                          ),
                          SizedBox(
                              width: MediaQuery.of(context).size.width * 0.04),
                          Column(
                            children: [
                              Text(
                                data[index].x,
                                style: GoogleFonts.poppins(
                                  fontSize: 11,
                                  fontWeight: FontWeight.w400,
                                  color: Color(0xFF737373),
                                ),
                              ),
                              SizedBox(
                                  height: MediaQuery.of(context).size.height *
                                      0.007),
                              Text(
                                data[index].y.toString(),
                                style: GoogleFonts.poppins(
                                  fontSize: 11,
                                  fontWeight: FontWeight.w600,
                                  color: Color(0xFF11263C),
                                ),
                              )
                            ],
                          )
                        ],
                      ),
                    );
                  },
                  offset: const Offset(-50, -40),
                ),
                series: <charts.CircularSeries<_ChartData, String>>[
                  charts.DoughnutSeries<_ChartData, String>(
                    dataSource: data,
                    xValueMapper: (_ChartData data, _) => data.x,
                    yValueMapper: (_ChartData data, _) => data.y,
                    name: 'Gold',
                    radius: "47%",
                    innerRadius: '79%',
                    animationDuration: 800,
                    cornerStyle: charts.CornerStyle.bothCurve,
                  )
                ])
          ],
        ),
      ),
    );
  }
}

class _ChartData {
  _ChartData(this.x, this.y);

  final String x;
  final double y;
}
