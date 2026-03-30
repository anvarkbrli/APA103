using _08_StatiClassExtensionMethodsExceptions.Models;
using _08_StatiClassExtensionMethodsExceptions.Utilities.Exceptions;


namespace _08_StatiClassExtensionMethodsExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LoginSystem loginSystem = new LoginSystem();

            while (true)
            {
                Console.WriteLine("Username daxil edin:");
                string username = Console.ReadLine();

                Console.WriteLine("Sifreni daxil edin:");
                string password = Console.ReadLine();

                try
                {
                    bool result = loginSystem.Login(username, password);

                    if (result)
                        break;
                }
                catch (InvalidUsernameException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }
                catch (InvalidPasswordException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }
                catch (UserNotFoundException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);

                    Console.WriteLine("Sistemde olan istifadeciler:");
                    foreach (var item in loginSystem.Users)
                    {
                        Console.WriteLine(item.Username);
                    }
                }
                catch (IncorrectPasswordException ex)
                {
                    Console.WriteLine("WARNING: " + ex.Message);
                }
                catch (AccountLockedException ex)
                {
                    Console.WriteLine("CRITICAL: " + ex.Message + " contact admin");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("UNEXPECTED ERROR: " + ex.Message);
                }
            }
        }
    }
}
