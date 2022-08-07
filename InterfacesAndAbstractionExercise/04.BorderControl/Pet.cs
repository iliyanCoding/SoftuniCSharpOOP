using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
{
    public class Pet : IBirthable
    {
        public Pet(string birthdate)
        {
            this.Birthdate = birthdate;
        }

        public string Name { get; private set; }

        public string Birthdate { get; private set; }
    }
}
