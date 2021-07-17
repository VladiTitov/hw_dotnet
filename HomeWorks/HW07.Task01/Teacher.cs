using System;

namespace HW07.Task01
{
    class Teacher : Person
    {
        private int Age { get; }

        private string _subject;
        public Teacher(int age) => Age = age;
        public void Explain() => Console.WriteLine($"Explanation begins");
    }
}
