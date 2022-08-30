using AquaShop.Models.Decorations.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public abstract class Decoration : IDecoration
    {
        public Decoration(int comfort, decimal price)
        {
            this.Comfort = comfort;
            this.Price = price;
        }

        private int comfort;
        private decimal price;

        public int Comfort
        {
            get 
            {
                return comfort; 
            }
            private set 
            { 
                comfort = value; 
            }
        }

        public decimal Price 
        { 
            get 
            { 
                return price; 
            }
            set
            {
                price = value;
            } 
        }

    }
}
