using System;

namespace HW07.Booking.Com.Models
{
    class Room
    {
        public int Num { get; }
        public double Area { get; }
        public bool IsFree { get; set; }
        public int BedsCount { get; }
        public double Cost { get; set; }

        public Room(int num, double area, int bedsCount) => (Num, Area, BedsCount) = (num, area, bedsCount);

        public void ShowRoom() =>
            Console.WriteLine($"Room num:{Num}, Room area: {Area}, Room cost: {Cost}");
    }
}
