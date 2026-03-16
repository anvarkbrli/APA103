using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ObjectClassConstructorInheritanceThisvsBase.Models
{
    internal class Teacher:Person
    {
        public string Department;
        public string MainSubject;
        public decimal BaseSalary;
        public int ExperienceYears;

        public Teacher(string FirstName, string LastName, int Age, string Email, int Id, 
            string department, string mainSubject, decimal baseSalary, int expYears): base(FirstName, LastName, Age, Email, Id)
        {
            this.Department = department;
            this.MainSubject = mainSubject;
            this.BaseSalary = baseSalary;
            this.ExperienceYears = expYears;
        }
         
        public void ShowTeacherInfo()
        {
            Console.WriteLine($"Ad: {FirstName} Soyad: {LastName} Yas: {Age} Email: {Email} Id: {Id}, Kafedra: {Department}, Esas Fenn: {MainSubject}, Tecrube ili: {ExperienceYears} ");
        }
        public decimal CalculateSalary()
        {
            decimal salary = BaseSalary + (ExperienceYears * 50);
            return salary;
        }


    }
}
