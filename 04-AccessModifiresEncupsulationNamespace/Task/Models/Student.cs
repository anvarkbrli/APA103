using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AccessModifiresEncupsulationNamespace.Models
{
    public class Student: Person
    {
        public string Faculty;

        public Student(string FullName, string faculty,int id):base(FullName,id) 
        {
            string Faculty = faculty;

            //Console.WriteLine(this.id); id private oldugu ucun cagirila bilmir
            //Console.WriteLine(this.FullName);
            // protected modifierli FullName deyiseni hem eyni hem de ferqli assembly daxilindeki sadece miras almayan classlarin daxilinde el catan deyil.
        }
    }
}
