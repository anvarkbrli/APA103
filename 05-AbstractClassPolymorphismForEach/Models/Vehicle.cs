using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AbstractClassPolymorphismForEach.Models
{
    public class Vehicle
    {
       
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string PlateNumber { get; set; }
        public double FuelLevel { get; set; }

        protected Vehicle(string brand, string model, int year, string plateNumber, double fuelLevel = 100)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.PlateNumber = plateNumber;
            this.FuelLevel = fuelLevel;

        }
        protected Vehicle(string brand, string model, int year)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;

        }
       

        public string GetVehicleInfo()
        {
            return $"Marka: {Brand}, Model: {Model}, Il: {Year}, Qeydiyyat nomresi: {PlateNumber}, Yanacaq seviyyesi: {FuelLevel}";
        }

        public void ShowBasicInfo()
        {
            Console.WriteLine($"Marka: {Brand}, Model: {Model}, Il: {Year}");
        }
    }
}
