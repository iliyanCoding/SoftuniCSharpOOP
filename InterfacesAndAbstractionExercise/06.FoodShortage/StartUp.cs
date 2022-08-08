using System;
using System.Collections.Generic;

namespace _06.FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBuyer> buyerList = new List<IBuyer>();
            List<Citizen> citizenList = new List<Citizen>();
            List<Rebel> rebelList = new List<Rebel>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(' ');
                if (info.Length == 4)
                {
                    IBuyer citizen = new Citizen(info[0], info[1], info[2], info[3]);
                    Citizen citizen1 = new Citizen(info[0], info[1], info[2], info[3]);
                    buyerList.Add(citizen);
                    citizenList.Add(citizen1);
                }
                else if (info.Length == 3)
                {
                    IBuyer rebel = new Rebel(info[0], info[1], info[2]);
                    Rebel rebel1 = new Rebel(info[0], info[1], info[2]);
                    buyerList.Add(rebel);
                    rebelList.Add(rebel1);
                }
            }

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "End")
                {
                    break;
                }
                else
                {
                    if (!citizenList.Exists(x => x.Name == name))
                    {

                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
