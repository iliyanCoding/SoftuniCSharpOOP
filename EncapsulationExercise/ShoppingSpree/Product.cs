using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private int cost; 

        public string Name
        {
            get
            {
                return this.name; 
            }
            private set 
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value; 
            }
        }

        public int Cost
        {
            get 
            { 
                return this.cost; 
            }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.cost = value; 
            }
        }

    }
}
