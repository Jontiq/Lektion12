using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion12
{
    internal class User
    {
        //Properties

        public string Username { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }


        //Constructor

        public User (string Username, string Email, string Password)
        {
            this.Username = Username;
            this.Email = Email;
            this.Password = Password;
        }

        //Methods

        public bool Login(string username, string password)
        {
            if (Username == username && Password == password)
            {
                Console.WriteLine("Login successful");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid username or password");
                return false;
            }
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (Password == oldPassword)
            {
                Console.WriteLine("Password has been changed successfully");
                Password = newPassword;
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect old password");
                return false;
            }
        }
    }
}
