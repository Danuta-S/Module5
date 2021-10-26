using System;
using System.Text.RegularExpressions;

namespace Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            string CheckPhoneNumber = "+35 392-022-194";
            //string CheckPhoneNumber = "+958 28492-503";

            string pattern = @"^(\+\d{2}\s\d{3}-\d{3}-\d{3})";

            var rgx = new Regex(pattern);

            var match = rgx.Match(CheckPhoneNumber);

            if (rgx.IsMatch(CheckPhoneNumber))
            {
                Console.WriteLine($"The phone number(\"{match.Value}\") --> true");
            }
            else
            {
                Console.WriteLine($"The phone number(\"{CheckPhoneNumber}\") --> false");
            }

            Console.ReadLine();            
        }
    }
}
