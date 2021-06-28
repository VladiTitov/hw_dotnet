using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HW05.Task01
{
    class Program
    {
        static void Main()
        {
            Start("gdfgdf234dg54gf*23oP42");
            Console.ReadLine();
        }

        private static void Start(string text) =>
            Console.WriteLine($"Результат: {MathematicalAction(text)}");

        private static double MathematicalAction(string text)
        { 
            var values = Regex.Matches(text, "[0-9*/+-]").ToArray();

            var separator = values.FirstOrDefault(a => a.Value.Equals("*") |
                                                       a.Value.Equals("/") |
                                                       a.Value.Equals("+") |
                                                       a.Value.Equals("-"));

            int indx = Array.IndexOf(values, separator);

            return MathOperation(GetNums(indx, values), separator.Value);
        }

        private static int[] GetNums(int indx, object[] array)
        {
            string firstNumString = string.Join("", array[0..indx]);
            indx++;
            string secondNumString = string.Join("", array[indx..array.Length]);

            return new[]
            {
                int.Parse(firstNumString), 
                int.Parse(secondNumString)
            };
        }

        private static double MathOperation(int[] nums, string separator)
        {
            return separator switch
            {
                "*" => nums[0] * nums[1],
                "/" => nums[0] / nums[1],
                "+" => nums[0] + nums[1],
                "-" => nums[0] - nums[1],
                _ => 0
            };
        }
    }
}
