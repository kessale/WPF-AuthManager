using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginForm.Models
{
   public class UserAccountModel
    {
        public string Username { get; set; } // User's username
        public string DisplayName { get; set; } // User's display name
        public byte[] ProfilePicture { get; set; } // User's profile picture
    }
}
