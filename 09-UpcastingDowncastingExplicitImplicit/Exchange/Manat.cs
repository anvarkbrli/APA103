using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_UpcastingDowncastingExplicitImplicit.Exchange
{
    internal class Manat
    {
        public double AZN { get; set; }
        public Manat(double Azn)
        {
            AZN = Azn;
        }

        public static implicit operator Manat(Dollar dollar)
        {
            return new Manat(dollar.USD * 1.7m);
        }
    }
}
