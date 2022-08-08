using System;
using System.Collections.Generic;
using System.Text;

namespace _06.FoodShortage
{
    public interface IBuyer
    {
        public int Food { get; set; }

        void BuyFood();
    }
}
