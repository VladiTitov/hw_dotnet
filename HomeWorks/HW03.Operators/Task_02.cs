using System;

namespace HW03.Operators
{
    public class Task_02
    {
        public void Start()
        {
            Console.WriteLine("Введите первое число: a=");
            int a = InputOutput();
            Console.WriteLine("Введите первое число: b=");
            int b = InputOutput();

            Console.WriteLine("Введите результат вычисления:");
            int rez = InputOutput();

            Console.WriteLine(CompareResults(GetSum(a, b), rez)); 

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

        private string CompareResults(int sum, int rez)
        {
            if (sum == rez) return "Правильно";
            return "Неправильно";
        }

        private int GetSum(int a, int b) => a + b;
    }
}
