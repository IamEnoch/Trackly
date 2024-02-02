import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';
import 'package:trackly_app/Logging/logger.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_cubit.dart';
import 'package:trackly_app/src/bloc/app_functionality/assets/assets_state.dart';
import 'package:trackly_app/src/bloc/app_functionality/workItems/work_item_state.dart';
import 'package:trackly_app/src/bloc/app_functionality/workItems/workt_item_cubit.dart';
import 'package:trackly_app/src/data/localstorage/shared_reference_manager.dart';
import 'package:trackly_app/src/data/models/Assets/asset.dart';
import 'package:trackly_app/src/data/models/work_item.dart';
import 'package:trackly_app/src/utils/all_constants_imports.dart';
import 'package:trackly_app/src/utils/app_resources.dart';

class EditAssetPage extends StatefulWidget {
  const EditAssetPage({super.key});

  @override
  State<EditAssetPage> createState() => _WorkItemPageState();
}

class _WorkItemPageState extends State<EditAssetPage> {
  final log = logger(_WorkItemPageState);

  //text controllers for five fields
  final TextEditingController _assetNameController = TextEditingController();
  final TextEditingController _descriptionController = TextEditingController();
  final TextEditingController _titleController = TextEditingController();
  final TextEditingController _priorityController = TextEditingController();
  final TextEditingController _categoryController = TextEditingController();

  //Values to be submitter from the form
  String? _assetName;
  String? _assetId;
  String? _description;
  String? _title;
  String? _priority;
  String? _category;
  String? _creatorUserId;

  //Check if the form is valid
  bool _isFormValid() {
    return _assetName != null &&
        _description != null &&
        _title != null &&
        _priority != null &&
        _category != null;
  }

  //Dispose of the controllers when the widget is disposed
  @override
  void dispose() {
    _assetNameController.dispose();
    _descriptionController.dispose();
    _titleController.dispose();
    _priorityController.dispose();
    _categoryController.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    final arguments =
        ModalRoute.of(context)?.settings.arguments as Map<String, dynamic>;

    //get asset from arguements and set the texts in the text controllers
    Asset myAsset = arguments['asset'] as Asset;
    _assetNameController.text = myAsset.assetName;

    return Scaffold(
      body: BlocListener<AssetCubit, AssetState>(
        listener: (context, state) {
          //Fill the asset name is the asset is fetched
          if (state is AssetFetched) {
            _assetNameController.text = state.asset.assetName;
            _assetName = _assetNameController.text;
            _assetId = state.asset.assetId;
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
                      'Edit Asset',
                      style: AppResources().appStyles.textStyles.headineH3,
                    ),
                    SizedBox(height: MediaQuery.of(context).size.height * 0.05),
                    TextField(
                      //vertical text field,
                      maxLines: null,
                      controller: _assetNameController,
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
                    SizedBox(height: MediaQuery.of(context).size.height * 0.03),
                    TextField(
                      controller: _titleController,
                      decoration:
                          AppResources().textFieldStyles.inputDecoration(
                                labelText: 'Title',
                              ),
                      onChanged: (value) => _title = value,
                    ),
                    SizedBox(height: MediaQuery.of(context).size.height * 0.03),
                    TextField(
                      //vertical scrollable text field
                      maxLines: null,
                      controller: _descriptionController,
                      decoration:
                          AppResources().textFieldStyles.inputDecoration(
                                labelText: 'Description',
                              ),
                      onChanged: (value) => _description = value,
                    ),
                    SizedBox(height: MediaQuery.of(context).size.height * 0.03),
                    //Priority and category are dropdowns in the same row
                    Row(
                      children: [
                        Expanded(
                          //Drop down for priority
                          child: DropdownButtonFormField(
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
                                _priority = value as String;
                              });
                            },
                          ),
                        ),
                        SizedBox(width: 10),
                        Expanded(
                          //Drop down for category
                          child: DropdownButtonFormField(
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
                                _category = value as String;
                              });
                            },
                          ),
                        ),
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
                            if (_isFormValid()) {
                              log.e('The form is valid');

                              //TODO: Submit the form
                              //use cubit to submit the form
                              //create a work item object
                              final workItem = WorkItem(
                                title: _title!,
                                description: _description!,
                                priority: _priority!,
                                category: _category!,
                                assetId: _assetId!,
                                creatorUserId: await SharedPreferencesManager()
                                    .getUserId(),
                              );
                              log.d(
                                  'The create work item to be submitted is ${workItem.toJson()}');
                              context
                                  .read<WorkItemCubit>()
                                  .createWorkItem(workItem);
                            } else {
                              log.e('The form is not valid');
                            }
                          },
                          child: const Text('Submit'),
                          style: AppResources().buttonStyles.buttonStyle(
                                backgroundColor: Color(0xFF1573FE),
                              ),
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
