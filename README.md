##.NET Core 7 DataGridView CRUD Application with Login
This is a simple CRUD (Create, Read, Update, Delete) application built using .NET Core 7 and Microsoft SQL Server. The application requires users to login before they can view, create, update, or delete data in the DataGridView.

##Features
- Login form to authenticate users
- DataGridView control to display data from a SQL Server database
- Create, Read, Update, and Delete functionality for data in the DataGridView
- Error handling for database exceptions

##Technologies Used
- .NET Core 7
- Microsoft SQL Server
- C#
- Windows Forms

##Getting Started
To get started with the application, follow these steps:

##Clone this repository to your local machine.
1. Open the solution file in Visual Studio.
2. Open the appsettings.json file and update the ConnectionStrings section with your SQL Server connection details.
3. Open the DatabaseInitializer.cs file and update the CreateUser method with your desired login credentials.
4. Build and run the application.

##Usage
When you launch the application, you will be presented with a login form. Enter your username and password, then click the "Login" button.

If your login credentials are valid, you will be taken to the main form which displays the data in the DataGridView control. You can use the navigation buttons to move through the records, and you can use the "Create", "Update", and "Delete" buttons to modify the data.

##Create
To create a new record, click the "Create" button. This will open a new form where you can enter the details for the new record. Once you have entered the details, click the "Save" button to add the new record to the database. If there are any validation errors, they will be displayed on the form.

##Update
To update an existing record, select the record in the DataGridView and click the "Update" button. This will open a new form with the details of the selected record. Modify the details as desired, then click the "Save" button to update the record in the database. If there are any validation errors, they will be displayed on the form.

##Delete
To delete a record, select the record in the DataGridView and click the "Delete" button. You will be prompted to confirm that you want to delete the record. Click "Yes" to delete the record, or "No" to cancel the operation.

##License
This project is licensed under the MIT License. See the LICENSE file for details.

Acknowledgments
This project was inspired by: Cabal Private Server Online
