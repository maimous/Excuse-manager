# Excuse Manager
[Head First C#](http://www.headfirstlabs.com/books//hfcsharp/)

&nbsp;
## 00 Start the project
* In VS, create a Windows Forms Application project.

&nbsp;
## 01 Add the form
* Four buttons, three TextBoxes, a DateTimePicker and labels.

&nbsp;
## 02 Add the folder button click code
* Add a folderBrowserDialog.
* Show the folder dialog box with the folder button click.
* If the dialog result is ok, enable the Save, Open and Random buttons.

&nbsp;
## 03 Edit the file date label
* Instead of the third TextBox, the file date for the excuse file is displayed by the use of a Label control with AutoSize set to False and BorderStyle set to Fixed3D.

&nbsp;
## 04 Add the Excuse class
* Add the Excuse class and its properties.

&nbsp;
## 05 Add the Excuse class constructors
* The Excuse class has three overloaded constructors: one for when the form’s first loaded, one for opening up a file, and one for a random excuse.
* Add the OpenFile method which is called by the constructors to open an excuse.    
* Use a `using` statement so that our files will always be closed.

&nbsp;
## 06 Add the Save method in the Excuse class
* Add the Save method in the Excuse class.
* Use a `using` statement so that our files will always be closed.

&nbsp;
## 07 Add the UpdateForm method in the Form
* Add the UpdateForm method in the Form.
* The currentExcuse instance of the Excuse class is being stored in the form.
* The `changed` parameter indicates whether or not the form has changed. The `formChanged` field in the form keeps track of this status.
