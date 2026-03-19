using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _05_AbstractClassPolymorphismForEach.Models
{
    public class Motorcycle : Vehicle
    {
        public int EngineCapacity { get; set; }
        public bool HasSidecar { get; set; }
        public int MaxSpeed { get; set; }
        public string Type { get; set; }

        public Motorcycle(string brand, string model, int year, string plateNumber, int Engine,string Type, bool HasSide, int maxSpeed ) : base(brand, model, year, plateNumber) 
        {
            this.EngineCapacity = Engine;
            this.HasSidecar = HasSide;
            this.MaxSpeed = maxSpeed;
            this.Type = Type;
        }
        public void ShowMotorcycleInfo()
        {
            Console.WriteLine($"Marka: {Brand}, Model: {Model}, Il: {Year}, Qeydiyyat nomresi: {PlateNumber}, Muherrik hecmi: {EngineCapacity},Nov: {Type}, Elave oturacaq: {HasSidecar}, Maksiumum suret: {MaxSpeed} ");
        }
        public double CalculateFuelCost(double distance)
        {
            double result = (distance / 100) * 4 * 1.5;
            return result;
        }

    }
}
