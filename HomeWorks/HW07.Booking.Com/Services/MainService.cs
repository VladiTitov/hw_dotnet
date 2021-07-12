using System;
using System.Collections.Generic;
using System.Linq;
using HW07.Booking.Com.Models;

namespace HW07.Booking.Com.Services
{
    class MainService
    {
        private List<User> _userList;
        private List<Hotel> _hotelList;

        public MainService(List<User> userList, List<Hotel> hotelList) =>
            (_userList, _hotelList) = (userList, hotelList);

        public void ServiceStart()
        {
            Console.WriteLine("Welcome in Booking.com\nPlease, login to your account");

            string name = InputOutput("Enter your name:");
            string password = InputOutput("Enter your password:");

            User user = new User(mail: $"{name}@gmail.com",
                name: name,
                password: password);

            VerifyUser(user);
            ShowHotels(SearchHotel());
        }

        private void VerifyUser(User userEnter)
        {
            var userFinded = _userList.Where(i => i.Name.Equals(userEnter.Name))?.FirstOrDefault();

            if (userFinded != null && !userFinded.Password.Equals(userEnter.Password))
            {
                Console.WriteLine("The password is incorrect, change the password");
                userFinded.ChangePassword(InputOutput("Enter new password"));
            }
            else RegisterUser(userEnter);

            Console.WriteLine($"{new string('-', 35)}\nHello {userEnter.Name}\n{new string('-', 35)}");
        }

        public void RegisterUser(User user)
        {
            if (_userList.Contains(user)) throw new ArgumentException("The user is already in the system!\nTry again");
            _userList.Add(user);
        }

        public List<Hotel> SearchHotel()
        {
            Console.WriteLine($"Enter your search criteria:\n{new string('.',35)}");
            ShowCities();
            string city = InputOutput($"Enter city:");
            int adultCount = ReturnInt(InputOutput("Enter the number of adults:"));
            int childrenCount = ReturnInt(InputOutput("Enter the number of children"));
            bool seaNearby = ReturnBool(InputOutput("The presence of the sea nearby [y/n]:"));

            List<Hotel> hotelResult = new List<Hotel>();
            foreach (var hotel in _hotelList.Where(a => a.City.Equals(city.ToUpper()) && a.IsSeaNearby.Equals(seaNearby)))
            {
                var rooms = hotel.Rooms.Where(i => i.IsFree.Equals(true) && i.BedsCount >= adultCount + childrenCount).ToList();
                if (rooms.Any()) hotelResult.Add(new Hotel(hotel.Name, hotel.City, hotel.IsSeaNearby, rooms));
            }
            return hotelResult;
        }

        private void ShowCities()
        {
            foreach (var city in _hotelList.Select(a => a.City).Distinct().ToList()) Console.WriteLine($"- {city}");
        }

        private void ShowHotels(List<Hotel> hotels)
        {
            foreach (var hotel in hotels)
            {
                Console.WriteLine($"{new string('.',35)}\n{hotel.Name}\n{new string('.',35)}");
                foreach (var room in hotel.Rooms) room.ShowRoom();
            }
            string selectedHotel = InputOutput("Select hotel:");
            string selectedRoom = InputOutput("Select room:");

            Console.WriteLine($"Room {selectedRoom} in hotel {selectedHotel.ToUpper()} booked, thank you!");
        }

        private string InputOutput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine().ToUpper();
        }

        private bool ReturnBool(string value)
        {
            char key = value.ToUpper()[0];
            if (key.Equals('Y')) return true;
            return false;
        }

        private int ReturnInt(string value)
        {
            int.TryParse(value, out int result);
            return result;
        }
    }
}
