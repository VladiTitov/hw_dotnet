using System;
using System.Linq;

namespace HW05.Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "123 Main Street St.Louisville OH 43071,432 Main Long Road St. Louisville OH 43071,786 High Street Pollocksville NY 56432";
            Travel(address, "NY 5643");
            Console.ReadLine();
        }

        private static void Travel(string address, string zipcode)
        {
            string[] addrArray = address.Split(',');

            var addresses = Enumerable.Range(0, addrArray.Length).Select(a => new Address(addrArray[a])).ToArray();
            var foundAddresses = addresses.Where(i => i.Equals(new Zipcode(zipcode.Split(' ')))).ToArray();

            Console.WriteLine($"{zipcode}:{ReturnFoundAddresses(foundAddresses)}");
        }

        private static string ReturnFoundAddresses(Address[] foundAddresses)
        {
            if (foundAddresses.Length.Equals(0)) return "/";

            string streetJoin = string.Join(',',foundAddresses.Select(a => a.Street));
            string houseJoin = string.Join(',', foundAddresses.Select(a => a.House));
            return $"{streetJoin}/{houseJoin}";
        }
    }
}
