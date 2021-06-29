using System;

namespace HW03.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            #region Сложение
            Console.WriteLine("Сложение двух чисел");
            Console.WriteLine("Введите a=");
            int a = InputOutputConvert();
            Console.WriteLine("Введите b=");
            int b = InputOutputConvert();
            Console.WriteLine($"Результат сложения a+b = {calc.Addition(a, b)}");
            #endregion

            #region Вычитание
            Console.WriteLine("Вычитание двух чисел");
            Console.WriteLine("Введите a=");
            a = InputOutputConvert();
            Console.WriteLine("Введите b=");
            b = InputOutputConvert();
            Console.WriteLine($"Результат вычитания a-b = {calc.Subtraction(a, b)}");
            #endregion

            #region Умножение
            Console.WriteLine("Умножение двух чисел");
            Console.WriteLine("Введите a=");
            a = InputOutputConvert();
            Console.WriteLine("Введите b=");
            b = InputOutputConvert();
            Console.WriteLine($"Результат умножения a*b = {calc.Multiplication(a, b)}");
            #endregion

            #region Деление
            Console.WriteLine("Деление двух чисел");
            Console.WriteLine("Введите a=");
            a = InputOutputTryParse();
            Console.WriteLine("Введите b=");
            b = InputOutputTryParse();
            Console.WriteLine($"Результат деления a/b = {calc.Division(a, b)}");
            #endregion

            #region Остаток от деления
            Console.WriteLine("Остаток от деления");
            Console.WriteLine("Введите a=");
            a = InputOutputTryParse();
            Console.WriteLine("Введите b=");
            b = InputOutputTryParse();
            Console.WriteLine($"Остаток от деления a/b = {calc.Remainder(a, b)}");
            #endregion

            #region Площадь круга
            Console.WriteLine("Площадь круга");
            Console.WriteLine("Введите радиус r=");
            a = InputOutputTryParse();
            Console.WriteLine($"Площадь круга {calc.Area(a)}");
            #endregion

            Console.ReadLine();
        }
        private static int InputOutputConvert()
        {
            start:
            string line = Console.ReadLine();
            try
            {
                return Convert.ToInt32(line);
            }
            catch
            {
                Console.WriteLine("Ошибка! Введите корректное число!");
                goto start;
            }
        }

        private static int InputOutputTryParse()
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Ошибка! Введите корректное число!");
            }
            return value;
        }
    }
}
