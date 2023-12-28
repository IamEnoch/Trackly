import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_bloc.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_event.dart';
import 'package:trackly_app/src/bloc/auth/auth_bloc/auth_state.dart';
import 'package:trackly_app/src/data/localstorage/shared_reference_manager.dart';
import 'package:trackly_app/src/utils/all_constants_imports.dart';
import 'package:trackly_app/src/utils/app_resources.dart';

class ProfilePage extends StatefulWidget {
  const ProfilePage({super.key});

  @override
  State<ProfilePage> createState() => _ProfilePageState();
}

class _ProfilePageState extends State<ProfilePage> {
  SharedPreferencesManager prefs = SharedPreferencesManager();
  String userName = '';
  String userEmail = '';
  String userPhoneNumber = '';
  String userProfilePicture = '';

  //get necessary data from shared preferences
  Future<void> getUserData() async {
    userName = await prefs.getUserName();
    userEmail = await prefs.getUserEmail();
    userPhoneNumber = await prefs.getUserPhoneNumber();
    userProfilePicture = await prefs.getPictureUrl();
    debugPrint('User Name: $userName');
    debugPrint('User Email: $userEmail');
    debugPrint('User Phone Number: $userPhoneNumber');
    debugPrint('User Profile Picture: $userProfilePicture');
  }

  @override
  Widget build(BuildContext context) {
    return FutureBuilder(
        future: getUserData(),
        builder: (context, snapshot) {
          return BlocListener<AuthBloc, AuthState>(
            listener: (context, state) {
              // TODO: implement listener
              if (state is LogoutSuccess) {
                Navigator.of(context).pushReplacementNamed(signInRoute);
              }
            },
            child: Scaffold(
              body: SafeArea(
                  child: Center(
                child: Column(
                  children: [
                    SizedBox(
                      height: MediaQuery.of(context).size.height * 0.4,
                      child: Stack(
                        clipBehavior: Clip.none,
                        alignment: Alignment.topCenter,
                        children: [
                          ClipPath(
                            clipper: BottomHalfClipper(),
                            child: Container(
                              height: MediaQuery.of(context).size.height * 0.4,
                              alignment: Alignment.center,
                              decoration: const BoxDecoration(
                                color: Color(0xFFEBF0F0),
                              ),
                            ),
                          ),
                          Positioned(
                            top: MediaQuery.of(context).size.height * 0.28,
                            left: MediaQuery.of(context).size.width * 0.37,
                            child: Stack(
                              children: [
                                const CircleAvatar(
                                  radius: 50,
                                  backgroundImage: NetworkImage(
                                      "https://www.pngitem.com/pimgs/m/146-1468479_my-profile-icon-blank-profile-picture-circle-hd.png"),
                                ),
                                //edit icon with on press pressible for profile picture
                                Positioned(
                                  bottom: 0,
                                  right: 0,
                                  child: Container(
                                    height: 25,
                                    width: 25,
                                    decoration: BoxDecoration(
                                        color: Colors.white,
                                        borderRadius:
                                            BorderRadius.circular(20)),
                                    child: InkWell(
                                      onTap: () {},
                                      child: const Icon(
                                        Icons.edit,
                                        color: Colors.black,
                                      ),
                                    ),
                                  ),
                                ),
                              ],
                            ),
                          ),
                        ],
                      ),
                    ),

                    SizedBox(
                      height: MediaQuery.of(context).size.height * 0.01,
                    ),
                    Text(
                      userName,
                      textAlign: TextAlign.center,
                      style: AppResources().appStyles.textStyles.headineH6,
                    ),
                    SizedBox(
                      height: MediaQuery.of(context).size.height * 0.02,
                    ),
                    //card view for profile details(email, phone number, email, role). Use card widget
                    Card(
                      elevation: 2,
                      child: Container(
                        color: Colors.white,
                        width: MediaQuery.of(context).size.width * 0.9,
                        padding: const EdgeInsets.all(20),
                        child: Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            //row for email details
                            Row(
                              crossAxisAlignment: CrossAxisAlignment.center,
                              mainAxisAlignment: MainAxisAlignment.start,
                              children: [
                                SizedBox(
                                  width:
                                      MediaQuery.of(context).size.width * 0.2,
                                  child: Text(
                                    'Email',
                                    style: AppResources()
                                        .appStyles
                                        .textStyles
                                        .bodyDefault,
                                    overflow: TextOverflow.ellipsis,
                                  ),
                                ),
                                //Spacer widget for space between email and email text
                                const Spacer(),

                                //email text with predifined length
                                SizedBox(
                                  width:
                                      MediaQuery.of(context).size.width * 0.55,
                                  //ellipsis for text if it is too long
                                  child: Text(
                                    userEmail,
                                    style: AppResources()
                                        .appStyles
                                        .textStyles
                                        .componentsFilter
                                        .copyWith(
                                          color: Colors.blue,
                                        ),
                                    overflow: TextOverflow.ellipsis,
                                  ),
                                )
                              ],
                            ),
                            //row for phone number details
                            Row(
                              crossAxisAlignment: CrossAxisAlignment.center,
                              mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                              children: [
                                SizedBox(
                                  width:
                                      MediaQuery.of(context).size.width * 0.2,
                                  child: Text(
                                    'Mobile',
                                    style: AppResources()
                                        .appStyles
                                        .textStyles
                                        .bodyDefault,
                                    overflow: TextOverflow.ellipsis,
                                  ),
                                ),
                                //Spacer widget for space between phone number and phone number text
                                const Spacer(),
                                //phone number text
                                SizedBox(
                                  width:
                                      MediaQuery.of(context).size.width * 0.55,
                                  child: Text(
                                    userPhoneNumber,
                                    style: AppResources()
                                        .appStyles
                                        .textStyles
                                        .componentsFilter
                                        .copyWith(
                                          color: Colors.blue,
                                        ),
                                    overflow: TextOverflow.ellipsis,
                                  ),
                                )
                              ],
                            ),
                            //row for role details
                            Row(
                              crossAxisAlignment: CrossAxisAlignment.center,
                              mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                              children: [
                                SizedBox(
                                  width:
                                      MediaQuery.of(context).size.width * 0.2,
                                  child: Text(
                                    'Role',
                                    style: AppResources()
                                        .appStyles
                                        .textStyles
                                        .bodyDefault,
                                    overflow: TextOverflow.ellipsis,
                                  ),
                                ),
                                //Spacer widget for space between role and role text
                                const Spacer(),
                                //role text
                                SizedBox(
                                  width:
                                      MediaQuery.of(context).size.width * 0.55,
                                  child: Text(
                                    'Admin',
                                    style: AppResources()
                                        .appStyles
                                        .textStyles
                                        .componentsFilter
                                        .copyWith(
                                          color: Colors.blue,
                                        ),
                                    overflow: TextOverflow.ellipsis,
                                  ),
                                )
                              ],
                            ),
                          ],
                        ),
                      ),
                    ),
                    SizedBox(
                      height: MediaQuery.of(context).size.height * 0.05,
                    ),
                    ElevatedButton(
                      style: AppResources().buttonStyles.buttonStyle(
                            backgroundColor: Colors.red,
                          ),
                      onPressed: () async {
                        context.read<AuthBloc>().add(
                              const Logout(),
                            );
                      },
                      child: Padding(
                        padding:
                            const EdgeInsets.fromLTRB(30.0, 0.0, 30.0, 0.0),
                        child: Text(
                          "LOGOUT",
                          style: AppResources()
                              .appStyles
                              .textStyles
                              .componentsButtonDefault,
                        ),
                      ),
                    ),
                  ],
                ),
              )),
            ),
          );
        });
  }
}

class BottomHalfClipper extends CustomClipper<Path> {
  @override
  Path getClip(Size size) {
    final path = Path();
    path.lineTo(
        0, size.height * 0.7); // Adjust the height here for the bottom circle
    path.quadraticBezierTo(
        size.width / 2, size.height, size.width, size.height * 0.7);
    path.lineTo(size.width, 0);
    return path;
  }

  @override
  bool shouldReclip(covariant CustomClipper<Path> oldClipper) => false;
}
