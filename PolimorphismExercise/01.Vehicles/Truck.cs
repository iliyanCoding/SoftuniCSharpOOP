using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles
{
    public class Truck : Vehicle
    {
        private const double TruckFuelConsumptionIncreasement = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption + TruckFuelConsumptionIncreasement, tankCapacity)
        {
        }

        public override void Refuel(double liters)
        {
            if (this.FuelQuantity + liters > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += 0.95 * liters;
            }
        }
    }
}
