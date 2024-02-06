import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:intl/intl.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_state.dart';
import 'package:trackly_app/src/bloc/app_functionality/workItems/workt_item_cubit.dart';
import 'package:trackly_app/src/data/enumhelper/enums.dart';
import 'package:trackly_app/src/data/localstorage/shared_reference_manager.dart';
import 'package:trackly_app/src/data/models/Assets/asset.dart';
import 'package:trackly_app/src/data/models/work_item.dart';
import 'package:trackly_app/src/utils/all_constants_imports.dart';
import 'package:trackly_app/src/utils/app_colors.dart';
import 'package:trackly_app/src/utils/app_resources.dart';

class EditAssetPage extends StatefulWidget {
  const EditAssetPage({super.key});

  @override
  State<EditAssetPage> createState() => _WorkItemPageState();
}

class _WorkItemPageState extends State<EditAssetPage> {
  final _formKey = GlobalKey<FormState>();
  final log = logger(_WorkItemPageState);

  //text controllers for five fields
  final TextEditingController _assetNameController = TextEditingController();
  final TextEditingController _departmentController = TextEditingController();
  final TextEditingController _categoryController = TextEditingController();

  final TextEditingController _serialNumberController = TextEditingController();
  final TextEditingController _barcodeNumberController =
      TextEditingController();
  final TextEditingController _updatedAtController = TextEditingController();
  final TextEditingController _deletedAtController = TextEditingController();
  final TextEditingController _ramController = TextEditingController();
  final TextEditingController _storageController = TextEditingController();
  final TextEditingController _processorController = TextEditingController();
  final TextEditingController _conditionController = TextEditingController();

  //Values to be submitter from the form
  String? _assetId;

  //Dispose of the controllers when the widget is disposed
  @override
  void dispose() {
    _assetNameController.dispose();
    _departmentController.dispose();
    _categoryController.dispose();

    _serialNumberController.dispose();
    _barcodeNumberController.dispose();
    _updatedAtController.dispose();
    _deletedAtController.dispose();
    _ramController.dispose();
    _storageController.dispose();
    _processorController.dispose();
    _conditionController.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    final arguments =
        ModalRoute.of(context)?.settings.arguments as Map<String, dynamic>;

    //get asset from arguements and set the texts in the text controllers
    Asset myAsset = arguments['asset'] as Asset;
    _assetNameController.text = myAsset.assetName;
    _departmentController.text =
        departmentNameValues.reverse[myAsset.departmentName].toString();
    _categoryController.text =
        assetCategoryValues.reverse[myAsset.category].toString();
    _barcodeNumberController.text = myAsset.barcodeNumber;
    _serialNumberController.text = myAsset.serialNumber;
    _conditionController.text =
        conditionValues.reverse[myAsset.condition].toString();
    _processorController.text = myAsset.processor;
    _ramController.text = myAsset.ram;
    _storageController.text = myAsset.storage;
    // _updatedAtController.text = myAsset.updatedAt != null
    //     ? DateFormat('yyyy-MM-dd').format(myAsset.updatedAt!)
    //     : '';
    // _deletedAtController.text = myAsset.deletedAt != null
    //     ? DateFormat('yyyy-MM-dd').format(myAsset.deletedAt!)
    //     : '';

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
                      TextField(
                        //vertical text field,
                        maxLines: null,
                        controller: _assetNameController,
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
                                      .fetchAsset('100000000019');
                                },
                                icon: Image.asset(AppAssets.scanIcon, scale: 2),
                              ),
                            ),
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
                              style: AppResources()
                                  .appStyles
                                  .textStyles
                                  .bodyTextInput,
                              decoration: AppResources()
                                  .textFieldStyles
                                  .inputDecoration(
                                    labelText: 'Department',
                                  ),
                              items: const [
                                DropdownMenuItem(
                                  child: Text('Low'),
                                  value: 'Low',
                                ),
                                DropdownMenuItem(
                                  child: Text('Medium'),
                                  value: 'Medium',
                                ),
                                DropdownMenuItem(
                                  child: Text('High'),
                                  value: 'High',
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
                              style: AppResources()
                                  .appStyles
                                  .textStyles
                                  .bodyTextInput,
                              decoration: AppResources()
                                  .textFieldStyles
                                  .inputDecoration(
                                    labelText: 'Category',
                                  ),
                              items: const [
                                DropdownMenuItem(
                                  child: Text('Hardware'),
                                  value: 'Hardware',
                                ),
                                DropdownMenuItem(
                                  child: Text('Software'),
                                  value: 'Software',
                                ),
                                DropdownMenuItem(
                                  child: Text('Network'),
                                  value: 'Network',
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
                        controller: _barcodeNumberController,
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
                        controller: _serialNumberController,
                        style:
                            AppResources().appStyles.textStyles.bodyTextInput,
                        decoration:
                            AppResources().textFieldStyles.inputDecoration(
                                  labelText: 'Serial Number',
                                ),
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
                        style:
                            AppResources().appStyles.textStyles.bodyTextInput,
                        decoration:
                            AppResources().textFieldStyles.inputDecoration(
                                  labelText: 'Condition',
                                ),
                        items: [
                          DropdownMenuItem(
                            child: Text('Hardware'),
                            value: 'Hardware',
                          ),
                          DropdownMenuItem(
                            child: Text('Software'),
                            value: 'Software',
                          ),
                          DropdownMenuItem(
                            child: Text('Network'),
                            value: 'Network',
                          ),
                          DropdownMenuItem(
                            child: Text('Other'),
                            value: 'Other',
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
                        controller: _processorController,
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
                              controller: _ramController,
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
                              controller: _storageController,
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

                      //Created at
                      Row(
                        children: [
                          SizedBox(
                              height:
                                  MediaQuery.of(context).size.height * 0.02),
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
                              controller: _updatedAtController,
                              style: AppResources()
                                  .appStyles
                                  .textStyles
                                  .bodyTextInput,
                              decoration: AppResources()
                                  .textFieldStyles
                                  .inputDecoration(
                                    labelText: 'Updated At',
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
                                    _updatedAtController.text =
                                        formattedDate; //set output date to TextField value.
                                  });
                                } else {
                                  print("Date is not selected");
                                }
                              },
                            ),
                          ),

                          //Updated at
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
                              controller: _deletedAtController,
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
                          if (state is AssetCreated) {
                            ScaffoldMessenger.of(context).showSnackBar(
                              const SnackBar(
                                content: Text('Work Item Created'),
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
                        },
                        child: Center(
                          child: ElevatedButton(
                            onPressed: () async {
                              //Validate the form fields
                              if (_formKey.currentState!.validate()) {
                                //use cubit to submit the form
                                //create a work item object
                                // final workItem = WorkItem(
                                //   title: _titleController.text,
                                //   description: _descriptionController.text,
                                //   priority: _departmentController.text,
                                //   category: _categoryController.text,
                                //   assetId: _assetId!,
                                //   creatorUserId:
                                //       await SharedPreferencesManager()
                                //           .getUserId(),
                                // );
                                // log.d(
                                //     'The create work item to be submitted is ${workItem.toJson()}');
                                // await WorkItemCubit().createWorkItem(workItem);
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
