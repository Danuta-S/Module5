using System;
using System.Text.RegularExpressions;

namespace Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber = "+35 392-022-194";
            //string phoneNumber = "+958 28492-503";

            string pattern = @"^(\+\d{2}\s\d{3}-\d{3}-\d{3})";

            var rgx = new Regex(pattern);

            var match = rgx.Match(phoneNumber);

            if (rgx.IsMatch(phoneNumber))
            {
                Console.WriteLine($"The phone number(\"{match.Value}\") --> true");
            }
            else
            {
                Console.WriteLine($"The phone number(\"{phoneNumber}\") --> false");
            }

            Console.ReadLine();            
        }
    }
}
