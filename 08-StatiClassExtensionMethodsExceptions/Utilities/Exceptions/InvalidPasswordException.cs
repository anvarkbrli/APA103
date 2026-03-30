

namespace _08_StatiClassExtensionMethodsExceptions.Utilities.Exceptions
{
    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException()
        {
            
        }
        public InvalidPasswordException(string message) : base(message)
        {
           
        }
    }
}
