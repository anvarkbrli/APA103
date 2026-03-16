using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ObjectClassConstructorInheritanceThisvsBase.Models
{
    internal class Student:Person
    {
        public string StudentNumber;
        public string Faculty;
        public double GPA;
        public int Year;

        public Student(string FirstName,string LastName, int Age,string Email, int Id,
            string studentNumber, string facult, double gpa, int year):base(FirstName,LastName,Age,Email,Id)
        {   
            this.StudentNumber = studentNumber;
            this.Faculty = facult;  
            this.GPA = gpa;
            this.Year = year;
        }
        public void ShowStudentInfo()
        {
            Console.WriteLine($"Ad: {FirstName} Soyad: {LastName} Yas: {Age} Email: {Email} Id: {Id} Telebe Nomresi: {StudentNumber} Fakulte: {Faculty} Umumi ortalama: {GPA} Kurs: {Year}");
        }
        public int CalculateScholarship()
        {
            int stipend;
            if(GPA >= 90)
            {
                stipend = 500;
                
            }else if(GPA >= 80)
            {
                stipend = 350;
               
            }else if(GPA >= 70)
            {
                stipend = 200;
            }
            else
            {
                stipend = 0;
            }

            return stipend;
        }
    }

}
