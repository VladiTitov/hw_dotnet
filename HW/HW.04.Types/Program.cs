using System;

namespace HW._04.Types
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sb1 = 1;
            SByte sb2 = 1;

            short sh1 = 1;
            Int16 sh2 = 1;

            int i1 = 1;
            Int32 i2 = 1;

            long l1 = 1;
            Int64 l2 = 1;

            byte b1 = 1;
            Byte b2 = 1;

            ushort us1 = 1;
            UInt16 us2 = 1;

            char ch1 = 'a';
            Char ch2 = 'a';

            uint ui1 = 1;
            UInt32 ui2 = 1;

            ulong ul1 = 1;
            UInt64 ul2 = 1;

            float fl1 = 1;
            Single fl2 = 1;

            double do1 = 1;
            Double do2 = 1;

            decimal dec1 = 1;
            Decimal dec2 = 1;


            Console.WriteLine($"sbyte - {sb1.GetType()}");
            Console.WriteLine($"SByte - {sb2.GetType()}");
            Console.WriteLine();
            Console.WriteLine($"short - {sh1.GetType()}");
            Console.WriteLine($"Int16 - {sh2.GetType()}");
            Console.WriteLine();
            Console.WriteLine($"int -   {i1.GetType()}");
            Console.WriteLine($"Int32 - {i2.GetType()}");
            Console.WriteLine();
            Console.WriteLine($"long -  {l1.GetType()}");
            Console.WriteLine($"Int64 - {l2.GetType()}");
            Console.WriteLine();
            Console.WriteLine($"ushort - {us1.GetType()}");
            Console.WriteLine($"UInt16 - {us2.GetType()}");
            Console.WriteLine();
            Console.WriteLine($"char - {ch1.GetType()}");
            Console.WriteLine($"Char - {ch2.GetType()}");
            Console.WriteLine();
            Console.WriteLine($"uint - {ui1.GetType()}");
            Console.WriteLine($"UInt32 - {ui2.GetType()}");
            Console.WriteLine();
            Console.WriteLine($"ulong - {ul1.GetType()}");
            Console.WriteLine($"UInt64 - {ul2.GetType()}");
            Console.WriteLine();
            Console.WriteLine($"float - {fl1.GetType()}");
            Console.WriteLine($"Single - {fl2.GetType()}");
            Console.WriteLine();
            Console.WriteLine($"double - {do1.GetType()}");
            Console.WriteLine($"Double - {do2.GetType()}");
            Console.WriteLine();
            Console.WriteLine($"decimal - {dec1.GetType()}");
            Console.WriteLine($"Decimal - {dec2.GetType()}");
        }
    }
}
