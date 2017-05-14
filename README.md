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

&nbsp;
## 08 Initialize the LastUsed value
* Initialize the excuse’s LastUsed value in the form’s constructor.

&nbsp;
## 09 Add the save button click code
* Add a saveFileDialog.
* Show the Save As file dialog box when the save button is clicked.
* Check that the description and result inputs are filled.
* Configure the save file folder, filter and name.
* If the dialog result is ok, save the currentExcuse and update the form.
* Now a save file can be written but the description and result lines in the file are blank. Changed event handlers for the three inputs need to be added to have that fixed.

&nbsp;
## 10 Add event handlers for the inputs
* Add the code for the TextChanged event for the description input.
* Add the code for the TextChanged event for the results input.
* Add the code for the ValueChanged event for the lastUsed input.
* When any event handler is triggered, that means the excuse has changed, so first we update the Excuse instance and then we call UpdateForm(), add the asterisk to the form’s title bar, and set Changed to true.
* Passing true to UpdateForm() tells it to just mark the form as changed, but not update the input controls.
* Now clicking the save button properly saves the changes in the input fields.
