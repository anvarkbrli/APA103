using _08_StatiClassExtensionMethodsExceptions.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Models
{
    public class LoginSystem
    {
        private User[] users = new User[3];
        private const int MaxAttempts = 3;
        public User[] Users => users;
        public LoginSystem()
        {
            users[0] = new User("admin", "admin123");
            users[1] = new User("student", "student123");
            users[2] = new User("teacher", "teacher123");
        }

        public void ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new InvalidUsernameException("Istifadeci adi bos buraxila bilmez!");

            }
            else if(username.Length < 3)
            {
                throw new InvalidUsernameException();
            }
        }
    }
}
