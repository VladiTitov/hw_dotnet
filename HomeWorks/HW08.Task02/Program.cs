﻿using System;
using HW08.Task02.Services;

namespace HW08.Task02
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
