namespace Lab_5.domain
{
    public class Minibus : Vehicle
    {
        public double RentCost { get; set; }

        public bool IsLuggageSpaceAvailable { get; set; }

        public bool IsWiFiAvailable { get; set; }

        public bool IsTvAvailable { get; set; }

        public Minibus(double rentCost, bool isLuggageSpaceAvailable, bool isWiFiAvailable, bool isTvAvailable,
            string brand, int milesPerGallon, int numberOfSeats, int cost) : base(brand, milesPerGallon, numberOfSeats, cost)
        {
            RentCost = rentCost;
            IsLuggageSpaceAvailable = isLuggageSpaceAvailable;
            IsWiFiAvailable = isWiFiAvailable;
            IsTvAvailable = isTvAvailable;
        }

        public override string ToString()
        {
            return string.Format("{0}, RentCost: {1}, IsLuggageSpaceAvailable: {2}, IsWiFiAvailable: {3}, IsTvAvailable: {4}", base.ToString(), RentCost, IsLuggageSpaceAvailable, IsWiFiAvailable, IsTvAvailable);
        }
    }
}