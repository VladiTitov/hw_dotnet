using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HW04.Task05
{
    class Program
    {
        static void Main()
        {
            StartTask("I am learning the C# language, and will go through the tutorial to the end!");
        }

        private static void StartTask(string text)
        {
            Console.WriteLine($"Исходный текст:{text}");
            DeleteLongWord(ref text);
            ReplaceMaxMinWord(ref text);
            ReturnCharsCount(text);
            Array.ForEach(ReturnOrderArray(text), Console.WriteLine);
        }

        private static void DeleteLongWord(ref string text)
        {
            string max = ReturnOrderArray(text).FirstOrDefault();
            text = text.Replace($"{max} ", "");
            Console.WriteLine($"Самое большое слово: {max}, результат: {text}");
        }

        private static void ReplaceMaxMinWord(ref string text)
        {
            string[] orderArray = ReturnOrderArray(text);
            string[] array = GetArray(text);
            string min = orderArray.LastOrDefault();
            string max = orderArray.FirstOrDefault();
            for (int i = 0; i < array.Count(); i++)
            {
                if (array[i].Equals(max)) 
                {
                    array[i] = min;
                    continue;
                }

                if (array[i].Equals(min))
                {
                    array[i] = max;
                    continue;
                } 
            }
            text = string.Join(' ', array);
            Console.WriteLine(text);
        }

        private static void ReturnCharsCount(string text)
        {
            Console.WriteLine($"Количество в строке букв: {new Regex("[a-zA-Z]").Matches(text).Count}");
            Console.WriteLine($"Количество в строке знаков препинания: {new Regex("[-.?!)(,:]").Matches(text).Count}");
        }

        private static string[] ReturnOrderArray(string text)
        {
            string[] array = GetArray(text);
            return array.OrderBy(a => a.Length).Reverse().ToArray();
        }

        private static string[] GetArray(string text) => text.Split(' ');
    }
}
