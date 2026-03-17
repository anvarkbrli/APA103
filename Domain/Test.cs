using _04_AccessModifiresEncupsulationNamespace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{   //Bu hisse protectedi gostermek ucundur. Ferqli assembly daxilindeki miras almis class protected modifierli deyiseni gore bildiyi halda miras almayan gore bilmir.
    //public class Test : Person
    public class Test
    {
        //public Test(string FullName):base(FullName)
        //{
                
        //}

        public static void Check()
        {
            Person person = new Person("");
            
        }
    }
}
