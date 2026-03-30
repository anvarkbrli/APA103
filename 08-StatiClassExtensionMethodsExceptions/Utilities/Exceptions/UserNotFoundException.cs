

namespace _08_StatiClassExtensionMethodsExceptions.Utilities.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException()
        {
            
        }
        public UserNotFoundException(string message) : base(message) 
        {
            
        }
    }
}
