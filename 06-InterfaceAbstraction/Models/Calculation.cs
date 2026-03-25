using _06_InterfaceAbstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InterfaceAbstraction.Models
{
    public class Calculation : ICalculation
    {
        public double Numb1 { get ; set ; }
        public double Numb2 { get ; set ; }
        public char Operation { get; set; }

        public void Calculate()
        {
            switch (Operation)
            {
                case '+':
                    Console.WriteLine(Numb1 + Numb2); 
                    break;

                case '-':
                    Console.WriteLine(Numb1 - Numb2);
                    break;

                case '*':
                    Console.WriteLine(Numb1 * Numb2);
                    break;

                case '/':
                    Console.WriteLine(Numb1 / Numb2);
                    break;

                default:
                    Console.WriteLine("Yanlis emeliyyat!");
                    break;
            }
        }
    }
}
