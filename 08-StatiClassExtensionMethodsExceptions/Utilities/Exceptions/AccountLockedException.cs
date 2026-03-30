

namespace _08_StatiClassExtensionMethodsExceptions.Utilities.Exceptions
{
    public class AccountLockedException : Exception
    {
        public AccountLockedException()
        {
            
        }
        public AccountLockedException(string message) : base(message) 
        {
            
        }
    }
}
