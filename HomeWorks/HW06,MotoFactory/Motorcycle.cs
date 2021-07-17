using System;

namespace HW06_MotoFactory
{
    public enum Type
    {
        Petrol,
        Electro,
        Hybrid
    }

    internal class Motorcycle
    {
        private string _model;
        private string _manufacturer;
        private DateTime _year;
        private int _mileage;

        Guid ID { get; }
        public string Model 
        { 
            get => _model;
            set
            {
                while (value.Equals(""))
                {
                    Console.WriteLine("Значение должно быть не пустым!");
                    value = Console.ReadLine();
                }
                _model = value;
            }
        }
        public string Manufacturer 
        {
            get => _manufacturer;
            set
            {
                while (value.Equals(""))
                {
                    Console.WriteLine("Значение должно быть не пустым!");
                    value = Console.ReadLine();
                }
                _manufacturer = value;
            }
        }
        public DateTime Year 
        {
            get => _year;
            set => _year = DateTime.Now; 
        }
        public int Mileage 
        { 
            get => _mileage;
            set
            {
                while (value > 100)
                {
                    Console.WriteLine("Значение должно быть не больше 100!");
                    while(!int.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Введите числовое знвчение!");
                    }
                }
                _mileage = value;
            }
        }

        public Engine EngineParameters { get; set; }
       
        public class Engine
        {
            private int _volume;
            private int _power;

            public int Volume 
            { 
                get => _volume;
                set
                {
                    while (125 > value || value > 3200)
                    {
                        Console.WriteLine("Введенное значение должно быть в диапазоне от 125 до 3200!");
                        while (!int.TryParse(Console.ReadLine(), out value))
                        {
                            Console.WriteLine("Введите числовое знвчение!");
                        }
                    }
                    _volume = value;
                }
            }
            public int Power 
            { 
                get => _power;
                set 
                {
                    while (50 > value || value > 300)
                    {
                        Console.WriteLine("Введенное значение должно быть в диапазоне от 50 до 300!");
                        while (!int.TryParse(Console.ReadLine(), out value))
                        {
                            Console.WriteLine("Введите числовое знвчение!");
                        }
                    }
                    _power = value;
                }
            }
            Type Type { get; set; }

            public Engine() { }
        }

        public Motorcycle() => ID = Guid.NewGuid();

        private void ResetToDefaultSettings() => Console.WriteLine("Настройки сброшены!");

        public void ShowMoto(int num)
        {
            Console.WriteLine($"{num}   Мотоцикл (Производитель): \"{Manufacturer}\", Модель: \"{Model}\", Vin Number (Идентификатор): \"{ID}\", Год: \"{Year.Year}\"" +
                              $"\n      {num}.1      Двигатель(Объем): {EngineParameters.Volume}, Мощность: {EngineParameters.Power}");
        }
    }
}
