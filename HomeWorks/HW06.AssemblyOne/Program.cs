using System;

namespace HW06.AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Motorcycle
            Motorcycle motorcycle = new Motorcycle(manufacturer: "DUCATI");

            motorcycle.BikeModel = "Diavel";

            //motorcycle.Manufacturer = "";                         модификатор доступа private предоставляет доступ только внутри класса Motorcycle
            //motorcycle.ManufacturerProtected = "";                модификатор доступа protected не предоставляет доступ к бъекту класса Motorcycle
            motorcycle.ManufacturerProtectedInternal = "";
            motorcycle.ManufacturerInternal = "";

            int speed = Motorcycle.MaxSpeedPublic;
            //speed = Motorcycle.MaxSpeedProtected;                 модификатор доступа protected не предоставляет доступ к бъекту класса Motorcycle
            //speed = Motorcycle.MaxSpeedPrivate;                   модификатор доступа private предоставляет доступ только внутри класса Motorcycle
            //speed = Motorcycle.MaxSpeedPrivateProtected;          совмещает вышеуказанные ограничения protected и private
            speed =  Motorcycle.MaxSpeedInternal;
            speed = Motorcycle.MaxSpeedProtectedInternal;

            motorcycle.weightPublic = 160;
            motorcycle.weightInternal = 160;
            //motorcycle.weightProtected = 160;                     модификатор доступа protected не предоставляет доступ к бъекту класса Motorcycle
            //motorcycle.weightPrivate = 160;                       модификатор доступа private предоставляет доступ только внутри класса Motorcycle
            //motorcycle.weightPrivateProtected = 160;              совмещает вышеуказанные ограничения protected и private
            motorcycle.weightProtectedInternal = 160;

            motorcycle.colorPublic = "black";
            motorcycle.colorInternal = "black";
            //motorcycle.colorProtected = "black";                  модификатор доступа protected не предоставляет доступ к бъекту класса Motorcycle
            //motorcycle.colorPrivate = "black";                    модификатор доступа private предоставляет доступ только внутри класса Motorcycle
            motorcycle.colorProtectedInternal = "black";

            motorcycle.Start();
            //motorcycle.Stop();                                    модификатор доступа protected не предоставляет доступ к бъекту класса Motorcycle
            #endregion

            #region SportBike
            SportBike sportBike = new SportBike(manufacturer: "BMW");

            sportBike.BikeModel = "S1000 RR";

            //sportBike.Manufacturer = "";                          модификатор доступа private предоставляет доступ только внутри класса SportBike
            //sportBike.ManufacturerProtected = "";                 модификатор доступа protected не предоставляет доступ к бъекту класса SportBike
            sportBike.ManufacturerProtectedInternal = "";
            sportBike.ManufacturerInternal = "";

            speed = SportBike.MaxSpeedPublic;
            //speed = SportBike.MaxSpeedProtected;                  модификатор доступа protected не предоставляет доступ к бъекту класса SportBike
            //speed = SportBike.MaxSpeedPrivate;                    модификатор доступа private предоставляет доступ только внутри класса SportBike
            //speed = SportBike.MaxSpeedPrivateProtected;           совмещает вышеуказанные ограничения protected и private
            speed = SportBike.MaxSpeedInternal;
            speed = SportBike.MaxSpeedProtectedInternal;

            sportBike.weightPublic = 160;
            sportBike.weightInternal = 160;
            //sportBike.weightProtected = 160;                      модификатор доступа protected не предоставляет доступ к бъекту класса SportBike
            //sportBike.weightPrivate = 160;                        модификатор доступа private предоставляет доступ только внутри класса SportBike
            //sportBike.weightPrivateProtected = 160;               совмещает вышеуказанные ограничения protected и private
            sportBike.weightProtectedInternal = 160;

            sportBike.colorPublic = "black";
            sportBike.colorInternal = "black";
            //sportBike.colorProtected = "black";                   модификатор доступа protected не предоставляет доступ к бъекту класса SportBike
            //sportBike.colorPrivate = "black";                     модификатор доступа private предоставляет доступ только внутри класса SportBike
            sportBike.colorProtectedInternal = "black";

            sportBike.Start();
            //sportBike.Stop();                                     модификатор доступа protected не предоставляет доступ к бъекту класса SportBike
            #endregion

            Console.ReadLine();
        }

    }
}
