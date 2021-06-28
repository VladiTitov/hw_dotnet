using System;
using System.Linq;

namespace HW03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год рождения:");
            int yearBirth = InputOutput(0, DateTime.Now.Year);
            Console.WriteLine("Введите месяц рождения [1-12]:");
            int mouthBirth = InputOutput(0, 12);

            Console.WriteLine("Введите текущий год:");
            int yearNow = InputOutput(0, DateTime.Now.Year);
            Console.WriteLine("Введите текущий месяц[1-12]:");
            int mouthNow = InputOutput(0, 12);

            Console.WriteLine($"Число полных лет - {YearsCount(yearBirth, mouthBirth, yearNow, mouthNow)}");

            Console.ReadLine();
        }

        private static int InputOutput(int startRange, int endRange)
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value) || 
                   !Enumerable.Range(startRange, endRange + 1).Contains(value))
            {
                Console.WriteLine("Ошибка! Введите корректное число!");
            }
            return value;
        }

        private static int YearsCount(int yearBirth, int mouthBirth, int yearNow, int mouthNow)
        {
            if (mouthBirth <= mouthNow)
                return yearNow - yearBirth;
            return yearNow - yearBirth - 1;
        }
    }
}
