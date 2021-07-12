using System;
using System.Collections.Generic;
using HW07.Booking.Com.Models;
using HW07.Booking.Com.Services;

namespace HW07.Booking.Com
{
    class Program
    {
        private static List<User> _userList = new List<User>();
        private static List<Hotel> _hotelList = new List<Hotel>();

        static void Main()
        {
            GeneratorService generatorService = new GeneratorService();
            generatorService.GenerateUserList(ref _userList);
            generatorService.GenerateHotelList(ref _hotelList);

            MainService service = new MainService(_userList, _hotelList);
            service.ServiceStart();

            Console.ReadLine();
        }
    }
}
