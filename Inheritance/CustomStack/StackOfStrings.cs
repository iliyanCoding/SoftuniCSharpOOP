using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            if (this.Count > 0)
            {
                return false;
            }
            return true;
        }

        public void AddRange(IEnumerable<string> el)
        {
            foreach (var str in el)
            {
                this.Push(str);
            }
        }
    }
}
