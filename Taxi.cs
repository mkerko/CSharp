namespace Lab_5.domain
{
    public class Taxi : Vehicle
    {
        public double Tariff { get; set; }

        public Taxi(double tariff, string brand, int milesPerGallon, int numberOfSeats, int cost) 
            : base(brand, milesPerGallon, numberOfSeats, cost)
        {
            Tariff = tariff;
        }

        public override string ToString()
        {
            return string.Format("{0}, Tariff: {1}", base.ToString(), Tariff);
        }
        
        
    }
}