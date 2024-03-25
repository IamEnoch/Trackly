import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/tickets/tickets_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/tickets/tickets_state.dart';
import 'package:trackly_app/src/data/models/Tickets/ticket.dart';
import 'package:trackly_app/src/utils/widgets/ticket_small_card.dart';

class MyTicketsPage extends StatefulWidget {
  MyTicketsPage({super.key});

  @override
  State<MyTicketsPage> createState() => _MyTicketsPageState();
}

class _MyTicketsPageState extends State<MyTicketsPage> {
  final log = logger(MyTicketsPage);

  final TicketCubit ticketCubit = TicketCubit();

  static const _pageSize = 11;
  int _currentPage = 1;
  bool _isLoading = false;
  bool _fetchFuther = true;
  List<Ticket> _ticketList = [];
  String? _error;

  final ScrollController _scrollController = ScrollController();

  @override
  void initState() {
    super.initState();
    _fetchPage(_currentPage);

    _scrollController.addListener(_onScroll);
  }

  // Fetches a page of assets
  Future<void> _fetchPage(int pageKey) async {
    setState(() {
      _isLoading = true;
      _error = null;
    });

    try {
      final newItems =
          await ticketCubit.getPaginatedTicketsByUser(pageKey, _pageSize);

      setState(() {
        if (newItems.isEmpty) {
          _fetchFuther = false;
          _isLoading = false;
        } else {
          _ticketList.addAll(newItems);
          _isLoading = false;
          _currentPage++;
        }
      });
    } catch (e) {
      setState(() {
        _isLoading = false;
        _error = e.toString();
      });
    }
  }

  // Called when the user scrolls to the bottom of the list
  void _onScroll() {
    log.d('Pixels: ${_scrollController.position.pixels}');
    log.d('MaxScrollExtent: ${_scrollController.position.maxScrollExtent}');
    if (_scrollController.position.pixels ==
        _scrollController.position.maxScrollExtent) {
      if (_ticketList.length % _pageSize == 0) {
        if (_fetchFuther) {
          log.d('Fetching page $_currentPage');
          _fetchPage(_currentPage);
        }
        log.d('Fetching page $_currentPage');
      } else {
        _fetchFuther = false;
        log.d('No more pages to fetch');
      }
    }
  }

  @override
  Widget build(BuildContext context) {
    //log.e('The ticekts are: ${tickets[1]}');
    return Scaffold(
      backgroundColor: const Color(0xffF5F7FA),
      body: RefreshIndicator(
        onRefresh: () async {
          _currentPage = 1;
          _ticketList.clear();
          _fetchFuther = true;
          await _fetchPage(_currentPage);
        },
        child: SafeArea(
          child: Padding(
            padding: EdgeInsets.only(
                left: MediaQuery.of(context).size.width * 0.059),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                SizedBox(
                  height: MediaQuery.of(context).size.height * 0.0409,
                ),
                SizedBox(
                  height: MediaQuery.of(context).size.height * 0.0309,
                ),
                SizedBox(
                  width: MediaQuery.of(context).size.width * 0.877,
                  child: Card(
                    color: const Color(0xffFFFFFF),
                    elevation: 1,
                    shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(24)),
                    child: Container(
                      padding: EdgeInsets.only(
                        top: MediaQuery.of(context).size.height * 0.028,
                        bottom: MediaQuery.of(context).size.height * 0.028,
                        left: MediaQuery.of(context).size.width * 0.0610,
                        right: MediaQuery.of(context).size.width * 0.0610,
                      ),
                      child: Column(
                        children: [
                          SizedBox(
                            height: MediaQuery.of(context).size.height * 0.018,
                          ),
                          Text(
                            'My Tickets',
                            style: TextStyle(
                              fontFamily: GoogleFonts.poppins().fontFamily,
                              fontWeight: FontWeight.w600,
                              fontSize: 16,
                              color: Colors.black,
                            ),
                          ),
                          SizedBox(
                            height: MediaQuery.of(context).size.height * 0.009,
                          ),
                        ],
                      ),
                    ),
                  ),
                ),
                SizedBox(
                  height: MediaQuery.of(context).size.height * 0.0209,
                ),
                BlocBuilder<TicketCubit, TicketsState>(
                  bloc: BlocProvider.of<TicketCubit>(context),
                  builder: (context, state) {
                    if (state is TicketsLoading) {
                      //Diplay progress indicator
                      return Center(
                        child: CircularProgressIndicator(),
                      );
                    } else {
                      return Expanded(
                        child: ListView.builder(
                          controller: _scrollController,
                          itemCount: _ticketList.length + (_isLoading ? 1 : 0),
                          itemBuilder: (context, index) {
                            if (index == _ticketList.length) {
                              // Loading Indicator
                              return _isLoading
                                  ? const Center(
                                      child: CircularProgressIndicator(),
                                    )
                                  : Container(); // Return an empty container if not loading
                            } else {
                              return Container(
                                padding: EdgeInsets.only(
                                  right: MediaQuery.of(context).size.width *
                                      0.0610,
                                ),
                                margin: const EdgeInsets.fromLTRB(0, 0, 0, 4),
                                child: TicketSmallCard(
                                  ticket: _ticketList.elementAt(index)!,
                                  departmentName:
                                      _ticketList.elementAt(index).title,
                                ),
                              );
                            }
                          },
                        ),
                      );
                    }
                  },
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
