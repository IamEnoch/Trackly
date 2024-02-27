import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:intl/intl.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_state.dart';
import 'package:trackly_app/src/bloc/app_functionality/users/users_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/users/users_state.dart';
import 'package:trackly_app/src/data/models/Assets/asset_create.dart';
import 'package:trackly_app/src/data/models/Auth/user.dart';
import 'package:trackly_app/src/utils/all_constants_imports.dart';
import 'package:trackly_app/src/utils/app_colors.dart';
import 'package:trackly_app/src/utils/app_resources.dart';

class AssetCreatePage extends StatefulWidget {
  const AssetCreatePage({super.key});

  @override
  State<AssetCreatePage> createState() => _AssetCreatePageState();
}

class _AssetCreatePageState extends State<AssetCreatePage> {
  final _formKey = GlobalKey<FormState>();
  final log = logger(_AssetCreatePageState);
  List<User> _users = []; // List to store fetched users

  // Text controllers for five fields
  late TextEditingController _assetNameController;
  late TextEditingController _departmentController;
  late TextEditingController _locationController;
  late TextEditingController _categoryController;
  late TextEditingController _serialNumberController;
  late TextEditingController _barcodeNumberController;
  late TextEditingController _ramController;
  late TextEditingController _storageController;
  late TextEditingController _processorController;
  late TextEditingController _conditionController;
  late TextEditingController _userController;
  late TextEditingController _descriptionController;
  late TextEditingController _purchaseDateContoller;
  late TextEditingController _purchaseCostController;

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
    _ramController = TextEditingController();
    _storageController = TextEditingController();
    _processorController = TextEditingController();
    _conditionController = TextEditingController();
    _userController = TextEditingController();

    _descriptionController = TextEditingController();
    _purchaseDateContoller = TextEditingController();
    _purchaseCostController = TextEditingController();
  }

  @override
  void dispose() {
    _assetNameController.dispose();
    _departmentController.dispose();
    _categoryController.dispose();
    _locationController.dispose();
    _serialNumberController.dispose();
    _barcodeNumberController.dispose();
    _ramController.dispose();
    _storageController.dispose();
    _processorController.dispose();
    _conditionController.dispose();
    _userController.dispose();
    _descriptionController.dispose();
    _purchaseCostController.dispose();
    _purchaseDateContoller.dispose();

    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
        child: SingleChildScrollView(
          child: Center(
            child: Padding(
              padding: EdgeInsets.all(MediaQuery.of(context).size.width * 0.05),
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
                          'Create Asset',
                          style: AppResources().appStyles.textStyles.headineH5,
                        ),
                      ],
                    ),
                    SizedBox(height: MediaQuery.of(context).size.height * 0.05),
                    TextFormField(
                      //vertical text field,
                      validator: (value) {
                        //If not filled return error
                        if (value == null || value.isEmpty) {
                          return 'Please enter an Asset number';
                        }
                        return null;
                      },
                      maxLines: null,
                      onChanged: (value) => _assetNameController.text = value,
                      style: AppResources().appStyles.textStyles.bodyTextInput,
                      decoration:
                          AppResources().textFieldStyles.inputDecoration(
                                labelText: 'Asset Name',
                              ),
                    ),
                    SizedBox(height: MediaQuery.of(context).size.height * 0.02),
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
                      controller: _barcodeNumberController,
                      maxLines: null,
                      style: AppResources().appStyles.textStyles.bodyTextInput,
                      decoration: AppResources()
                          .textFieldStyles
                          .inputDecoration(
                            labelText: 'Barcode Number',
                          )
                          .copyWith(
                            suffixIcon: IconButton(
                              onPressed: () async {
                                _barcodeNumberController.clear();
                                _barcodeNumberController.text =
                                    await Navigator.of(context)
                                            .pushNamed(barcodeScanPageRoute)
                                        as String;
                              },
                              icon: Image.asset(AppAssets.scanIcon, scale: 2),
                            ),
                          ),
                    ),

                    //Serial number
                    SizedBox(height: MediaQuery.of(context).size.height * 0.02),
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
                      controller: _serialNumberController,
                      style: AppResources().appStyles.textStyles.bodyTextInput,
                      decoration:
                          AppResources().textFieldStyles.inputDecoration(
                                labelText: 'Serial Number',
                              ),
                    ),
                    SizedBox(height: MediaQuery.of(context).size.height * 0.02),

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
                              items: _users.map((user) {
                                return DropdownMenuItem<String>(
                                  value:
                                      user.userId, // Assuming user.id is unique
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

                    SizedBox(height: MediaQuery.of(context).size.height * 0.02),
                    //Priority and category are dropdowns in the same row
                    Row(
                      children: [
                        Expanded(
                          //Drop down for department
                          child: DropdownButtonFormField(
                            validator: (value) {
                              //If not filled return error
                              if (value == null || value.isEmpty) {
                                return 'Please select a department';
                              }
                              return null;
                            },
                            isExpanded: true,
                            // style: AppResources()
                            //     .appStyles
                            //     .textStyles
                            //     .bodyTextInput,
                            decoration:
                                AppResources().textFieldStyles.inputDecoration(
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
                            decoration:
                                AppResources().textFieldStyles.inputDecoration(
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

                    SizedBox(height: MediaQuery.of(context).size.height * 0.02),

                    // -Condition(Selection)
                    Row(
                      children: [
                        Expanded(
                          //Drop down for priority
                          child: DropdownButtonFormField(
                            validator: (value) {
                              //If not filled return error
                              if (value == null || value.isEmpty) {
                                return 'Please select a Location';
                              }
                              return null;
                            },
                            // style: AppResources()
                            //     .appStyles
                            //     .textStyles
                            //     .bodyTextInput,
                            isExpanded: true,
                            decoration:
                                AppResources().textFieldStyles.inputDecoration(
                                      labelText: 'Location',
                                    ),
                            items: const [
                              DropdownMenuItem(
                                child: Text('Home'),
                                value: 'Home',
                              ),
                              DropdownMenuItem(
                                child: Text('Office'),
                                value: 'Office',
                              ),
                              DropdownMenuItem(
                                child: Text(
                                  'Other',
                                ),
                                value: 'Other',
                              ),
                            ],
                            onChanged: (value) {
                              setState(() {
                                _locationController.text = value as String;
                              });
                            },
                          ),
                        ),
                        SizedBox(
                            width: MediaQuery.of(context).size.width * 0.05),
                        Expanded(
                          child: DropdownButtonFormField(
                            validator: (value) {
                              if (value == null || value.isEmpty) {
                                return 'Please select a condition';
                              }
                              return null;
                            },
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
                        ),
                      ],
                    ),
                    SizedBox(height: MediaQuery.of(context).size.height * 0.02),

                    //Processor
                    TextFormField(
                      //vertical scrollable text field
                      maxLines: null,
                      controller: _processorController,
                      style: AppResources().appStyles.textStyles.bodyTextInput,
                      decoration:
                          AppResources().textFieldStyles.inputDecoration(
                                labelText: 'Processor',
                              ),
                    ),
                    SizedBox(height: MediaQuery.of(context).size.height * 0.02),

                    //Ram and storage
                    Row(
                      children: [
                        Expanded(
                          //Drop down for priority
                          child: TextFormField(
                            //vertical scrollable text field
                            keyboardType: TextInputType.number,
                            maxLines: null,
                            controller: _ramController,
                            style: AppResources()
                                .appStyles
                                .textStyles
                                .bodyTextInput,
                            decoration:
                                AppResources().textFieldStyles.inputDecoration(
                                      labelText: 'Ram(GB)',
                                    ),
                          ),
                        ),
                        SizedBox(
                            width: MediaQuery.of(context).size.width * 0.05),
                        Expanded(
                          child: TextFormField(
                            //vertical scrollable text field
                            keyboardType: TextInputType.number,
                            maxLines: null,
                            controller: _storageController,
                            style: AppResources()
                                .appStyles
                                .textStyles
                                .bodyTextInput,
                            decoration:
                                AppResources().textFieldStyles.inputDecoration(
                                      labelText: 'Storage(GB)',
                                    ),
                          ),
                        ),
                      ],
                    ),
                    SizedBox(height: MediaQuery.of(context).size.height * 0.02),

                    //Description
                    TextFormField(
                      //vertical scrollable text field
                      keyboardType: TextInputType.multiline,
                      maxLines: null,
                      controller: _descriptionController,
                      style: AppResources().appStyles.textStyles.bodyTextInput,
                      decoration:
                          AppResources().textFieldStyles.inputDecoration(
                                labelText: 'Description',
                              ),
                    ),
                    SizedBox(height: MediaQuery.of(context).size.height * 0.02),

                    //Purchase Date
                    Row(
                      children: [
                        Expanded(
                          child: TextFormField(
                            validator: (value) {
                              //If not filled return error
                              if (value == null || value.isEmpty) {
                                return 'Please enter the purchase Cost';
                              }
                              return null;
                            },
                            keyboardType: TextInputType.number,
                            maxLines: null,
                            controller: _purchaseCostController,
                            style: AppResources()
                                .appStyles
                                .textStyles
                                .bodyTextInput,
                            decoration: AppResources()
                                .textFieldStyles
                                .inputDecoration(
                                  labelText: 'Purchase Cost',
                                )
                                .copyWith(
                                  prefixIcon: const Icon(
                                      Icons.attach_money), //icon of text field
                                ),
                          ),
                        ),
                        SizedBox(
                            width: MediaQuery.of(context).size.width * 0.05),
                        Expanded(
                          child: TextFormField(
                            //vertical scrollable text field
                            validator: (value) {
                              //If not filled return error
                              if (value == null || value.isEmpty) {
                                return 'Please enter a date';
                              }
                              return null;
                            },
                            maxLines: null,
                            style: AppResources()
                                .appStyles
                                .textStyles
                                .bodyTextInput,
                            decoration: AppResources()
                                .textFieldStyles
                                .inputDecoration(
                                  labelText: 'Purchase Date',
                                )
                                .copyWith(
                                  prefixIcon: const Icon(Icons
                                      .calendar_today), //icon of text field
                                ),
                            readOnly:
                                true, //set it true, so that user will not able to edit text
                            controller: _purchaseDateContoller,
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
                                    DateFormat('yyyy-MM-dd').format(pickedDate);
                                print(
                                    formattedDate); //formatted date output using intl package =>  2021-03-16
                                //you can implement different kind of Date Format here according to your requirement

                                setState(() {
                                  _purchaseDateContoller.text =
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
                              AssetCreate assetCreate = AssetCreate(
                                barcodeNumber: _barcodeNumberController.text,
                                assetName: _assetNameController.text,
                                category: _categoryController.text,
                                departmentName: _departmentController.text,
                                locationName: _locationController.text,
                                condition: _conditionController.text,
                                ram: _ramController.text == ''
                                    ? null
                                    : _ramController.text,
                                serialNumber: _serialNumberController.text,
                                assignedTo: _userController.text,
                                processor: _processorController.text == ''
                                    ? null
                                    : _processorController.text,
                                storage: _storageController.text == ''
                                    ? null
                                    : _storageController.text,
                                description: _descriptionController.text == ''
                                    ? null
                                    : _descriptionController.text,
                                purchaseCost: double.tryParse(
                                        _purchaseCostController.text) ??
                                    0.0,
                                purchaseDate: DateTime.now(),
                              );
                              log.d(
                                  'The create asset to be submitted is ${assetCreate.toJson()}');

                              await AssetCubit().createAsset(assetCreate);
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
    );
  }
}
