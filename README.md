<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>WPF Login Form Documentation</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 20px;
            background-color: #f0f2f5;
            color: #333;
        }
        h1, h2 {
            color: #026495;
        }
        h2 {
            border-bottom: 2px solid #026495;
            padding-bottom: 6px;
        }
        p, ul, li {
            line-height: 1.6;
        }
        code {
            background-color: #eaeaea;
            padding: 2px 4px;
            font-family: monospace;
        }
        .container {
            max-width: 800px;
            margin: auto;
            background: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 2px 4px rgba(0,0,0,0.1);
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>WPF Login Form Documentation</h1>

        <h2>Overview</h2>
        <p>This project is an educational endeavor, aiming to create a basic login form utilizing the Windows Presentation Foundation (WPF) framework with adherence to the Model-View-ViewModel (MVVM) architectural pattern in C#. It includes functionalities such as user authentication, view navigation, and a basic user management system through a SQL Server database backend. This project serves as a foundation for future development and refinement.</p>

        <h2>Project Structure</h2>
        <h3>Models</h3>
        <ul>
            <li><code>Customer</code>: Basic structure for customer information.</li>
            <li><code>UserModel</code>: Schema for user credentials and personal details.</li>
            <li><code>UserAccountModel</code>: Information related to the user's account.</li>
        </ul>

        <h3>ViewModels</h3>
        <ul>
            <li><code>LoginViewModel</code>: Manages the authentication logic.</li>
            <li><code>MainViewModel</code>: Controls the main application window and navigation.</li>
            <li><code>CustomerViewModel</code>: Handles customer information management.</li>
        </ul>

        <h3>Views</h3>
        <ul>
            <li><code>LoginView</code>: Initial login interface.</li>
            <li><code>MainView</code>: Primary application window post-authentication.</li>
            <li><code>CustomerView</code>: Displays and manages customer information.</li>
        </ul>

        <h3>Repositories</h3>
        <p><code>UserRepository</code>: Implements the <code>IUserRepository</code> interface, offering methods for user authentication and CRUD operations.</p>

        <h3>CustomControls</h3>
        <p><code>BindablePasswordBox</code>: A custom control that supports data binding.</p>

        <h2>Installation & Setup</h2>
        <ol>
            <li>Database Preparation: Establish a SQL Server database named <code>MVVMLoginDb</code> and execute the provided SQL script.</li>
            <li>Environment Configuration: Set <code>DB_USER</code> and <code>DB_PASSWORD</code> environment variables.</li>
            <li>Project Setup: Open the solution in Visual Studio, restore NuGet packages, and build the project.</li>
            <li>Application Launch: Start the application via Visual Studio.</li>
        </ol>

        <h2>Usage</h2>
        <p>Authenticate using the login screen, navigate through the application, and manage customer information via the "Customers" view.</p>

        <h2>Contributing</h2>
        <p>Contributions are welcome. Feel free to fork the repository, make improvements, and submit pull requests.</p>

        <h2>License</h2>
        <p>This project is licensed under the MIT License. See the <code>LICENSE</code> file for more details.</p>
    </div>
</body>
</html>
