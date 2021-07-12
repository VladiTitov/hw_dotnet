using System;

namespace HW07.Task02
{
    class Door
    {
        private string Color { get; set; }

        public Door(string color) => Color = color;

        public void ShowData() => Console.WriteLine($"I am a door, my color is {Color}");
    }
}
