import 'package:flutter/material.dart';

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
      child: Center(
          child: Column(
        children: [
          TextField(
            controller: _assetNameController,
            decoration: const InputDecoration(
              border: OutlineInputBorder(),
              labelText: 'Asset Name',
            ),
          ),
          SizedBox(height: 10),
          TextField(
            controller: _titleController,
            decoration: const InputDecoration(
              border: OutlineInputBorder(),
              labelText: 'Title',
            ),
          ),
          SizedBox(height: 10),
          TextField(
            controller: _descriptionController,
            decoration: const InputDecoration(
              border: OutlineInputBorder(),
              labelText: 'Description',
            ),
          ),
          SizedBox(height: 10),
          //Priority and category are dropdowns in the same row
          Row(
            children: [
              Expanded(
                child: TextField(
                  controller: _priorityController,
                  decoration: const InputDecoration(
                    border: OutlineInputBorder(),
                    labelText: 'Priority',
                  ),
                ),
              ),
              SizedBox(width: 10),
              Expanded(
                child: TextField(
                  controller: _categoryController,
                  decoration: const InputDecoration(
                    border: OutlineInputBorder(),
                    labelText: 'Category',
                  ),
                ),
              ),
            ],
          ),
          SizedBox(height: 10),
          //submit button
          ElevatedButton(
            onPressed: () {},
            child: Text('Submit'),
          )
        ],
      )),
    ));
  }
}
