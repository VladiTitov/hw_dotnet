using System;
using System.Text;

namespace HW05.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Start("1a!2.3!!.. 4.!.?6 7! ..?"));
            Console.ReadLine();
        }

        private static StringBuilder Start(string text)
        {
            int index = text.IndexOf('?');
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                ReturnValue(ref sb, text[i], i > index);
            }
            return sb;
        }

        private static void ReturnValue(ref StringBuilder sb, char ch, bool conditions)
        {
            switch (ch)
            {
                case '!':
                    if (conditions) sb.Append(ch);
                    break;
                case '.':
                    if (conditions) sb.Append(ch);
                    break;
                case ' ':
                    if (conditions) sb.Append('_');
                    break;
                default:
                    sb.Append(ch);
                    break;
            }
        }
    }
}
