using System;

namespace HW07.Task02
{
    class Program
    {
        static void Main()
        {
            SmallApartment apartment = new SmallApartment();
            Person person = new Person()
            {
                House = apartment,
                Name = "Vladislav"
            };
            person.ShowData();

            Console.ReadLine();
        }
    }
}
