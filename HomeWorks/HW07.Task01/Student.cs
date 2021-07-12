using System;

namespace HW07.Task01
{
    class Student : Person
    {
        private int Age { get; }

        public Student(int age) => Age = age;

        public void GoToClasses() => Console.WriteLine("I’m going to class.");

        public void ShowAge() => Console.WriteLine($"My age is: {Age} years old");
    }
}
