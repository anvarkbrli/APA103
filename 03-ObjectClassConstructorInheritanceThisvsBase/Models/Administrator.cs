using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ObjectClassConstructorInheritanceThisvsBase.Models
{
    internal class Administrator:Person
    {
        public string Position;
        public string Department;
        public int AccesLevel;

        public Administrator(string FirstName, string LastName, int Age, string Email, int Id, string position, string department, int accLevel):base(FirstName, LastName, Age, Email, Id)
        {
            string Position = position;
            string Department = department;
            int AccesLevel = accLevel;
            
        }

        public void ShowAdminInfo()
        {
            Console.WriteLine($"Ad: {FirstName} Soyad: {LastName} Yas: {Age} Email: {Email} Id: {Id}, Vezife: {Position}, Kafedra: {Department}, Giris Seviyyesi: {AccesLevel}");
        }

        public void GrantAccess(Student student)
        {
            Console.WriteLine($"{student.GetFullName()} sisteme giris icazesi elde etdi!");
        }
    }
}
