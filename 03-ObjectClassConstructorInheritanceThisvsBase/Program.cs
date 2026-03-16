using _03_ObjectClassConstructorInheritanceThisvsBase.Models;
namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student FirstStudent = new("Camal", "Qubadli", 19, "qubadlicam@hotmail.com", 101, "APA011", "ITT", 88.5, 2);
            Student SecondStudent = new("Elbrus", "Sahverdiyev", 20, "sahverdiyevelbrus@gmail.com", 111, "APA018", "IKT", 92.0, 3);
            Student ThirdStudent = new("Camal", "Qubadli", 19, "qubadlicam@hotmail.com", 158, "APA011", "ITT", 68.5, 3);

            Teacher FirstTeacher = new("Fizuli", "Abbaszade", 67, "abaszadafuzuli@gmail.com", 519, "Muhendis Riyaziyyati", "Analtik Hendese", 1150, 15);
            Teacher SecondTeacher = new("Firudin", "Mikayillli", 58, "Firudinteach@hotmail.com", 592, "Humanitar Fennler", "Mulki Mudafie", 1050, 8);

            Administrator admin = new("Bilal", "Tuncayzade", 30, "tuncayzadeh091@gmail.com", 1192, "Dekan", "IKT", 4);

            //Telebeler hissesi
            FirstStudent.ShowStudentInfo();
            Console.WriteLine("Teqaud: " + FirstStudent.CalculateScholarship() + " AZN");

            SecondStudent.ShowStudentInfo();
            Console.WriteLine("Teqaud: " + SecondStudent.CalculateScholarship() + " AZN"); 

            ThirdStudent.ShowStudentInfo();
            Console.WriteLine("Teqaud: " + ThirdStudent.CalculateScholarship() + " AZN");

            //Muellimler hissesi
            FirstTeacher.ShowTeacherInfo();
            Console.WriteLine("Maas: " + FirstTeacher.CalculateSalary() + "AZN");

            SecondTeacher.ShowTeacherInfo();
            Console.WriteLine("Maas: " + SecondTeacher.CalculateSalary() + "AZN");

            //Admin hissesi
            admin.ShowAdminInfo();
            admin.GrantAccess(SecondStudent);

            int totalScholarship = FirstStudent.CalculateScholarship() + SecondStudent.CalculateScholarship() + ThirdStudent.CalculateScholarship();
            Console.WriteLine("Umumi teqaud xerci: " + totalScholarship );

            decimal totalSalary = FirstTeacher.CalculateSalary() + SecondTeacher.CalculateSalary();
            Console.WriteLine("umumi maas xerci: " + totalSalary );


        }
    }
}
