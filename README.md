# WPF Login Form Documentation

## Overview

This project is an educational endeavor, aiming to create a basic login form utilizing the Windows Presentation Foundation (WPF) framework with adherence to the Model-View-ViewModel (MVVM) architectural pattern in C#. It includes functionalities such as user authentication, view navigation, and a basic user management system through a SQL Server database backend. This project serves as a foundation for future development and refinement.

## Project Structure

### Models

- `Customer`: Defines the basic structure for customer information.
- `UserModel`: Outlines the schema for storing user credentials and personal details.
- `UserAccountModel`: Stores information related to the user's account.

### ViewModels

- `LoginViewModel`: Manages the authentication logic.
- `MainViewModel`: Controls the main application window and navigation between different views.
- `CustomerViewModel`: Handles operations related to customer information management.

### Views

- `LoginView`: The initial login interface.
- `MainView`: The primary application window accessible post-authentication.
- `CustomerView`: Displays and manages customer information.

### Repositories

- `UserRepository`: Implements the `IUserRepository` interface, offering methods for user authentication and CRUD (Create, Read, Update, Delete) operations.

### CustomControls

- `BindablePasswordBox`: A custom control that extends the functionality of the standard WPF PasswordBox to support data binding.

## Installation & Setup

1. Database Preparation: Establish a SQL Server database named `MVVMLoginDb` and execute the supplied SQL script to construct the necessary tables.
2. Environment Configuration: Configure `DB_USER` and `DB_PASSWORD` environment variables corresponding to your database access credentials.
3. Project Setup: Launch the solution in Visual Studio, ensuring all NuGet packages are restored correctly, then build the project.
4. Application Launch: Initiate the application via Visual Studio by pressing `F5` or clicking the "Start" button.

## Usage

Authenticate using the login screen, navigate through the application, and manage customer information via the "Customers" view.

## Contributing

Contributions are encouraged and welcomed. Feel free to fork the repository for bug fixes, enhancements, or feature additions and submit your changes through pull requests.

## License

This project is licensed under the MIT License. See the `LICENSE` file for more details.
