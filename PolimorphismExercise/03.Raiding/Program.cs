using System;
using System.Collections.Generic;

namespace _03.Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<BaseHero> raidGroup = new List<BaseHero>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                switch (heroType)
                {
                    case "Druid":
                        Druid druid = new Druid(heroName);
                        raidGroup.Add(druid);
                        break;
                    case "Paladin":
                        Paladin paladin = new Paladin(heroName);
                        raidGroup.Add(paladin);
                        break;
                    case "Rogue":
                        Rogue rogue = new Rogue(heroName);
                        raidGroup.Add(rogue);
                        break;
                    case "Warrior":
                        Warrior warrior = new Warrior(heroName);
                        raidGroup.Add(warrior);
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        break;
                }
            }

            int bossPower = int.Parse(Console.ReadLine());
            int totalPower = 0;
            foreach (var hero in raidGroup)
            {
                totalPower += hero.Power;
                Console.WriteLine(hero.CastAbility()); 
            }

            if (totalPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
