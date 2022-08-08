using System;
using System.Collections.Generic;
using System.Text;

namespace _06.FoodShortage
{
    public class Rebel : IBuyer
    {
        public Rebel(string name, string age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public string Name { get; private set; }

        public string Age { get; private set; }

        public string Group { get; private set; }

        public int Food { get; set; } = 0;

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
