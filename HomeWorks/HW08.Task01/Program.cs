using System;
using HW08.Task01.Services;

namespace HW08.Task01
{
    class Program
    {
        static void Main()
        {
            CompanyCreatorService companiesCreator = new CompanyCreatorService();
            companiesCreator.Start();

            Console.ReadLine();
        }
    }
}
