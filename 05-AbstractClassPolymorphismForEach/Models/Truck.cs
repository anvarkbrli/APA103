using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AbstractClassPolymorphismForEach.Models
{
    internal class Truck : Vehicle
    {
        public double CargoCapacity { get; set; }
        public int AxleCount { get; set; }
        public double CurrentLoad { get; set; }
        public int MaxSpeed { get; set; }

        public Truck(string brand, string model, int year, string plateNumber, double cargo, int axleCount,double currentLoad, int maxSpeed) : base( brand,  model,  year,  plateNumber)
        {
            double CargoCapacity = cargo;
            int AxleCount = axleCount;
            double CurrentLoad = currentLoad;
            int MaxSpeed = maxSpeed; 
        }

        public void ShowTruckInfo()
        {
            Console.WriteLine($"Marka: {Brand}, Model: {Model}, Il: {Year}, Qeydiyyat nomresi: {PlateNumber}, Yuk tutumu: {CargoCapacity}, Ox sayi: {AxleCount}, Maksimum suret: {MaxSpeed}");
        }

        public void LoadCargo(double weight)
        {
            CurrentLoad += weight;
            if(CurrentLoad > CargoCapacity)
            {
                Console.WriteLine("Yuk cox agirdir!");
            }
            else 
            {
                Console.WriteLine("Yuk dasina biler!");
                Console.WriteLine($"Cari yuk: {CurrentLoad}");
            }
        }

        public double CalculateFuelCost(double distance)
        {
            double result = (distance / 100) * (25 + CurrentLoad * 2) * 1.8;
            return result;
        }


    }
}
