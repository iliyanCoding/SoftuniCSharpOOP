using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Raiding
{
    public abstract class BaseHero
    {
        public BaseHero(string name)
        {
            this.Name = name;
            //this.Power = power;
        }

        public string Name { get; private set; }

        public int Power { get; protected set; }

        public virtual string CastAbility()
        {
            return null;
        }
    }
}
