## CRUD Operations using DataGridView in .NET Core 7 with Microsoft SQL Server
This application demonstrates how to perform CRUD (Create, Read, Update, Delete) operations using a DataGridView control in a .NET Core 7 application with Microsoft SQL Server.

## Requirements
- .NET Core 7 SDK
- Microsoft SQL Server
- Visual Studio or any text editor of your choice

## Setup
1. Clone this repository or download the source code as a zip file and extract it to a directory of your choice.
2. Open the project in Visual Studio or any text editor of your choice.
3. In the Solution Explorer, open the appsettings.json file and replace the YOUR_CONNECTION_STRING_HERE placeholder with your own connection string to your SQL Server database.
4. Open the Package Manager Console and run the following command to create the database tables:

## Usage
- When you launch the application, you will be presented with a login form. Enter your username and password, then click the "Login" button.
- If your login credentials are valid, you will be taken to the main form which displays the data in the DataGridView control.
- You can edit the data in the DataGridView directly to update the records in the database.
- To create a new record, simply type in the new values in an empty row at the bottom of the DataGridView and press the Enter key. 
- To delete a record, select the row in the DataGridView that you want to delete and press the Delete key.

## License
This project is licensed under the [MIT License](LICENSE) - see the LICENSE.md file for details.

## Acknowledgments
This project was inspired by: Cabal Private Server Online
