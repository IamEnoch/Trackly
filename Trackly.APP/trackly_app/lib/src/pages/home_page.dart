import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_bloc.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_state.dart';
import 'package:trackly_app/src/utils/routes.dart';

import 'package:syncfusion_flutter_charts/charts.dart' as charts;
import 'package:syncfusion_flutter_gauges/gauges.dart' as gauges;

class HomePage extends StatefulWidget {
  const HomePage({super.key});

  @override
  State<HomePage> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  late List<_ChartData> data;
  late charts.TooltipBehavior _tooltip;

  @override
  void initState() {
    data = [
      _ChartData('David', 25),
      _ChartData('Steve', 38),
      _ChartData('Jack', 34),
      _ChartData('Others', 52)
    ];
    _tooltip = charts.TooltipBehavior(enable: true);
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return BlocListener<AuthBloc, AuthState>(
      listener: (context, state) {
        //TODO: implement listener
        if (state is LogoutSuccess) {
          Navigator.of(context).pushReplacementNamed(signInRoute);
        }
      },
      child: Scaffold(
        appBar: AppBar(
          title: const Text('name'),
        ),
        body: Center(
            child: Column(
          children: [
            const Text(
              'This is the',
              style: TextStyle(fontSize: 20),
            ),
            Card(
              color: Colors.white,
              elevation: 0.7, // Set the elevation as needed
              shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(5)),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Padding(
                    padding: const EdgeInsets.only(left: 8.0, right: 8.0),
                    child: gauges.SfLinearGauge(
                      showTicks: false,
                      showLabels: false,
                      showAxisTrack: false,
                      animateAxis: true,
                      animationDuration: 2000,
                      ranges: const <gauges.LinearGaugeRange>[
                        //First range
                        gauges.LinearGaugeRange(
                          startValue: 0,
                          endValue: 50,
                          startWidth: 14,
                          endWidth: 14,
                          edgeStyle: gauges.LinearEdgeStyle.startCurve,
                          color: Color(0xFFD95959),
                          position: gauges.LinearElementPosition.outside,
                        ),
                        //Second range
                        gauges.LinearGaugeRange(
                          startValue: 50,
                          endValue: 100,
                          startWidth: 14,
                          endWidth: 14,
                          edgeStyle: gauges.LinearEdgeStyle.endCurve,
                          color: Color(0xFFFAE2E2),
                          position: gauges.LinearElementPosition.outside,
                        )
                      ],
                    ),
                  ),
                  SizedBox(
                    height: MediaQuery.of(context).size.height * 0.03,
                  ),
                  Container(
                    color: Color(0xFFD4CFCF),
                    height: MediaQuery.of(context).size.height * 0.002,
                  ),
                  SizedBox(
                    height: MediaQuery.of(context).size.height * 0.03,
                  ),
                  charts.SfCircularChart(
                      tooltipBehavior: _tooltip,
                      centerX: "30%",
                      annotations: <charts.CircularChartAnnotation>[
                        charts.CircularChartAnnotation(
                          horizontalAlignment: charts.ChartAlignment.far,
                          widget: Container(
                            child: const Text(
                              '€ - \$ ',
                              style: TextStyle(
                                  fontWeight: FontWeight.bold, fontSize: 12),
                            ),
                          ),
                        )
                      ],
                      legend: charts.Legend(
                        isVisible: true,
                        position: charts.LegendPosition.right,
                        orientation: charts.LegendItemOrientation.vertical,
                        overflowMode: charts.LegendItemOverflowMode.wrap,
                        // Templating the legend item
                        legendItemBuilder: (String name, dynamic series,
                            dynamic point, int index) {
                          return SizedBox(
                            width: 120,
                            height: 60,
                            child: Row(
                              children: <Widget>[
                                Container(
                                  width:
                                      MediaQuery.of(context).size.width * 0.07,
                                  height: MediaQuery.of(context).size.height *
                                      0.005,
                                  //corners to have a radius
                                  decoration: BoxDecoration(
                                    borderRadius: BorderRadius.circular(5),
                                    color: Colors.red,
                                  ),
                                ),
                                SizedBox(
                                    width: MediaQuery.of(context).size.width *
                                        0.05),
                                Column(
                                  children: [
                                    Text(
                                      data[index].x,
                                      style: GoogleFonts.poppins(
                                        fontSize: 12,
                                        fontWeight: FontWeight.w400,
                                        color: Color(0xFF737373),
                                      ),
                                    ),
                                    SizedBox(
                                        height:
                                            MediaQuery.of(context).size.height *
                                                0.015),
                                    Text(
                                      data[index].y.toString(),
                                      style: GoogleFonts.poppins(
                                        fontSize: 12,
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
                        offset: const Offset(0, 0),
                      ),
                      series: <charts.CircularSeries<_ChartData, String>>[
                        charts.DoughnutSeries<_ChartData, String>(
                          dataSource: data,
                          xValueMapper: (_ChartData data, _) => data.x,
                          yValueMapper: (_ChartData data, _) => data.y,
                          name: 'Gold',
                          radius: "70%",
                          innerRadius: '75%',
                          animationDuration: 800,
                          // explode: true,
                          // explodeAll: true,
                          // explodeOffset: "2%",
                          cornerStyle: charts.CornerStyle.bothCurve,
                          //maximumValue: 100,
                        )
                      ])
                ],
              ),
            ),
          ],
        )),
      ),
    );
  }
}

class _ChartData {
  _ChartData(this.x, this.y);

  final String x;
  final double y;
}
