using System;

namespace HW03.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания для проверки [1-9]:");
            string numTask = Console.ReadLine();
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
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    break;
            }
        }
    }
}
