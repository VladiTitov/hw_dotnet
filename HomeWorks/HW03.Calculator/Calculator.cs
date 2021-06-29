using System;
using System.Collections.Generic;
using System.Text;

namespace HW03.Calculator
{
    class Calculator
    {
        public int Addition(int a, int b) => a + b;
        public int Subtraction(int a, int b) => a - b;
        public int Multiplication(int a, int b) => a * b;
        public int Division(int a, int b) => a / b;
        public int Remainder(int a, int b) => a % b;
        public double Area(int a) => Math.Pow(a,2)*3.14;
    }
}
