using System;
using System.Linq;

namespace HW04.Task01
{
    class Program
    {
        static void Main()
        {
            ReturnArrays(out int[] arrayRandom, out int[] arrayConsole, out int[] arraySum);
            
            PrintArrays(new[]
            {
                arrayConsole,
                arrayRandom,
                arraySum
            });

            Console.ReadLine();
        }

        private static void ReturnArrays(out int[] arrayRandom, out int[] arrayConsole, out int[] arraySum)
        {
            arrayRandom = new int[] { };
            arrayConsole = new int[] { };
            arraySum = new int[] { };

            #region Работа с консолью
            do
            {
                arrayConsole = GenerateArrayConsole(arrayConsole);
                Console.WriteLine($"В массиве {arrayConsole.Length} значений.\nХотите ли вы добавить число в массив? (Y/N)");
            }
            while (string.Equals(Console.ReadLine()?.ToUpper(), "Y"));
            #endregion

            arrayRandom = GenerateArrayRandom(arrayConsole.Length);
            arraySum = SumArrays(new []
            {
                arrayRandom, 
                arrayConsole
            });
        }

        private static int[] GenerateArrayRandom(int count)
        {
            Random random = new Random();
            return Enumerable.Range(0, count).Select(a => random.Next(15)).ToArray();
        }

        private static int[] GenerateArrayConsole(int[] arrayConsole)
        {
            Console.WriteLine("Введите значение для массива:");
            return arrayConsole.Concat(new[] {InputOutputValidation()}).ToArray();
        }

        private static int[] SumArrays(int[][] arrays) =>
            arrays[0].Zip(arrays[1], (a, b) => a + b).ToArray();

        private static void PrintArrays(int[][] arrays)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine($"---------------------\nСодержимое массива №{i+1}:");
                foreach (var value in arrays[i])
                    Console.WriteLine(value);
            }
        }

        private static int InputOutputValidation()
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
