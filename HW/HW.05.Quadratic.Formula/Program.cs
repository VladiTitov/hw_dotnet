using System;

namespace HW._05.Quadratic.Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной A");
            var a = Console.ReadLine();
            Console.WriteLine("Введите значение переменной B");
            var b = Console.ReadLine();
            Console.WriteLine("Введите значение переменной C");
            var c = Console.ReadLine();

            if (GetDiscriminant(Convert.ToInt16(a),
                Convert.ToInt16(b),
                Convert.ToInt16(c)))
            {
                var result = GetX(
                    Convert.ToInt16(a),
                    Convert.ToInt16(b),
                    Convert.ToInt16(c));
                Console.WriteLine($"Ответ: x1 = {Math.Round(result.x1, 5)}, x2 = {Math.Round(result.x2, 5)}");
            }
            else Console.WriteLine($"Так как дискриминант меньше нуля, то уравнение не имеет действительных решений.");
        }

        private static (double x1, double x2) GetX(short a, short b, short c)
        {
            var b2 = Math.Pow(b, 2);
            var sq = Math.Sqrt(Math.Abs(b2 - 4 * a *c));

            double x1 = (-(b) - Math.Sqrt(Math.Pow(b,2) - 4*a*c )) / 2 * a;
            double x2 = (-(b) + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;
            return (x1, x2);
        }

        private static bool GetDiscriminant(short a, short b, short c)
        {
            var discr = Math.Pow(b, 2) - 4 * a * c;
            if (discr > 0) return true;
            return false;
        }
    }
}
