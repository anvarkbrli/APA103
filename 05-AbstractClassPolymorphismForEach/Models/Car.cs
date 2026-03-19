using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AbstractClassPolymorphismForEach.Models
{
    public class Car : Vehicle
    {
        public int DoorsCount { get; set; }
        public int TrunkCapacity { get; set; }
        public bool isAutomatic { get; set; }
        public int MaxSpeed { get; set; }

        public Car(string brand, string model,  int year, string plateNumber, int doorsCount, int trunk, bool isAuto, int maxSpeed, double fuelLevel = 100) : base(brand, model, year, plateNumber)
        {
            this.DoorsCount = doorsCount;
            this.TrunkCapacity = trunk;
            this.isAutomatic = isAuto;
            this.MaxSpeed = maxSpeed;
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Marka: {Brand}, Model: {Model}, Il: {Year}, Qeydiyyat nomresi: {PlateNumber}, Qapi Sayi: {DoorsCount}, Baqaj tutumu: {TrunkCapacity}, Avtomat süret qutusu: {isAutomatic}, Maksimum süret: {MaxSpeed}");
        }

        public double CalculateFuelCost(double distance)
        {
            double result = (distance / 100) * 8 * 1.5;
            return result;
        }

    }
}
