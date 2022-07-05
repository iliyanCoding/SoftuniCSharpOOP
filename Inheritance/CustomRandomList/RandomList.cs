using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    internal class RandomList : List<string>
    {
        public string RandomString()
        {
            string rndStr = string.Empty;
            Random rnd = new Random();
            int index = rnd.Next(0, this.Count);
            rndStr = this[index];
            this.RemoveAt(index);
            return rndStr;
        }
    }
}
