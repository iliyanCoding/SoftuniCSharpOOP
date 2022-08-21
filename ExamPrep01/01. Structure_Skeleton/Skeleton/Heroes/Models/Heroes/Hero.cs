using Heroes.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Models.Heroes
{
    public abstract class Hero : IHero
    {
        public Hero(string name, int health, int armour)
        {
            this.Name = name;
            this.Health = health;
            this.Armour = armour;
        }

        private string name;
        private int health;
        private int armour;
        private IWeapon weapon;

        public string Name
        {
            get 
            { 
                return name; 
            }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Hero name cannot be null or empty.");
                }
                name = value; 
            }
        }

        public int Health
        {
            get
            {
                return health;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hero health cannot be below 0.");
                }
                health = value;
            }
        }

        public int Armour 
        {
            get 
            { 
                return armour; 
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hero armour cannot be below 0.");
                }
                armour = value;
            }
        }

        public IWeapon Weapon
        {
            get { return this.weapon; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Weapon cannot be null.");
                }
                this.weapon = value;
            }
        }

        public bool IsAlive => this.Health > 0;

        public void AddWeapon(IWeapon weapon)
        {
            this.Weapon = weapon;
        }

        public void TakeDamage(int points)
        {
            var armourLeft = this.Armour - points;
            if (armourLeft < 0)
            {
                this.Armour = 0;

                var healthLeft = this.Health + points;
                if (this.Health <= 0)
                {
                    this.Health = 0;
                }
                else
                {
                    this.Health = healthLeft;
                }
            }
            else
            {
                this.Armour = armourLeft;
            }
        }
    }
}
