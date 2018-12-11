using System;

namespace Lab_7
{
    public abstract class MilitaryShip : IShip
    {
        public string CommonWeapon { get; set; }

        public abstract void ShootWithSpecificWeapon();

        public void Sail()
        {
            Console.WriteLine("Military ship is sailing");
        }

        public void Sink()
        {
            Console.WriteLine("Military ship is sinking!");
        }
    }
}