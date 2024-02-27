import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:intl/intl.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_state.dart';
import 'package:trackly_app/src/bloc/app_functionality/users/users_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/users/users_state.dart';
import 'package:trackly_app/src/data/enumhelper/enums.dart';
import 'package:trackly_app/src/data/models/Assets/asset.dart';
import 'package:trackly_app/src/data/models/Assets/asset_update.dart';
import 'package:trackly_app/src/data/models/Auth/user.dart';
import 'package:trackly_app/src/utils/all_constants_imports.dart';
import 'package:trackly_app/src/utils/app_colors.dart';
import 'package:trackly_app/src/utils/app_resources.dart';

class AssetEditPage extends StatefulWidget {
  const AssetEditPage({super.key});

  @override
  State<AssetEditPage> createState() => _AssetEditPageState();
}

class _AssetEditPageState extends State<AssetEditPage> {
  final _formKey = GlobalKey<FormState>();
  final log = logger(_AssetEditPageState);
  String? _selectedUser;
  List<User> _users = []; // List to store fetched users
  String? _assetId;

  // Text controllers for five fields
  late TextEditingController _assetNameController;
  late TextEditingController _departmentController;
  late TextEditingController _locationController;
  late TextEditingController _categoryController;
  late TextEditingController _serialNumberController;
  late TextEditingController _barcodeNumberController;
  late TextEditingController _updatedAtController;
  late TextEditingController _deletedAtController;
  late TextEditingController _ramController;
  late TextEditingController _storageController;
  late TextEditingController _processorController;
  late TextEditingController _conditionController;
  late TextEditingController _userController;
  late TextEditingController _descriptionController;

  @override
  void initState() {
    super.initState();
    UsersCubit().fetchUsers();
    _assetNameController = TextEditingController();
    _departmentController = TextEditingController();
    _locationController = TextEditingController();
    _categoryController = TextEditingController();
    _serialNumberController = TextEditingController();
    _barcodeNumberController = TextEditingController();
    _updatedAtController = TextEditingController();
    _deletedAtController = TextEditingController();
    _ramController = TextEditingController();
    _storageController = TextEditingController();
    _processorController = TextEditingController();
    _conditionController = TextEditingController();
    _userController = TextEditingController();

    _descriptionController = TextEditingController();
  }

  //Dispose of the controllers when the widget is disposed
  @override
  void dispose() {
    _assetNameController.dispose();
    _departmentController.dispose();
    _categoryController.dispose();
    _locationController.dispose();
    _serialNumberController.dispose();
    _barcodeNumberController.dispose();
    _updatedAtController.dispose();
    _deletedAtController.dispose();
    _ramController.dispose();
    _storageController.dispose();
    _processorController.dispose();
    _conditionController.dispose();
    _userController.dispose();
    _descriptionController.dispose();

    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    final arguments =
        ModalRoute.of(context)?.settings.arguments as Map<String, dynamic>;

    Asset myAsset = arguments['asset'] as Asset;
    _assetId = myAsset.assetId;
    return Scaffold(
      body: BlocListener<AssetCubit, AssetState>(
        listener: (context, state) {
          //Fill the asset name is the asset is fetched
          if (state is AssetFetched) {
            _assetNameController.text = state.asset.assetName;
            _assetId = state.asset.assetId;
          }
        },
        child: SafeArea(
          child: SingleChildScrollView(
            child: Center(
              child: Padding(
                padding:
                    EdgeInsets.all(MediaQuery.of(context).size.width * 0.05),
                child: Form(
                  key: _formKey,
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      SizedBox(
                        height: MediaQuery.of(context).size.height * 0.0049,
                      ),
                      Row(
                        children: [
                          SizedBox(
                            width: 35,
                            height: 35,
                            child: IconButton(
                              onPressed: () {
                                Navigator.of(context).pop();
                              },
                              icon: const Icon(
                                Icons.arrow_back_sharp,
                              ),
                            ),
                          ),
                          SizedBox(
                            width: MediaQuery.of(context).size.width * 0.05,
                          ),

                          //Title: Work Item
                          Text(
                            'Edit Asset',
                            style:
                                AppResources().appStyles.textStyles.headineH5,
                          ),
                        ],
                      ),
                      SizedBox(
                          height: MediaQuery.of(context).size.height * 0.05),
                      TextFormField(
                        //vertical text field,
                        maxLines: null,
                        initialValue: myAsset.assetName,
                        onChanged: (value) => _assetNameController.text = value,
                        style:
                            AppResources().appStyles.textStyles.bodyTextInput,
                        decoration: AppResources()
                            .textFieldStyles
                            .inputDecoration(
                              labelText: 'Asset Name',
                            )
                            .copyWith(
                              suffixIcon: IconButton(
                                onPressed: () {
                                  context
                                      .read<AssetCubit>()
                                      .getAsset('100000000019');
                                },
                                icon: Image.asset(AppAssets.scanIcon, scale: 2),
                              ),
                            ),
                      ),
                      SizedBox(
                          height: MediaQuery.of(context).size.height * 0.02),
                      //Barcode number

                      TextFormField(
                        //vertical scrollable text field
                        keyboardType: TextInputType.number,
                        validator: (value) {
                          //If not filled return error
                          if (value == null || value.isEmpty) {
                            return 'Please enter a barcode number';
                          }
                          return null;
                        },
                        maxLines: null,
                        initialValue: myAsset.barcodeNumber,
                        style:
                            AppResources().appStyles.textStyles.bodyTextInput,
                        decoration:
                            AppResources().textFieldStyles.inputDecoration(
                                  labelText: 'Barcode Number',
                                ),
                      ),

                      //Serial number
                      SizedBox(
                          height: MediaQuery.of(context).size.height * 0.02),
                      TextFormField(
                        //vertical scrollable text field
                        validator: (value) {
                          //If not filled return error
                          if (value == null || value.isEmpty) {
                            return 'Please enter a serial number';
                          }
                          return null;
                        },
                        maxLines: null,
                        //controller: _serialNumberController,
                        initialValue: myAsset.serialNumber,
                        onChanged: (value) {
                          _serialNumberController.text = value;
                        },
                        style:
                            AppResources().appStyles.textStyles.bodyTextInput,
                        decoration:
                            AppResources().textFieldStyles.inputDecoration(
                                  labelText: 'Serial Number',
                                ),
                      ),
                      SizedBox(
                          height: MediaQuery.of(context).size.height * 0.02),

                      //Assigned to
                      BlocBuilder<UsersCubit, UsersState>(
                        builder: (context, state) {
                          if (state is UsersFetched) {
                            //set state
                            _users = state.users;
                            return DropdownButtonFormField<String>(
                                validator: (value) {
                                  //If not filled return error
                                  if (value == null || value.isEmpty) {
                                    return 'Please select a user';
                                  }
                                  return null;
                                },
                                isExpanded: true,
                                // style: AppResources()
                                //     .appStyles
                                //     .textStyles
                                //     .bodyTextInput,
                                decoration: AppResources()
                                    .textFieldStyles
                                    .inputDecoration(
                                      labelText: 'Assigned to',
                                    ),
                                value: myAsset.assignedTo,
                                items: _users.map((user) {
                                  return DropdownMenuItem<String>(
                                    value: user
                                        .userId, // Assuming user.id is unique
                                    child: Text(user.email),
                                  );
                                }).toList(),
                                onChanged: (value) {
                                  setState(() {
                                    _userController.text =
                                        value!; // Ensure value is not null
                                  });
                                });
                          }
                          return DropdownButtonFormField<String>(
                            validator: (value) {
                              //If not filled return error
                              if (value == null || value.isEmpty) {
                                return 'Please select a user';
                              }
                              return null;
                            },
                            isExpanded: true,
                            decoration:
                                AppResources().textFieldStyles.inputDecoration(
                                      labelText: 'Assigned to',
                                    ),
                            items: null,
                            onChanged: (value) {},
                          );
                        },
                      ),

                      SizedBox(
                          height: MediaQuery.of(context).size.height * 0.02),
                      //Priority and category are dropdowns in the same row
                      Row(
                        children: [
                          Expanded(
                            //Drop down for priority
                            child: DropdownButtonFormField(
                              validator: (value) {
                                //If not filled return error
                                if (value == null || value.isEmpty) {
                                  return 'Please select a department';
                                }
                                return null;
                              },
                              value: departmentNameValues
                                  .reverse[myAsset.departmentName],

                              isExpanded: true,
                              // style: AppResources()
                              //     .appStyles
                              //     .textStyles
                              //     .bodyTextInput,
                              decoration: AppResources()
                                  .textFieldStyles
                                  .inputDecoration(
                                    labelText: 'Department',
                                  ),
                              items: const [
                                DropdownMenuItem(
                                  child: Text('Finance'),
                                  value: 'Finance',
                                ),
                                DropdownMenuItem(
                                  child: Text('HR'),
                                  value: 'HR',
                                ),
                                DropdownMenuItem(
                                  child: Text(
                                    'IT',
                                  ),
                                  value: 'IT',
                                ),
                              ],
                              onChanged: (value) {
                                setState(() {
                                  _departmentController.text = value as String;
                                });
                              },
                            ),
                          ),
                          SizedBox(
                              width: MediaQuery.of(context).size.width * 0.05),
                          Expanded(
                            //Drop down for category
                            child: DropdownButtonFormField(
                              validator: (value) {
                                if (value == null || value.isEmpty) {
                                  return 'Please select a category';
                                }
                                return null;
                              },
                              value:
                                  assetCategoryValues.reverse[myAsset.category],
                              decoration: AppResources()
                                  .textFieldStyles
                                  .inputDecoration(
                                    labelText: 'Category',
                                  ),
                              items: const [
                                DropdownMenuItem(
                                  child: Text('Desktop'),
                                  value: 'Desktop',
                                ),
                                DropdownMenuItem(
                                  child: Text('Laptop'),
                                  value: 'Laptop',
                                ),
                                DropdownMenuItem(
                                  child: Text('Monitor'),
                                  value: 'Monitor',
                                ),
                                DropdownMenuItem(
                                  child: Text('Printer'),
                                  value: 'Printer',
                                ),
                                DropdownMenuItem(
                                  child: Text('Projection'),
                                  value: 'Projection',
                                ),
                                DropdownMenuItem(
                                  child: Text('Scanner'),
                                  value: 'Scanner',
                                ),
                                DropdownMenuItem(
                                  child: Text('Other'),
                                  value: 'Other',
                                ),
                              ],
                              onChanged: (value) {
                                setState(() {
                                  _categoryController.text = value as String;
                                });
                              },
                            ),
                          ),
                        ],
                      ),

                      SizedBox(
                          height: MediaQuery.of(context).size.height * 0.02),
                      //add the followinf fields to be edited
                      // -Assigned to
                      // -Location

                      // -Condition(Selection)
                      DropdownButtonFormField(
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Please select a condition';
                          }
                          return null;
                        },
                        //value: _conditionController.text,
                        value: conditionValues.reverse[myAsset.condition],
                        decoration:
                            AppResources().textFieldStyles.inputDecoration(
                                  labelText: 'Condition',
                                ),
                        items: const [
                          DropdownMenuItem(
                            child: Text('New'),
                            value: 'New',
                          ),
                          DropdownMenuItem(
                            child: Text('Good'),
                            value: 'Good',
                          ),
                          DropdownMenuItem(
                            child: Text('Fair'),
                            value: 'Fair',
                          ),
                          DropdownMenuItem(
                            child: Text('Poor'),
                            value: 'Poor',
                          ),
                          DropdownMenuItem(
                            child: Text('Broken'),
                            value: 'Broken',
                          ),
                        ],
                        onChanged: (value) {
                          setState(() {
                            _conditionController.text = value as String;
                          });
                        },
                      ),
                      SizedBox(
                          height: MediaQuery.of(context).size.height * 0.02),

                      //Processor
                      TextFormField(
                        //vertical scrollable text field
                        maxLines: null,
                        initialValue: myAsset.processor,
                        onChanged: (value) {
                          setState(() {
                            _processorController.text = value;
                          });
                        },
                        style:
                            AppResources().appStyles.textStyles.bodyTextInput,
                        decoration:
                            AppResources().textFieldStyles.inputDecoration(
                                  labelText: 'Processor',
                                ),
                      ),
                      SizedBox(
                          height: MediaQuery.of(context).size.height * 0.02),
                      //Ram and storage
                      Row(
                        children: [
                          Expanded(
                            //Drop down for priority
                            child: TextFormField(
                              //vertical scrollable text field
                              keyboardType: TextInputType.number,
                              maxLines: null,
                              initialValue: myAsset.ram,
                              onChanged: (value) {
                                setState(() {
                                  _ramController.text = value;
                                });
                              },
                              style: AppResources()
                                  .appStyles
                                  .textStyles
                                  .bodyTextInput,
                              decoration: AppResources()
                                  .textFieldStyles
                                  .inputDecoration(
                                    labelText: 'Ram(GB)',
                                  ),
                            ),
                          ),
                          SizedBox(
                              width: MediaQuery.of(context).size.width * 0.05),
                          Expanded(
                            //Drop down for category
                            child: TextFormField(
                              //vertical scrollable text field
                              keyboardType: TextInputType.number,
                              maxLines: null,
                              initialValue: myAsset.storage,
                              onChanged: (value) {
                                setState(() {
                                  _storageController.text = value;
                                });
                              },
                              style: AppResources()
                                  .appStyles
                                  .textStyles
                                  .bodyTextInput,
                              decoration: AppResources()
                                  .textFieldStyles
                                  .inputDecoration(
                                    labelText: 'Storage(GB)',
                                  ),
                            ),
                          ),
                        ],
                      ),
                      SizedBox(
                          height: MediaQuery.of(context).size.height * 0.02),
                      //Description
                      TextFormField(
                        //vertical scrollable text field
                        maxLines: null,
                        //controller: _descriptionController,
                        initialValue: myAsset.description,
                        onChanged: (value) {
                          log.e('The value is $value');
                          setState(() {
                            _descriptionController.text = value;
                          });
                        },
                        style:
                            AppResources().appStyles.textStyles.bodyTextInput,
                        decoration:
                            AppResources().textFieldStyles.inputDecoration(
                                  labelText: 'Description',
                                ),
                      ),
                      SizedBox(
                          height: MediaQuery.of(context).size.height * 0.02),

                      //Created at
                      Row(
                        children: [
                          SizedBox(
                              height:
                                  MediaQuery.of(context).size.height * 0.02),

                          //Deleted at
                          SizedBox(
                              width: MediaQuery.of(context).size.width * 0.02),
                          Expanded(
                            child: TextFormField(
                              //vertical scrollable text field
                              // validator: (value) {
                              //   //If not filled return error
                              //   if (value == null || value.isEmpty) {
                              //     return 'Please enter a date';
                              //   }
                              //   return null;
                              // },
                              maxLines: null,
                              initialValue: myAsset.deletedAt == null
                                  ? null
                                  : DateFormat('yyyy-MM-dd')
                                      .format(myAsset.deletedAt!),
                              style: AppResources()
                                  .appStyles
                                  .textStyles
                                  .bodyTextInput,
                              decoration: AppResources()
                                  .textFieldStyles
                                  .inputDecoration(
                                    labelText: 'Deleted At',
                                  )
                                  .copyWith(
                                    prefixIcon: Icon(Icons
                                        .calendar_today), //icon of text field
                                  ),
                              readOnly:
                                  true, //set it true, so that user will not able to edit text

                              onTap: () async {
                                DateTime? pickedDate = await showDatePicker(
                                    context: context,
                                    initialDate: DateTime.now(),
                                    firstDate: DateTime(
                                        2000), //DateTime.now() - not to allow to choose before today.
                                    lastDate: DateTime(2101));

                                if (pickedDate != null) {
                                  print(
                                      pickedDate); //pickedDate output format => 2021-03-10 00:00:00.000
                                  String formattedDate =
                                      DateFormat('yyyy-MM-dd')
                                          .format(pickedDate);
                                  print(
                                      formattedDate); //formatted date output using intl package =>  2021-03-16
                                  //you can implement different kind of Date Format here according to your requirement

                                  setState(() {
                                    _deletedAtController.text =
                                        formattedDate; //set output date to TextField value.
                                  });
                                } else {
                                  print("Date is not selected");
                                }
                              },
                            ),
                          ),
                        ],
                      ),

                      //Asset details to be updated

                      //submit button
                      BlocListener<AssetCubit, AssetState>(
                        listener: (context, state) {
                          if (state is AssetUpdated) {
                            ScaffoldMessenger.of(context).showSnackBar(
                              const SnackBar(
                                content: Text('Asset Updated'),
                              ),
                            );
                          }
                          if (state is AssetCreated) {
                            ScaffoldMessenger.of(context).showSnackBar(
                              const SnackBar(
                                content: Text('Asset Created'),
                              ),
                            );
                          }
                          if (state is AssetFailure) {
                            ScaffoldMessenger.of(context).showSnackBar(
                              SnackBar(
                                content: Text(state.message),
                              ),
                            );
                          }
                          if (state is AssetLoading) {
                            ScaffoldMessenger.of(context).showSnackBar(
                              const SnackBar(
                                content: Text('Loading...'),
                              ),
                            );
                          }
                        },
                        child: Center(
                          child: ElevatedButton(
                            onPressed: () async {
                              //Validate the form fields
                              if (_formKey.currentState!.validate()) {
                                //use cubit to submit the form
                                //create a work item object
                                AssetUpdate assetUpdate = AssetUpdate(
                                  barcodeNumber:
                                      _barcodeNumberController.text == ''
                                          ? null
                                          : _barcodeNumberController.text,
                                  assetName: _assetNameController.text == ''
                                      ? null
                                      : _assetNameController.text,
                                  category: _categoryController.text == ''
                                      ? null
                                      : _categoryController.text,
                                  department: null,
                                  location: null,
                                  condition: _conditionController.text == ''
                                      ? null
                                      : _conditionController.text,
                                  ram: _ramController.text == ''
                                      ? null
                                      : _ramController.text,
                                  serialNumber:
                                      _serialNumberController.text == ''
                                          ? null
                                          : _serialNumberController.text,
                                  assignedToId: _userController.text == ''
                                      ? null
                                      : _userController.text,
                                  processor: _processorController.text == ''
                                      ? null
                                      : _processorController.text,
                                  storage: _storageController.text == ''
                                      ? null
                                      : _storageController.text,
                                  description: _descriptionController.text == ''
                                      ? null
                                      : _descriptionController.text,
                                  deletedAt: DateTime.tryParse(
                                              _deletedAtController.text) !=
                                          null
                                      ? DateTime.parse(
                                          _deletedAtController.text)
                                      : null,
                                );
                                log.d(
                                    'The create work item to be submitted is ${assetUpdate.toJson()}');

                                await AssetCubit()
                                    .updateAsset(_assetId!, assetUpdate);
                              }
                            },
                            style: AppResources().buttonStyles.buttonStyle(
                                backgroundColor: AppColors.blueColor,
                                textColor: Colors.white),
                            child: const Text('Submit'),
                          ),
                        ),
                      ),
                    ],
                  ),
                ),
              ),
            ),
          ),
        ),
      ),
    );
  }
}
