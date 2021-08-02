using System;
using HW08.Task03.Services;

namespace HW08.Task03
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
