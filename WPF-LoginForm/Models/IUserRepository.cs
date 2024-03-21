using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginForm.Models
{
    public interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential); // Validates user credentials
        void Add(UserModel userModel); // Adds a new user
        void Edit(UserModel userModel); // Edits an existing user
        void Remove(int id); // Removes a user by ID
        UserModel GetById(int id); // Retrieves a user by ID
        UserModel GetByUsername(string username); // Retrieves a user by username
        IEnumerable<UserModel> GetByAll(); // Retrieves all users
    }
}
