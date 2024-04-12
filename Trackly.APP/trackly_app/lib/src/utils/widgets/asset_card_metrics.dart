import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:google_fonts/google_fonts.dart';

import 'package:syncfusion_flutter_charts/charts.dart' as charts;
import 'package:syncfusion_flutter_gauges/gauges.dart' as gauges;
import 'package:trackly_app/src/bloc/app_functionality/Metrics/metrics_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/Metrics/metrics_state.dart';

class AssetCardMetricsWidget extends StatefulWidget {
  const AssetCardMetricsWidget({super.key});

  @override
  State<AssetCardMetricsWidget> createState() => _AssetCardMetricsWidgetState();
}

class _AssetCardMetricsWidgetState extends State<AssetCardMetricsWidget> {
  final MetricsCubit metricsCubit = MetricsCubit();
  late List<_ChartData> data;
  late charts.TooltipBehavior _tooltip;

  @override
  void initState() {
    metricsCubit.getMetrics();

    _tooltip = charts.TooltipBehavior(enable: true);
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return BlocBuilder<MetricsCubit, MetricsState>(
      builder: (context, state) {
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

          //Create a list of data from the asset categories in metrics
          data = [
            _ChartData(
                'New', metrics.assetConditionMetrics.New, Color(0xFF27AE60)),
            _ChartData(
                'Good', metrics.assetConditionMetrics.Good, Color(0xFF3498DB)),
            _ChartData(
                'Fair', metrics.assetConditionMetrics.Fair, Color(0xFFF1C40F)),
            _ChartData(
                'Poor', metrics.assetConditionMetrics.Poor, Color(0xFF95A5A6)),
            _ChartData('Broken', metrics.assetConditionMetrics.Broken,
                Color(0xFFD95959)),
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
                    'Assets',
                    style: GoogleFonts.poppins(
                      fontSize: 20,
                      fontWeight: FontWeight.w600,
                      color: Color(0xFF292D32),
                    ),
                  ),
                  SizedBox(
                    height: MediaQuery.of(context).size.height * 0.015,
                  ),
                  Row(
                    children: [
                      Text(
                        state.metrics.totalAssets.toString(),
                        style: GoogleFonts.poppins(
                          fontSize: 20,
                          fontWeight: FontWeight.w700,
                          color: Color(0xFF292D32),
                        ),
                      ),
                      SizedBox(
                        width: MediaQuery.of(context).size.width * 0.03,
                      ),
                      Text(
                        'Total',
                        style: GoogleFonts.poppins(
                          fontSize: 14,
                          fontWeight: FontWeight.w400,
                          color: Color(0xFF292D32),
                        ),
                      ),
                    ],
                  ),
                  SizedBox(
                    height: MediaQuery.of(context).size.height * 0.015,
                  ),

                  //Linear visual representation
                  gauges.SfLinearGauge(
                    minimum: 0,
                    maximum: state.metrics.totalAssets.toDouble(),
                    showTicks: false,
                    showLabels: false,
                    showAxisTrack: false,
                    animateRange: true,
                    animationDuration: 2000,
                    ranges: <gauges.LinearGaugeRange>[
                      //First range
                      gauges.LinearGaugeRange(
                        startValue: 0,
                        endValue:
                            state.metrics.assetsNotUnderMaintenance.toDouble(),
                        startWidth: 14,
                        endWidth: 14,
                        edgeStyle: gauges.LinearEdgeStyle.bothCurve,
                        color: Color(0xFFD95959),
                      ),
                      //Second range
                      gauges.LinearGaugeRange(
                        startValue:
                            state.metrics.assetsNotUnderMaintenance.toDouble(),
                        endValue: state.metrics.totalAssets.toDouble(),
                        startWidth: 14,
                        endWidth: 14,
                        edgeStyle: gauges.LinearEdgeStyle.endCurve,
                        color: Color(0xFFFAE2E2),
                      )
                    ],
                  ),
                  SizedBox(
                    height: MediaQuery.of(context).size.height * 0.03,
                  ),

                  //Legend (Inoperative and Operational)
                  Row(
                    mainAxisAlignment: MainAxisAlignment.center,
                    crossAxisAlignment: CrossAxisAlignment.center,
                    children: [
                      SizedBox(
                        height: MediaQuery.of(context).size.height * 0.07,
                        child: Row(
                          children: <Widget>[
                            Container(
                              width: MediaQuery.of(context).size.width * 0.05,
                              height:
                                  MediaQuery.of(context).size.height * 0.005,
                              //corners to have a radius
                              decoration: BoxDecoration(
                                borderRadius: BorderRadius.circular(5),
                                color: Colors.red,
                              ),
                            ),
                            SizedBox(
                                width:
                                    MediaQuery.of(context).size.width * 0.03),
                            Column(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              mainAxisAlignment: MainAxisAlignment.center,
                              children: [
                                Text(
                                  'Operational',
                                  style: GoogleFonts.poppins(
                                    fontSize: 11,
                                    fontWeight: FontWeight.w400,
                                    color: Color(0xFF737373),
                                  ),
                                ),
                                SizedBox(
                                    height: MediaQuery.of(context).size.height *
                                        0.015),
                                Text(
                                  state.metrics.assetsNotUnderMaintenance
                                      .toString(),
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
                      ),
                      SizedBox(width: MediaQuery.of(context).size.width * 0.13),
                      SizedBox(
                        height: MediaQuery.of(context).size.height * 0.07,
                        child: Row(
                          children: <Widget>[
                            Container(
                              width: MediaQuery.of(context).size.width * 0.05,
                              height:
                                  MediaQuery.of(context).size.height * 0.005,
                              //corners to have a radius
                              decoration: BoxDecoration(
                                borderRadius: BorderRadius.circular(5),
                                color: Color(0xFFFAE2E2),
                              ),
                            ),
                            SizedBox(
                                width:
                                    MediaQuery.of(context).size.width * 0.03),
                            Column(
                              crossAxisAlignment: CrossAxisAlignment.start,
                              mainAxisAlignment: MainAxisAlignment.center,
                              children: [
                                Text(
                                  'Under maintanance',
                                  style: GoogleFonts.poppins(
                                    fontSize: 11,
                                    fontWeight: FontWeight.w400,
                                    color: Color(0xFF737373),
                                  ),
                                ),
                                SizedBox(
                                    height: MediaQuery.of(context).size.height *
                                        0.015),
                                Text(
                                  state.metrics.assetsUnderMaintenance
                                      .toString(),
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
                      ),
                    ],
                  ),
                  SizedBox(
                    height: MediaQuery.of(context).size.height * 0.03,
                  ),
                  Container(
                    color: Color(0xFFD4CFCF),
                    height: MediaQuery.of(context).size.height * 0.002,
                    width: MediaQuery.of(context).size.width * 0.9,
                  ),
                  SizedBox(
                    height: MediaQuery.of(context).size.height * 0.03,
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
                                state.metrics.totalAssets.toString(),
                                style: GoogleFonts.poppins(
                                  fontSize: 14,
                                  fontWeight: FontWeight.w700,
                                  color: Color(0xFF292D32),
                                ),
                              ),
                              SizedBox(
                                height:
                                    MediaQuery.of(context).size.height * 0.01,
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
                            height: 58,
                            child: Row(
                              children: <Widget>[
                                Container(
                                  width:
                                      MediaQuery.of(context).size.width * 0.06,
                                  height: MediaQuery.of(context).size.height *
                                      0.005,
                                  //corners to have a radius
                                  decoration: BoxDecoration(
                                    borderRadius: BorderRadius.circular(5),
                                    color: data[index].color,
                                  ),
                                ),
                                SizedBox(
                                    width: MediaQuery.of(context).size.width *
                                        0.04),
                                Column(
                                  crossAxisAlignment: CrossAxisAlignment.start,
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
                                        height:
                                            MediaQuery.of(context).size.height *
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
      },
    );
  }
}

class _ChartData {
  _ChartData(this.x, this.y, this.color);

  final String x;
  final int y;
  final Color color;
}
