using _05_AbstractClassPolymorphismForEach.Models;
namespace _05_AbstractClassPolymorphismForEach

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Car car1 = new("Mercedes" ,"E200", 2023, "10-AA-001", 4, 500, true, 220);
            Car car2 = new("BMW" ,"320I", 2022, "10-AA-002", 4 , 480 , true, 235);
            Car car3 = new("Toyota" , "Camry", 2021, "10-AA-003", 4, 524 , true, 210);
            //2
            Motorcycle moto1 = new("Yamaha", "R1", 2023, "10-MC-002", 998, "Sport", false, 299);
            Motorcycle moto2 = new("Harley-Davidson", "Street Glide", 2022, "10-MC-001", 1868, "Cruieser", true, 180);
            //3
            Truck truck1 = new("MAN", "TGX", 2020, "27-FA-09", 18, 3, 12, 120);
            Truck truck2 = new("Volvo", "FH16", 2021, "27-FA-19", 25, 4, 18, 110);
            //4
            car1.ShowCarInfo();
            Console.WriteLine(car1.CalculateFuelCost(500));

            car2.ShowCarInfo();
            Console.WriteLine(car2.CalculateFuelCost(500));

            car3.ShowCarInfo();
            Console.WriteLine(car3.CalculateFuelCost(500));

            moto1.ShowMotorcycleInfo();
            Console.WriteLine(moto1.CalculateFuelCost(300));
            
            moto2.ShowMotorcycleInfo();
            Console.WriteLine(moto2.CalculateFuelCost(300));

            truck1.ShowTruckInfo();
            Console.WriteLine(truck1.CalculateFuelCost(800));
            
            truck2.ShowTruckInfo();
            Console.WriteLine(truck2.CalculateFuelCost(800));
            //5
            truck1.LoadCargo(5);
            Console.WriteLine(truck1.CalculateFuelCost(800));
            //6
            int total = 7;

            double avgSpeed = (car1.MaxSpeed + car2.MaxSpeed + car3.MaxSpeed + moto1.MaxSpeed + moto2.MaxSpeed + truck1.MaxSpeed + truck2.MaxSpeed) / total;

            Console.WriteLine($"Orta maksimum suret: {avgSpeed}");
            List<Vehicle> vehicles = new List<Vehicle>()
            {
                car1, car2, car3, moto1, moto2, truck1, truck2
            };

            double maxCost = 0;
            Vehicle expensiveVehicle = null;

            foreach (var v in vehicles)
            {
                double cost = 0;

                if (v is Car car)
                    cost = car.CalculateFuelCost(500);
                else if (v is Motorcycle moto)
                    cost = moto.CalculateFuelCost(300);
                else if (v is Truck truck)
                    cost = truck.CalculateFuelCost(800);

                if (cost > maxCost)
                {
                    maxCost = cost;
                    expensiveVehicle = v;
                }
            }

            Console.WriteLine($"En bahali yanacaq xerci: {maxCost}");

        }
    }
}
