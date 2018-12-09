using System;

namespace Lab_5.domain
{
    public abstract class Vehicle
    {
        protected Vehicle(string brand, int milesPerGallon, int numberOfSeats, int cost)
        {
            Brand = brand;
            MilesPerGallon = milesPerGallon;
            NumberOfSeats = numberOfSeats;
            Cost = cost;
        }

        public string Brand { get; set; }

        public int MilesPerGallon { get; set; }

        public int NumberOfSeats { get; set; }

        public int Cost { get; set; }

        private static void PrintErrorMessage(string field)
        {
            Console.WriteLine("Unable to set up field " + field);
        }

        public override string ToString()
        {
            return string.Format("Brand: {0}, MilesPerGallon: {1}, NumberOfSeats: {2}, Cost: {3}", Brand, MilesPerGallon, NumberOfSeats, Cost);
        }
    }
}