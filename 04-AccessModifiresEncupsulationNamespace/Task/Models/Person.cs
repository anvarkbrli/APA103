using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AccessModifiresEncupsulationNamespace.Models
{
    public class Person
    {
        protected string FullName;
        private int Id;

        public Person(string fullName,int id)
        {
            this.FullName = fullName;
            this.Id = id;   
        }
        public void GetInfo()
        {
            Console.WriteLine($"{FullName}");
            //Console.WriteLine(this.Id); private modifierli deyisen sadece teyin olundugu class daxilinde el catandir
        }
    }
}
