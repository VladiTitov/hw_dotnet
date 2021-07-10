using System;
using System.Collections.Generic;
using System.Linq;

namespace HW04.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите размерность массива:");
            int[] array = ReturnArray(rangeMass: InputOutputValidation());
            Array.ForEach(array, Console.WriteLine);
            Delimiter();
            Array.ForEach(ConsoleInputOutput(array), Console.WriteLine);
            Console.ReadLine();
        }

        private static int[] ConsoleInputOutput(int[] array)
        {
            Console.WriteLine("Введите значение для вставки:");
            int value = InputOutputValidation();
            Console.WriteLine($"Введите номер позиции в массиве [от 0 до {array.Length - 1}]:");
            int position = InputOutputValidation(array.Length);
            Delimiter();
            List<int> result = new List<int>(array);
            result.Insert(position, value);
            return result.GetRange(0, array.Length).ToArray();
        }

        private static int[] ReturnArray(int rangeMass)
        {
            int[] array = new int[rangeMass];

            for (int i = 0; i < rangeMass - 1; i++)
            {
                Console.WriteLine($"Введите значение для массива [{i + 1} из {rangeMass - 1}]:");
                array[i] = InputOutputValidation();
            }

            return array;
        }

        private static void Delimiter() => Console.WriteLine(new string('-', 20));

        private static int InputOutputValidation()
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Ошибка! Введите корректное число!");
            }

            return value;
        }

        private static int InputOutputValidation(int endRange)
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value) ||
                   !Enumerable.Range(0, endRange).Contains(value))
            {
                Console.WriteLine("Ошибка! Введите корректное число!");
            }

            return value;
        }
    }
}
