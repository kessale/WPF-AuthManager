using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginForm.Models
{
    public class UserModel
    {
        public string Id { get; set; } // User's unique identifier
        public string Username { get; set; } // User's username
        public string Password { get; set; } // User's password
        public string Name { get; set; } // User's first name
        public string LastName { get; set; } // User's last name
        public string Email { get; set; } // User's email address
    }
}
