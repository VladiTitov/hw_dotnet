using System;

namespace HW03.Operators
{
    class Task_06
    {
        public void Start()
        {
            Console.WriteLine("Введите символ:");
            string key = Console.ReadLine();
            Console.WriteLine($"Результат: {Move(key)}");
            Console.ReadLine();
        }

        private string Move(string key)
        {
            switch (key.ToUpper())
            {
                case "W":
                    return "Перемещаем фигуру вверх";
                case "S":
                    return "Перемещаем фигуру вниз";
                case "A":
                    return "Перемещаем фигуру влево";
                case "D":
                    return "Перемещаем фигуру вправо";
                default:
                    return "Перемещение не требуется";
            }
        }
    }
}
