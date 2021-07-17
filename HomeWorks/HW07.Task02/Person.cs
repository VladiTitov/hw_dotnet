using System;

namespace HW07.Task02
{
    class Person
    {
        public string Name { get; set; }
        public House House { get; set; }

        public void ShowData()
        {
            Console.WriteLine($"My name is {Name}");
            House.ShowData();
            House.CreateDoor().ShowData();
        }
    }
}
