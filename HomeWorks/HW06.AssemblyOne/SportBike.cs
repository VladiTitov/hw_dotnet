namespace HW06.AssemblyOne
{
    public class SportBike : Motorcycle
    {
        public SportBike(string manufacturer) : base(manufacturer)
        {
            BikeModel = "SportBike";
            //Manufacturer = "";                модификатор private в деле
            weightPrivateProtected = 150;       //модификатор private установлен совместно с protected, который и срабатывает в данном случае
            Stop();                             //protected в деле
        }
    }
}
