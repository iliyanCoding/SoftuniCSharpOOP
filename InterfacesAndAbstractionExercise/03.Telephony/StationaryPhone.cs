using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public class StationaryPhone : ICallable
    {
        public string PhoneNumber { get; set; }
        public StationaryPhone(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }
        public string Call(string phoneNumber)
        {
            return $"Dialing... {phoneNumber}";
        }
    }
}
