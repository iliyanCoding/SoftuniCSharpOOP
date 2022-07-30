using System;

namespace _03.Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] urls = Console.ReadLine().Split(' ');

            foreach (var phoneNumber in phoneNumbers)
            {
                if (ValidatePhoneNumber(phoneNumber))
                {
                    if (phoneNumber.Length == 10)
                    {
                        Smartphone smartphone = new Smartphone(phoneNumber);
                        Console.WriteLine(smartphone.Call(phoneNumber)); 
                    }
                    else
                    {
                        StationaryPhone stationaryPhone = new StationaryPhone(phoneNumber);
                        Console.WriteLine(stationaryPhone.Call(phoneNumber));
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            foreach (var url in urls)
            {
                if (ValidateWebsite(url))
                {
                    Console.WriteLine($"Browsing: {url}!");
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }
            }
        }

        private static bool ValidateWebsite(string url)
        {
            foreach (var symbol in url)
            {
                if (char.IsDigit(symbol))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool ValidatePhoneNumber(string phoneNumber)
        {
            foreach (var num in phoneNumber)
            {
                if (!char.IsDigit(num))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
