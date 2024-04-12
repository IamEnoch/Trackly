import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:google_fonts/google_fonts.dart';

import 'package:syncfusion_flutter_charts/charts.dart' as charts;
import 'package:trackly_app/src/bloc/app_functionality/Metrics/metrics_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/Metrics/metrics_state.dart';

class TicketCardMetricWidget extends StatefulWidget {
  const TicketCardMetricWidget({super.key});

  @override
  State<TicketCardMetricWidget> createState() => _TicketCardMetricWidgetState();
}

class _TicketCardMetricWidgetState extends State<TicketCardMetricWidget> {
  late List<_ChartData> ticketsData;
  late charts.TooltipBehavior _tooltip;

  @override
  void initState() {
    _tooltip = charts.TooltipBehavior(enable: true);
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return BlocBuilder<MetricsCubit, MetricsState>(builder: (context, state) {
      if (state is MetricsLoading) {
        return const Center(
          child: CircularProgressIndicator(),
        );
      } else if (state is MetricsFailure) {
        return Center(
          child: Text(
            state.message,
            style: GoogleFonts.poppins(
              fontSize: 20,
              fontWeight: FontWeight.w600,
              color: Color(0xFF292D32),
            ),
          ),
        );
      } else if (state is MetricsSuccess) {
        //Metrics data
        final metrics = state.metrics;

        ticketsData = [
          _ChartData(
              'Open', metrics.ticketStatusMetrics.open, Color(0xFFF1C40F)),
          _ChartData('In Progress', metrics.ticketStatusMetrics.inProgress,
              Color(0xFF3498DB)),
          _ChartData('Completed', metrics.ticketStatusMetrics.completed,
              Color(0xFF27AE60)),
          _ChartData(
              'Closed', metrics.ticketStatusMetrics.closed, Color(0xFF95A5A6)),
        ];
        return Card(
          color: Color(0xFFFFFFFF),
          elevation: 1, // Set the elevation as needed
          shape:
              RoundedRectangleBorder(borderRadius: BorderRadius.circular(15)),
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
                              metrics.totalTickets.toString(),
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
                      legendItemBuilder: (String name, dynamic series,
                          dynamic point, int index) {
                        return SizedBox(
                          height: 65,
                          child: Row(
                            children: <Widget>[
                              Container(
                                width: MediaQuery.of(context).size.width * 0.06,
                                height:
                                    MediaQuery.of(context).size.height * 0.005,
                                //corners to have a radius
                                decoration: BoxDecoration(
                                  borderRadius: BorderRadius.circular(5),
                                  color: ticketsData[index].color,
                                ),
                              ),
                              SizedBox(
                                  width:
                                      MediaQuery.of(context).size.width * 0.04),
                              Column(
                                crossAxisAlignment: CrossAxisAlignment.start,
                                children: [
                                  Text(
                                    ticketsData[index].x,
                                    style: GoogleFonts.poppins(
                                      fontSize: 11,
                                      fontWeight: FontWeight.w400,
                                      color: Color(0xFF737373),
                                    ),
                                  ),
                                  SizedBox(
                                      height:
                                          MediaQuery.of(context).size.height *
                                              0.007),
                                  Text(
                                    ticketsData[index].y.toString(),
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
                        dataSource: ticketsData,
                        xValueMapper: (_ChartData data, _) => data.x,
                        yValueMapper: (_ChartData data, _) => data.y,
                        pointColorMapper: (datum, index) => datum.color,
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
      } else {
        return Text('Not handled');
      }
    });
  }
}

class _ChartData {
  _ChartData(this.x, this.y, this.color);

  final String x;
  final int y;
  final Color color;
}
