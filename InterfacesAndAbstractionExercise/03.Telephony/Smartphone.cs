using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public class Smartphone : IBrowseable, ICallable
    {
        public string PhoneNumber { get; set; }

        public string Url { get; set; }

        public Smartphone(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }

        public void Browse(string url)
        {
            throw new NotImplementedException();
        }

        public string Call(string phoneNumber)
        {
            return $"Calling... {phoneNumber}";
        }
    }
}
