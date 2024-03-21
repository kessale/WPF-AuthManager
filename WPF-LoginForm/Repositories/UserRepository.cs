using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WPF_LoginForm.Models;
using MySql.Data.MySqlClient;

namespace WPF_LoginForm.Repositories
{
    // This class manages user-related data operations against the database
    public class UserRepository : RepositoryBase, IUserRepository
    {
        // Adds a new user to the database
        public void Add(UserModel userModel)
        {
            throw new NotImplementedException(); // Method implementation is pending
        }

        // Authenticates a user by verifying their credentials against the database
        public bool AuthenticateUser(NetworkCredential credential)
        {
            bool validUser; // Indicates whether the user is valid
            using (var connection = GetConnection()) // Establishes a connection to the database
            using (var command = new MySqlCommand()) // Creates a command to execute the SQL query
            {
                connection.Open(); // Opens the connection to the database
                command.Connection = connection; // Sets the connection for the command
                // SQL query to find the user with the given username and password
                command.CommandText = "select * from User where username=@username and password=@password";
                // Adds parameters to prevent SQL injection
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = credential.UserName;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = credential.Password;
                // Executes the command and checks if any user is found
                validUser = command.ExecuteScalar() == null ? false : true;
            }
            return validUser; // Returns true if the user is found, false otherwise
        }

        // Edits an existing user's information in the database
        public void Edit(UserModel userModel)
        {
            throw new NotImplementedException(); // Method implementation is pending
        }

        // Retrieves all users from the database
        public IEnumerable<UserModel> GetByAll()
        {
            throw new NotImplementedException(); // Method implementation is pending
        }

        // Retrieves a user by their ID from the database
        public UserModel GetById(int id)
        {
            throw new NotImplementedException(); // Method implementation is pending
        }

        // Retrieves a user by their username from the database
        public UserModel GetByUsername(string username)
        {
            UserModel user = null; // Initializes the user to null
            using (var connection = GetConnection()) // Establishes a connection to the database
            using (var command = new MySqlCommand()) // Creates a command to execute the SQL query
            {
                connection.Open(); // Opens the connection to the database
                command.Connection = connection; // Sets the connection for the command
                // SQL query to find the user with the given username
                command.CommandText = "select *from User where username=@username";
                // Adds the username parameter to prevent SQL injection
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                using (var reader = command.ExecuteReader()) // Executes the command and creates a reader for the result
                {
                    if (reader.Read()) // Checks if any user is found
                    {
                        // Initializes the user with the data from the database
                        user = new UserModel()
                        {
                            Id = reader[0].ToString(),
                            Username = reader[1].ToString(),
                            Password = string.Empty, // Password is not retrieved for security reasons
                            Name = reader[3].ToString(),
                            LastName = reader[4].ToString(),
                            Email = reader[5].ToString(),
                        };
                    }
                }
            }
            return user; // Returns the found user or null if no user was found
        }

        // Removes a user from the database by their ID
        public void Remove(int id)
        {
            throw new NotImplementedException(); // Method implementation is pending
        }
    }
}
