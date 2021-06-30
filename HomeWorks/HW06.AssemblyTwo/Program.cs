using System;
using HW06.AssemblyOne;

namespace HW06.AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Motorcycle
            Motorcycle motorcycle = new Motorcycle("Урал");
            
            #endregion

            #region SportBike
            SportBike sportBike = new SportBike("HONDA");
            
            #endregion

            Console.ReadLine();
        }
    }
}
