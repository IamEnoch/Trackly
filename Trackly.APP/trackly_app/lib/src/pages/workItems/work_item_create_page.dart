import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_state.dart';
import 'package:trackly_app/src/bloc/app_functionality/workItems/work_item_state.dart';
import 'package:trackly_app/src/bloc/app_functionality/workItems/work_item_cubit.dart';
import 'package:trackly_app/src/data/localstorage/shared_reference_manager.dart';
import 'package:trackly_app/src/data/models/WorkItems/work_item_create.dart';
import 'package:trackly_app/src/utils/all_constants_imports.dart';
import 'package:trackly_app/src/utils/app_resources.dart';

class WorkItemCreatePage extends StatefulWidget {
  const WorkItemCreatePage({super.key});

  @override
  State<WorkItemCreatePage> createState() => _WorkItemCreatePageState();
}

class _WorkItemCreatePageState extends State<WorkItemCreatePage> {
  final _workItemFormKey = GlobalKey<FormState>();
  final log = logger(_WorkItemCreatePageState);

  //text controllers for five fields
  late final TextEditingController _assetNameController;
  late final TextEditingController _assetIdConroller;
  late final TextEditingController _descriptionController;
  late final TextEditingController _titleController;
  late final TextEditingController _priorityController;
  late final TextEditingController _categoryController;

  @override
  void initState() {
    super.initState();
    _assetNameController = TextEditingController();
    _assetIdConroller = TextEditingController();
    _descriptionController = TextEditingController();
    _titleController = TextEditingController();
    _priorityController = TextEditingController();
    _categoryController = TextEditingController();
  }

  //Dispose of the controllers when the widget is disposed
  @override
  void dispose() {
    _assetNameController.dispose();
    _assetIdConroller.dispose();
    _descriptionController.dispose();
    _titleController.dispose();
    _priorityController.dispose();
    _categoryController.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: BlocListener<AssetCubit, AssetState>(
        listener: (context, state) {
          //Fill the asset name is the asset is fetched
          if (state is AssetFetched) {
            _assetNameController.text = state.asset.assetName;
            _assetIdConroller.text = state.asset.assetId;
          }
        },
        child: SafeArea(
          child: SingleChildScrollView(
            child: Center(
              child: Padding(
                padding:
                    EdgeInsets.all(MediaQuery.of(context).size.width * 0.05),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    SizedBox(height: MediaQuery.of(context).size.height * 0.02),
                    //Title: Work Item
                    Text(
                      'Work Item',
                      style: AppResources().appStyles.textStyles.headineH4,
                    ),
                    SizedBox(height: MediaQuery.of(context).size.height * 0.05),

                    BlocListener<AssetCubit, AssetState>(
                      listener: (context, state) {
                        if (state is AssetFetched) {
                          _assetNameController.text = state.asset.assetName;
                          _assetIdConroller.text = state.asset.assetId;
                        } else if (state is AssetFailure) {
                          //Toast notification
                          ScaffoldMessenger.of(context)
                              .showSnackBar(const SnackBar(
                            content: Text('Asset not found'),
                          ));
                        }
                      },
                      child: TextFormField(
                        //vertical text field,
                        validator: (value) {
                          //If not filled return error
                          if (value == null || value.isEmpty) {
                            return 'Please enter an Asset Name';
                          }
                          return null;
                        },

                        maxLines: null,
                        controller: _assetNameController,
                        decoration: AppResources()
                            .textFieldStyles
                            .inputDecoration(
                              labelText: 'Asset Name',
                            )
                            .copyWith(
                              suffixIcon: IconButton(
                                onPressed: () async {
                                  var barcodeNumber =
                                      await Navigator.of(context)
                                              .pushNamed(barcodeScanPageRoute)
                                          as String;
                                  AssetCubit().getAsset(barcodeNumber);
                                },
                                icon: Image.asset(AppAssets.scanIcon, scale: 2),
                              ),
                            ),
                      ),
                    ),
                    SizedBox(height: MediaQuery.of(context).size.height * 0.03),
                    TextFormField(
                      validator: (value) {
                        //If not filled return error
                        if (value == null || value.isEmpty) {
                          return 'Please enter a title';
                        }
                        return null;
                      },
                      controller: _titleController,
                      decoration:
                          AppResources().textFieldStyles.inputDecoration(
                                labelText: 'Title',
                              ),
                      onChanged: (value) => _titleController.text = value,
                    ),
                    SizedBox(height: MediaQuery.of(context).size.height * 0.03),
                    TextFormField(
                      //vertical scrollable text field
                      validator: (value) {
                        //If not filled return error
                        if (value == null || value.isEmpty) {
                          return 'Please enter a description';
                        }
                        return null;
                      },
                      maxLines: null,
                      controller: _descriptionController,
                      decoration:
                          AppResources().textFieldStyles.inputDecoration(
                                labelText: 'Description',
                              ),
                      onChanged: (value) => _descriptionController.text = value,
                    ),
                    SizedBox(height: MediaQuery.of(context).size.height * 0.03),
                    //Priority and category are dropdowns in the same row
                    Row(
                      children: [
                        Expanded(
                          //Drop down for priority

                          child: DropdownButtonFormField(
                            validator: (value) {
                              //If not filled return error
                              if (value == null || value.isEmpty) {
                                return 'Please select a priority';
                              }
                              return null;
                            },
                            decoration:
                                AppResources().textFieldStyles.inputDecoration(
                                      labelText: 'Priority',
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
                                _priorityController.text = value as String;
                              });
                            },
                          ),
                        ),
                        SizedBox(width: 10),
                        Expanded(
                          //Drop down for category
                          child: DropdownButtonFormField(
                            validator: (value) {
                              //If not filled return error
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
                        //Prority text field
                      ],
                    ),
                    SizedBox(height: MediaQuery.of(context).size.height * 0.03),
                    //submit button
                    BlocListener<WorkItemCubit, WorkItemState>(
                      listener: (context, state) {
                        if (state is WorkItemCreated) {
                          ScaffoldMessenger.of(context).showSnackBar(
                            const SnackBar(
                              content: Text('Work Item Created'),
                            ),
                          );
                        }
                        if (state is WorkItemFailure) {
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
                            if (_workItemFormKey.currentState!.validate()) {
                              log.e('The form is valid');

                              //create a work item object
                              WorkItemCreate workItem = WorkItemCreate(
                                title: _titleController.text,
                                description: _descriptionController.text,
                                priority: _priorityController.text,
                                category: _categoryController.text,
                                creatorUserId: await SharedPreferencesManager()
                                    .getUserId(),
                                assetId: _assetIdConroller.text,
                              );
                              log.d(
                                  'The create work item to be submitted is ${workItem.toJson()}');
                              WorkItemCubit().createWorkItem(workItem);
                            }
                          },
                          style: AppResources().buttonStyles.buttonStyle(
                                backgroundColor: const Color(0xFF1573FE),
                              ),
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
