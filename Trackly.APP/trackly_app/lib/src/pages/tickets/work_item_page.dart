import 'package:flutter/material.dart';
import 'package:trackly_app/src/utils/all_constants_imports.dart';
import 'package:trackly_app/src/utils/app_resources.dart';

class WorkItemPage extends StatefulWidget {
  const WorkItemPage({super.key});

  @override
  State<WorkItemPage> createState() => _WorkItemPageState();
}

class _WorkItemPageState extends State<WorkItemPage> {
  //text controllers for five fields
  final TextEditingController _assetNameController = TextEditingController();
  final TextEditingController _descriptionController = TextEditingController();
  final TextEditingController _titleController = TextEditingController();
  final TextEditingController _priorityController = TextEditingController();
  final TextEditingController _categoryController = TextEditingController();

  //Values to be submitter from the form
  String? _assetName;
  String? _description;
  String? _title;
  String? _priority;
  String? _category;

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
    return Scaffold(
      body: SafeArea(
        child: SingleChildScrollView(
          child: Center(
            child: Padding(
              padding: EdgeInsets.all(MediaQuery.of(context).size.width * 0.05),
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
                            onPressed: () {},
                            icon: Image.asset(AppAssets.scanIcon, scale: 2),
                          ),
                        ),
                  ),
                  SizedBox(height: MediaQuery.of(context).size.height * 0.03),
                  TextField(
                    controller: _titleController,
                    decoration: AppResources().textFieldStyles.inputDecoration(
                          labelText: 'Title',
                        ),
                    onChanged: (value) => _title = value,
                  ),
                  SizedBox(height: MediaQuery.of(context).size.height * 0.03),
                  TextField(
                    //vertical scrollable text field
                    maxLines: null,
                    controller: _descriptionController,
                    decoration: AppResources().textFieldStyles.inputDecoration(
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
                              _category = value as String;
                            });
                          },
                        ),
                      ),
                    ],
                  ),
                  SizedBox(height: MediaQuery.of(context).size.height * 0.03),
                  //submit button
                  Center(
                    child: ElevatedButton(
                      onPressed: () {
                        if (_isFormValid()) {
                          //TODO: Submit the form
                        }
                      },
                      child: const Text('Submit'),
                      style: AppResources().buttonStyles.buttonStyle(
                            backgroundColor: Color(0xFF1573FE),
                          ),
                    ),
                  ),
                ],
              ),
            ),
          ),
        ),
      ),
    );
  }
}
