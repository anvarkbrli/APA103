using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ObjectClassConstructorInheritanceThisvsBase.Models
{
    internal class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Email;
        public int Id;

        public Person(string firstname, string lastname, int age, string email, int id)
        {
            this.FirstName = firstname;
            this.LastName = lastname;   
            this.Age = age;
            this.Email = email;
            this.Id = id;   
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName} ";
        }

        public string ShowTeacherInfo()
        {
            return $"Ad: {FirstName} Soyad: {LastName} Yas: {Age} Email: {Email} Id: {Id} ";
        }
    }
}
