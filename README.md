WPF Login Form Documentation
Overview
This project is a part of a learning process, designed to implement a basic login form using WPF (Windows Presentation Foundation) with the MVVM (Model-View-ViewModel) design pattern in C#. It includes user authentication, navigation between views, and basic user management (add, edit, remove users) using a SQL Server database. The application is not a complete product but serves as a foundation for further development.

Project Structure
The project is structured following the MVVM pattern, enhancing maintainability, and separating the user interface from the logic. Here’s a breakdown of the main components:

Models: Represents the data structure of the application.

Customer: Basic model for customer information.
UserModel: Defines the structure for user information including username, password, and personal details.
UserAccountModel: Contains user's account details.
ViewModels: Acts as a mediator between the Models and Views, containing the logic for the user interface.

LoginViewModel: Manages the login logic.
MainViewModel: Handles the main window's logic and navigations.
CustomerViewModel: Manages customer-related functionalities.
Views: The user interface of the application.

LoginView: The login screen.
MainView: The main window after login.
CustomerView: Displays customer information.
Repositories: Provides methods to interact with the database.

UserRepository: Implements IUserRepository, providing methods for user authentication and CRUD operations.
CustomControls: Contains customized WPF controls.

BindablePasswordBox: A custom password box that supports data binding.
Installation
Database Setup: Create a SQL Server database named MVVMLoginDb and execute the provided SQL script to create the necessary tables.
Environment Variables: Set the DB_USER and DB_PASSWORD environment variables to your database username and password.
Project Configuration: Open the solution in Visual Studio. Ensure all NuGet packages are restored and build the solution.
Running the Application: Start the application from Visual Studio by pressing F5 or clicking the "Start" button.
Usage
Login: Use the login form to enter the application. The default username and password are provided in the database script.
Main Window: Navigate through the application using the sidebar menu.
Adding Customers: Navigate to the "Customers" view from the sidebar menu and use the "Add" button.
Contributing
This project is open for contributions. Whether you are looking to fix bugs, improve the functionality, or extend the features, your contributions are welcome. Please feel free to fork the repository and submit pull requests.

License
This project is licensed under the MIT License - see the LICENSE file for details.
