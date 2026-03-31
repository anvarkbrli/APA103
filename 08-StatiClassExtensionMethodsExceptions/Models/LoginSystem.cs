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
            else if (username.Length < 3)
            {
                throw new InvalidUsernameException();

            } 
        }
             public void ValidatePassword(string password)
        {
            int sum = 0;
            foreach (var item in password)
            {

                sum++;
            }

            if (sum == 0 || sum < 6)
            {
                throw new InvalidPasswordException("Parol en az 6 simvoldan ibaret olmalidir");
            }
        }
             
        User FindUser(string username)
        {

            foreach (var item in users)
            {
                if (item.Username.Trim().ToLower() == username.Trim().ToLower())
                {
                    return item;
                }

            }

            throw new UserNotFoundException("Istifadeci tapilmadi");
        }
        public bool Login(string username, string password)
        {
            ValidateUsername(username);
            ValidatePassword(password);
            user = FindUser(username);
            if (user.IsLocked == true)
                throw new AccountLockedException("Hesab bloklanib");

            if (user.Password == password)
            {
                user.FailedAttempts = 0;
                Console.WriteLine($"Login successful!Welcome,{username}!");
                return true;

            }
            else
            {
                user.FailedAttempts++;
                int attemptsLeft = MaxAttempts - user.FailedAttempts;
                if (attemptsLeft > 0)
                    throw new IncorrectPasswordException(MaxAttempts - user.FailedAttempts);
                else
                {
                    user.IsLocked = true;
                    throw new AccountLockedException("Hesab bloklanib");

                }

            }
        }
}
}
