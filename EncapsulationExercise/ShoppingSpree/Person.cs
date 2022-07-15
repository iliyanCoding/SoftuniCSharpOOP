using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private int age;
        private List<Product> bagOfProducts;

        public Person(string name, int age, List<Person> bagOfProducts)
        {
            this.name = name;
            this.age = age;
            this.bagOfProducts = new List<Product>();
        }

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

        public int Age
        {
            get 
            {
                return this.age; 
            }
            private set
            {
                this.age = value;
            }
        }

    }
}
