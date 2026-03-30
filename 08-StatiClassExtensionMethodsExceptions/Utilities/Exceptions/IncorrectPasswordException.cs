
namespace _08_StatiClassExtensionMethodsExceptions.Utilities.Exceptions
{
    public class IncorrectPasswordException : Exception
    {
        public int AttemptsLeft { get; set; }

        public IncorrectPasswordException(int attemptLeft)
        {
            AttemptsLeft = attemptLeft;
            Console.WriteLine($"Daxil etdiyiniz sifre yanlisdir. Qalan yoxlama haqqiniz: {AttemptsLeft}");
        }
    }
}
