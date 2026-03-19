using _04_AccessModifiresEncupsulationNamespace.Models;

namespace _04_AccessModifiresEncupsulationNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new("Enver Kebirli",  "ITT" , 19);
            //Console.WriteLine( student.FullName);

            ////typeof(Person).GetField("name", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(person, "APA103");
            //var newName = typeof(Person).GetField("name", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(person);

            //Console.WriteLine(newName);

            Car car = new Car();
            car.HoursePower = 50;
            Console.WriteLine(car.HoursePower);
        }
    }
}
