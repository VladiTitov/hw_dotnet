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
            motorcycle.BikeModel = "М-72";

            //motorcycle.Manufacturer = "";                         модификатор доступа private предоставляет доступ только внутри класса Motorcycle
            //motorcycle.ManufacturerProtected = "";                модификатор доступа protected не предоставляет доступ к бъекту класса Motorcycle
            //motorcycle.ManufacturerProtectedInternal = "";        модификатор доступа internal предоставляет доступ из любого места кода в той же сборке, поэтому здесь доступ невозможен, несмотря на protected
            //motorcycle.ManufacturerInternal = "";                 модификатор доступа internal предоставляет доступ из любого места кода в той же сборке, поэтому здесь доступ невозможен

            int speed = Motorcycle.MaxSpeedPublic;
            //speed = Motorcycle.MaxSpeedProtected;                 модификатор доступа protected не предоставляет доступ к бъекту класса Motorcycle
            //speed = Motorcycle.MaxSpeedPrivate;                   модификатор доступа private предоставляет доступ только внутри класса Motorcycle
            //speed = Motorcycle.MaxSpeedPrivateProtected;          совмещает вышеуказанные ограничения protected и private
            //speed = Motorcycle.MaxSpeedInternal;                  модификатор доступа internal предоставляет доступ из любого места кода в той же сборке, поэтому здесь доступ невозможен
            //speed = Motorcycle.MaxSpeedProtectedInternal;         модификатор доступа internal предоставляет доступ из любого места кода в той же сборке, поэтому здесь доступ невозможен, несмотря на protected

            motorcycle.weightPublic = 160;
            //motorcycle.weightInternal = 160;                      модификатор доступа internal предоставляет доступ из любого места кода в той же сборке, поэтому здесь доступ невозможен
            //motorcycle.weightProtected = 160;                     модификатор доступа protected не предоставляет доступ к бъекту класса Motorcycle
            //motorcycle.weightPrivate = 160;                       модификатор доступа private предоставляет доступ только внутри класса Motorcycle
            //motorcycle.weightPrivateProtected = 160;              совмещает вышеуказанные ограничения protected и private
            //motorcycle.weightProtectedInternal = 160;             модификатор доступа internal предоставляет доступ из любого места кода в той же сборке, поэтому здесь доступ невозможен, несмотря на protected

            motorcycle.colorPublic = "black";
            //motorcycle.colorInternal = "black";                   модификатор доступа internal предоставляет доступ из любого места кода в той же сборке, поэтому здесь доступ невозможен
            //motorcycle.colorProtected = "black";                  модификатор доступа protected не предоставляет доступ к бъекту класса Motorcycle
            //motorcycle.colorPrivate = "black";                    модификатор доступа private предоставляет доступ только внутри класса Motorcycle
            //motorcycle.colorProtectedInternal = "black";          модификатор доступа internal предоставляет доступ из любого места кода в той же сборке, поэтому здесь доступ невозможен, несмотря на protected

            motorcycle.Start();
            //motorcycle.Stop();                                    модификатор доступа protected не предоставляет доступ к бъекту класса Motorcycle
            #endregion

            #region SportBike
            SportBike sportBike = new SportBike("HONDA");
            sportBike.BikeModel = "CBR1000RR";

            //sportBike.Manufacturer = "";                          модификатор доступа private предоставляет доступ только внутри класса SportBike
            //sportBike.ManufacturerProtected = "";                 модификатор доступа protected не предоставляет доступ к бъекту класса SportBike
            //sportBike.ManufacturerProtectedInternal = "";         модификатор доступа internal предоставляет доступ из любого места кода в той же сборке, поэтому здесь доступ невозможен, несмотря на protected
            //sportBike.ManufacturerInternal = "";                  модификатор доступа internal предоставляет доступ из любого места кода в той же сборке, поэтому здесь доступ невозможен

            speed = SportBike.MaxSpeedPublic;
            //speed = SportBike.MaxSpeedProtected;                  модификатор доступа protected не предоставляет доступ к бъекту класса SportBike
            //speed = SportBike.MaxSpeedPrivate;                    модификатор доступа private предоставляет доступ только внутри класса SportBike
            //speed = SportBike.MaxSpeedPrivateProtected;           совмещает вышеуказанные ограничения protected и private
            //speed = SportBike.MaxSpeedInternal;                   модификатор доступа internal предоставляет доступ из любого места кода в той же сборке, поэтому здесь доступ невозможен
            //speed = SportBike.MaxSpeedProtectedInternal;          модификатор доступа internal предоставляет доступ из любого места кода в той же сборке, поэтому здесь доступ невозможен, несмотря на protected

            sportBike.weightPublic = 160;
            //sportBike.weightInternal = 160;                       модификатор доступа internal предоставляет доступ из любого места кода в той же сборке, поэтому здесь доступ невозможен
            //sportBike.weightProtected = 160;                      модификатор доступа protected не предоставляет доступ к бъекту класса SportBike
            //sportBike.weightPrivate = 160;                        модификатор доступа private предоставляет доступ только внутри класса SportBike
            //sportBike.weightPrivateProtected = 160;               совмещает вышеуказанные ограничения protected и private
            //sportBike.weightProtectedInternal = 160;              модификатор доступа internal предоставляет доступ из любого места кода в той же сборке, поэтому здесь доступ невозможен, несмотря на protected

            sportBike.colorPublic = "black";
            //sportBike.colorInternal = "black";                    модификатор доступа internal предоставляет доступ из любого места кода в той же сборке, поэтому здесь доступ невозможен
            //sportBike.colorProtected = "black";                   модификатор доступа protected не предоставляет доступ к бъекту класса SportBike
            //sportBike.colorPrivate = "black";                     модификатор доступа private предоставляет доступ только внутри класса SportBike
            //sportBike.colorProtectedInternal = "black";           модификатор доступа internal предоставляет доступ из любого места кода в той же сборке, поэтому здесь доступ невозможен, несмотря на protected

            sportBike.Start();
            //sportBike.Stop();                                     модификатор доступа protected не предоставляет доступ к бъекту класса SportBike
            #endregion

            Console.ReadLine();
        }
    }
}
