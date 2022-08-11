using System;

namespace _01.Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(' ');
            if (double.Parse(carInfo[1]) > double.Parse(carInfo[3]))
            {
                carInfo[3] = "0";
            }
            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

            string[] truckInfo = Console.ReadLine().Split(' ');
            if (double.Parse(truckInfo[1]) > double.Parse(truckInfo[3]))
            {
                truckInfo[3] = "0";
            }
            Truck truck = new Truck(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

            int numOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0] == "Drive")
                {
                    if (command[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(double.Parse(command[2])));
                    }
                    else if (command[1] == "Truck")
                    {
                        Console.WriteLine(truck.Drive(double.Parse(command[2])));
                    }
                }
                else if (command[0] == "Refuel")
                {
                    if (command[1] == "Car")
                    {
                        car.Refuel(double.Parse(command[2]));
                    }
                    else if (command[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(command[2]));
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
