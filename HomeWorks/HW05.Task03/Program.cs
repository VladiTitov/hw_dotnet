using System;
using System.Collections.Generic;

namespace HW05.Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = new[]
            {
                "arp",
                "live",
                "strong"
            };

            string[] secondArray = new[]
            {
                "lively",
                "alive",
                "harp",
                "sharp",
                "armstrong"
            };

            Start(firstArray, secondArray);

            Console.ReadLine();
        }

        private static void Start(string[] firstArray, string[] secondArray)
        {
            List<string> result = new List<string>();

            foreach (var value in firstArray)
            {
                ReturnCommonWords(ref result, value, secondArray);
            }

            Array.ForEach(result.ToArray(), Console.WriteLine);
        }

        private static void ReturnCommonWords(ref List<string> result, string word, string[] array)
        {
            foreach (var value in array)
            {
                if (value.Contains(word))
                {
                    if (!result.Contains(word)) result.Add(word);
                }
            }
        }
    }
}
