using System;
using System.Collections.Generic;
using HW07.Booking.Com.Models;

namespace HW07.Booking.Com.Services
{
    class GeneratorService
    {
        private readonly string[] _userNameList = new []
        {
            "WILLIAM",
            "ETHAN",
            "MICHAEL",
            "ALEXANDER",
            "NOAH",
            "MASON",
            "JACOB"
        };

        private readonly string[] _userSurnameList = new []
        {
            "MERCER",
            "TINKER",
            "BANNER",
            "BOND",
            "RYDER",
            "TUCKER",
            "BOND"
        };

        private readonly string[] _cityNameList = new[]
        {
            "MINSK",
            "BERLIN",
            "LONDON",
            "MOSKOW",
            "ROME",
            "TOKIO",
            "NEW YORK"
        };

        private readonly string[] _hotelNameList = new[]
        {
            "Hotel St. James",
            "The Manhattan Club",
            "West Side YMCA",
            "Aloft Harlem",
            "Hilton",
            "Leon Hotel",
            "Roger Smith Hotel"
        };

        private bool BoolGenerate() => new Random().Next(100) < 50;

        #region UserGenerate
        private User GenenerateUser()
        {
            Random random = new Random();
            string name = _userNameList[random.Next(0, 6)];
            return new User(
                mail: $"{name}.{_userSurnameList[random.Next(0, 6)]}@gmail.com",
                name: name,
                password: random.Next(1000000, 9999999).ToString()
            );
        }

        public void GenerateUserList(ref List<User> users)
        {
            Random random = new Random();
            for (int i = 0; i < random.Next(2, 10); i++) users.Add(GenenerateUser());
        }
        #endregion

        #region HotelGenerate

        private Hotel GenerateHotel()
        {
            Random random = new Random();

            string name = _hotelNameList[random.Next(0, 6)];
            string city = _cityNameList[random.Next(0, 6)];

            return new Hotel(name: name,
                city: city,
                isSeaNearby: BoolGenerate(),
                rooms: GenerateRoomList())
            {
                StarsCount = random.Next(1,5),
                Rating = random.Next(0, 10)

            };
        }

        public void GenerateHotelList(ref List<Hotel> hotels)
        {
            Random random = new Random();
            for (int i = 0; i < random.Next(5, 15); i++) hotels.Add(GenerateHotel());
        }
        #endregion

        #region RoomGenerator

        private Room GenerateRoom(int num)
        {
            Random random = new Random();

            int costOneRoom = 40;
            int areaForOneBed = 15;
            int bedsCount = random.Next(1, 4);
            return new Room(num: num, area: areaForOneBed*bedsCount, bedsCount: bedsCount)
            {
                Cost = random.Next(1,5)*costOneRoom* bedsCount,
                IsFree = BoolGenerate()
            };
        }

        private List<Room> GenerateRoomList()
        {
            List<Room> rooms = new List<Room>();
            Random random = new Random();
            for (int i = 1; i <= random.Next(10, 30); i++) rooms.Add(GenerateRoom(i));
            return rooms;
        }

        #endregion
    }
}
