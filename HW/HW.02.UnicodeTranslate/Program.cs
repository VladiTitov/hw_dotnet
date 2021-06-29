using System;

namespace HW._02.UnicodeTranslate
{
    class Program
    {
        static void Main(string[] text)
        {
            foreach (string line in text)
            {
                foreach (var letter in line)
                {
                    var result = GetBinaryCode(letter);
                    Console.WriteLine($"{result.LetterName}: {result.DecimalCode} -> {result.BinaryCode}");
                }
            }
        }

        private static Letter GetBinaryCode(char letter)
        {
            char letterUpper = Convert.ToChar(letter.ToString().ToUpper());
            int letterValue = (int)letterUpper;
            string binary = Convert.ToString(letterValue, 2);
            return new Letter(letterUpper, letterValue, binary);
        }
    }

    class Letter
    {
        public char LetterName { get; }
        public int DecimalCode { get; }
        public string BinaryCode { get; }

        public Letter(char letterName, int decimalCode, string binaryCode)
        {
            LetterName = letterName;
            DecimalCode = decimalCode;
            BinaryCode = binaryCode;
        }
    }
}
