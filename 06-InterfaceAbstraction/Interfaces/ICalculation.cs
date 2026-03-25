using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InterfaceAbstraction.Interfaces
{
    public interface ICalculation
    {
         double Numb1 { get; set; }
         double Numb2 { get; set; }
         char Operation { get; set; }

        void Calculate();
    }
}
