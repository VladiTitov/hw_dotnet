using System;

namespace HW06_MotoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var motorcycles = StartCreateMotorcycles();

            for (int i = 0; i < motorcycles.Length; i++)
                motorcycles[i].ShowMoto(i+1);

            Console.ReadLine();
        }

        private static Motorcycle[] StartCreateMotorcycles()
        {
            Motorcycle[] motoArray = new Motorcycle[3];

            for (int i = 0; i < motoArray.Length; i++)
            {
                motoArray[i] = ReturnMoto($"Создание мотоцикла {i + 1} из {motoArray.Length}");
            }
            return motoArray;
        }


        private static Motorcycle ReturnMoto(string label)
        {
            Console.WriteLine($"{new string('-',30)}\n{label}\n{new string('-', 30)}");

            return new Motorcycle()
            {
                Manufacturer = ReturnStringValue("Введите название производителя:"),
                Model = ReturnStringValue("Введите название модели:"),
                Mileage = ReturnIntValue("Введите пробег:"),
                Year = DateTime.Now,
                EngineParameters = new Motorcycle.Engine() 
                { 
                    Volume = ReturnIntValue("Введите объем двигателя:"), 
                    Power = ReturnIntValue("Введите можность двигателя:") 
                }
            };
        }

        private static string ReturnStringValue(string label)
        {
            Console.WriteLine(label);
            return Console.ReadLine();
        }

        private static int ReturnIntValue(string label)
        {
            int value;
            while (!int.TryParse(ReturnStringValue(label), out value))
            {
                Console.WriteLine("Ошибка! Введите корректное число!");
            }
            return value;
        }
    }
}
