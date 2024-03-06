import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_bloc.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_event.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_state.dart';
import 'package:trackly_app/src/utils/routes.dart';

import 'package:syncfusion_flutter_charts/charts.dart';

class HomePage extends StatefulWidget {
  const HomePage({super.key});

  @override
  State<HomePage> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  late List<_ChartData> data;
  late TooltipBehavior _tooltip;

  @override
  void initState() {
    data = [
      _ChartData('David', 25),
      _ChartData('Steve', 38),
      _ChartData('Jack', 34),
      _ChartData('Others', 52)
    ];
    _tooltip = TooltipBehavior(enable: true);
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
                  SfCircularChart(
                      tooltipBehavior: _tooltip,
                      centerX: "30%",
                      annotations: <CircularChartAnnotation>[
                        CircularChartAnnotation(
                          horizontalAlignment: ChartAlignment.far,
                          widget: Container(
                            child: const Text(
                              '€ - \$ ',
                              style: TextStyle(
                                  fontWeight: FontWeight.bold, fontSize: 12),
                            ),
                          ),
                        )
                      ],
                      legend: Legend(
                        isVisible: true,
                        position: LegendPosition.right,
                        orientation: LegendItemOrientation.vertical,
                        overflowMode: LegendItemOverflowMode.wrap,
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
                                    Text(data[index].x),
                                    SizedBox(
                                        height:
                                            MediaQuery.of(context).size.height *
                                                0.005),
                                    Text(data[index].y.toString())
                                  ],
                                )
                              ],
                            ),
                          );
                        },
                        offset: const Offset(0, 0),
                      ),
                      series: <CircularSeries<_ChartData, String>>[
                        DoughnutSeries<_ChartData, String>(
                          dataSource: data,
                          xValueMapper: (_ChartData data, _) => data.x,
                          yValueMapper: (_ChartData data, _) => data.y,
                          name: 'Gold',
                          radius: "70%",
                          innerRadius: '75%',
                          animationDuration: 1050,
                          // explode: true,
                          // explodeAll: true,
                          // explodeOffset: "2%",
                          cornerStyle: CornerStyle.bothCurve,
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
