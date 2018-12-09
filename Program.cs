using System;
using Lab_5.domain;

namespace Lab_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var opel = new Taxi(3.5, "Opel", 14, 6, 5600);
            var mazda = new Taxi(2.5, "Mazda", 16, 4, 6700);
            var renault = new Taxi(1.5, "Renault", 15, 4, 9800);
            var vw = new Taxi(3.5, "VW", 9, 10, 7600);
            
            var mercedes = new Minibus(25.5, false, true, false, "MB", 7, 16, 9600);
            var renalut = new Minibus(15.5, false, true, false, "Renault", 8, 18, 10600);
            var fiat = new Minibus(25.5, false, true, false, "Fiat", 9, 16, 12600);
            
            var station = new TaxiStation();
            station.AddVehicle(opel);
            station.AddVehicle(mazda);
            station.AddVehicle(renault);
            station.AddVehicle(vw);
            station.AddVehicle(renalut);
            station.AddVehicle(mercedes);
            station.AddVehicle(fiat);

            Console.WriteLine("Sum = " + station.CalculateCostSum());
            Console.WriteLine("Cost range = ");
            TaxiStation.PrintList(station.FindByCostRange(7000, 10000));
            Console.WriteLine("Sorted by consumption = ");
            TaxiStation.PrintList(station.SortedByMilesPerGallon());
        }
    }
}