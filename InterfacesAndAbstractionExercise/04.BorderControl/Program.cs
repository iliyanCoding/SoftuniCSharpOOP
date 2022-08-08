using System;
using System.Collections.Generic;

namespace _04.BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthable> identifiers = new List<IBirthable>();

            List<Robot> robots = new List<Robot>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "Citizen")
                {
                    IBirthable citizen = new Citizen(input[4]);
                    identifiers.Add(citizen);
                }
                else if (input[0] == "Robot")
                {
                    Robot robot = new Robot(input[1]);
                    robots.Add(robot);
                }
                else if (input[0] == "Pet")
                {
                    IBirthable pet = new Pet(input[2]);
                    identifiers.Add(pet);
                }
                else if (input[0] == "End")
                {
                    break;
                }
            }

            string birthYear = Console.ReadLine();
            foreach (var identifier in identifiers)
            {
                if (identifier.Birthdate.EndsWith(birthYear))
                {
                    Console.WriteLine(identifier.Birthdate);
                }
            }

 
        }
    }
}
