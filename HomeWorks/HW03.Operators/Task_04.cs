using System;

namespace HW03.Operators
{
    class Task_04
    {
        public void Start()
        {
            Console.WriteLine("Введите первое число: a=");
            int a = InputOutput();
            Console.WriteLine("Введите первое число: b=");
            int b = InputOutput();
            Console.WriteLine("Введите оператор действия: (+ или -)");
            string op = CheckOpertor(Console.ReadLine());
            Console.WriteLine("Введите результат сложения: rez=");
            int rez = InputOutput();

            Console.WriteLine($"{СomparisonOfTheResult(GetSum(a, b, op), rez)}");

            Console.ReadLine();
        }

        private static int InputOutput()
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Ошибка! Введите корректное число!");
            }
            return value;
        }

        private string CheckOpertor(string op)
        {
            while (op != "+" && op != "-")
            {
                Console.WriteLine("Введен неверный оператор, ожидается + или -");
                op = Console.ReadLine();
            }
            return op;
        }

        private static int GetSum(int a, int b, string op)
        {
            if (op == "+") return a + b;
            return a - b;
        }

        private static string СomparisonOfTheResult(int sum, int rez)
        {
            if (sum == rez) return "Правильно";
            if (sum < rez) return "Неправильно. Должно быть меньше";
            return "Неправильно. Должно быть больше";
        }
    }
}
