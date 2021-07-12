using System.Collections.Generic;

namespace HW07.Booking.Com.Models
{
    class Hotel
    {
        public string Name { get; }
        public string City { get; }
        public double StarsCount { get; set; }
        public bool IsSeaNearby { get; }
        public double Rating { get; set; }
        public List<Room> Rooms { get; }

        public Hotel(string name, string city, bool isSeaNearby, List<Room> rooms)
        {
            Name = name;
            City = city;
            IsSeaNearby = isSeaNearby;
            Rooms = rooms;
        }

    }
}
