using System;

namespace HW03.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания для проверки [1-9]:");
            string numTask = Console.ReadLine();
            Console.WriteLine($"Запуск задания №{numTask} для проверки...");
            switch (numTask)
            {
                case "1":
                    Task_01 firstTask = new Task_01();
                    firstTask.Start();
                    break;
                case "2":
                    Task_02 secondTask = new Task_02();
                    secondTask.Start();
                    break;
                case "3":
                    Task_03 thirdTask = new Task_03();
                    thirdTask.Start();
                    break;
                case "4":
                    Task_04 fourthTask = new Task_04();
                    fourthTask.Start();
                    break;
                case "5":
                    Task_05 fifthTask = new Task_05();
                    fifthTask.Start();
                    break;
                case "6":
                    Task_06 sixthTask = new Task_06();
                    sixthTask.Start();
                    break;
            }
        }
    }
}
