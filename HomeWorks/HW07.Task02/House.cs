using System;

namespace HW07.Task02
{
    class House
    {
        protected double Area { get; set; }
        private Door Door { get; set; }

        public House(double area) => Area = area;

        public Door CreateDoor() => Door = new Door("White");
        public void ShowData() => Console.WriteLine($"I am a house, my area is {Area} m2");
    }
}
