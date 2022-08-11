using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles
{
    public class Car : Vehicle
    {
        private const double CarFuelConsumptionIncreasement = 0.9;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption + CarFuelConsumptionIncreasement, tankCapacity)
        {
        }

        public override void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }

    }
}
