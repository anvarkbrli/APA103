using _09_UpcastingDowncastingExplicitImplicit.Exchange;
using _09_UpcastingDowncastingExplicitImplicit.Models;

namespace _09_UpcastingDowncastingExplicitImplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Upcasting--Downcasting
            Dog dog = new Dog{AvgLifeTime = 15, Gender = "Male", Name = "Aberdin", Breed = "Kanqal" };
            Eagle eagle = new Eagle { AvgLifeTime = 10, Gender = "Female", FlySpeed = 70 };

            ////Upcasting implicit
            //Animal animal = dog;
            //Animal animal1 = eagle;

            ////Downcasting explicit 
            //Dog dog1 = (Dog)animal;
            //Eagle eagle1 = (Eagle)animal1;

            Animal[] animals = {dog, eagle};
            foreach (var animal in animals)
            {
                Eagle eagle1 = animal as Eagle;
                //eagle1.Fly();

                //if(eagle1 != null)
                //{
                //    eagle1.Fly();
                //}

                if (animal is Eagle)
                {
                    Eagle eagle2 = (Eagle)animal;
                }
            }
            #endregion

            #region Boxing--Unboxing
            //Boxing
            int a = 4;
            Object b = a;

            //Unboxing
            string c = b as string;

            Test test = new Test();
            ITest Itest = test;
            #endregion

            Dollar dollar = new(200);
            Console.WriteLine(dollar.USD);

            Manat manat = new(170);
            Console.WriteLine(manat.AZN);

            Dollar dollar1 = manat;
            Console.WriteLine(dollar.USD);

            Manat manat1 = dollar;
            Console.WriteLine(manat1.AZN);
        }
        public struct Test : ITest
        {
            public int X { get; set; }
            public void Y()
            {
                throw new NotImplementedException();
            }
        }
        public interface ITest
        {
            void Y();
        }

    }
}
