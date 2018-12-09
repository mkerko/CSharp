using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_5.domain
{
    public class TaxiStation
    {
        private readonly List<Vehicle> _vehicles = new List<Vehicle>();

        public List<Vehicle> Vehicles
        {
            get { return _vehicles; }
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }

        public double CalculateCostSum()
        {
            return _vehicles.Sum(item => item.Cost);
        }

        public List<Vehicle> SortedByMilesPerGallon()
        {
            return _vehicles.OrderBy(item => item.MilesPerGallon).ToList();
        }

        public List<Vehicle> FindByCostRange(int min, int max)
        {
            return _vehicles.Where(item => item.Cost >= min && item.Cost <= max).ToList();
        }
        
        public static void PrintList(IEnumerable<Vehicle> vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }
    }
}