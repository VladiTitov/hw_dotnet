using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HW04.Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            new Task(100_000_000).Start();
            Console.ReadLine();
        }
    }
}
