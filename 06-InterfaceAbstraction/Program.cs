using _06_InterfaceAbstraction.Models;

namespace _06_InterfaceAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();

            Console.WriteLine("Ilk ededi daxil edin: ");
            calculation.Numb1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ikinci ededi daxil edin: ");
            calculation.Numb2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Yerine yetirmek istediyiniz emeliyati daxil edin(+, -, *, /): ");
            calculation.Operation = Convert.ToChar(Console.ReadLine());

            calculation.Calculate();


            
        }
    }
}
