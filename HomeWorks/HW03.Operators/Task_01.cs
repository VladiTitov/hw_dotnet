using System;

namespace HW03.Operators
{
    public class Task_01
    {
        public void Start()
        {
            Console.WriteLine("Введите первое число: a=");
            int a = InputOutput();
            Console.WriteLine("Введите первое число: b=");
            int b = InputOutput();

            Console.WriteLine($"Результат сложения a + b = {GetSum(a, b)}");
            Console.ReadLine();
        }

        private int InputOutput()
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Ошибка! Введите корректное число!");
            }
            return value;
        }

        private int GetSum(int a, int b) => a + b;

    }
}
