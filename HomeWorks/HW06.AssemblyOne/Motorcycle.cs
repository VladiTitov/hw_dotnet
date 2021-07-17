namespace HW06.AssemblyOne
{
    public class Motorcycle
    {
        private string Manufacturer { get; set; }
        protected string ManufacturerProtected { get; set; }
        protected internal string ManufacturerProtectedInternal { get; set; }
        internal string ManufacturerInternal { get; set; }

        private string _bikeModel;
        public string BikeModel
        {
            get => _bikeModel;
            set => _bikeModel = value;
        }

        public const int MaxSpeedPublic = 300;
        protected const int MaxSpeedProtected = 300;
        private const int MaxSpeedPrivate = 400;
        private protected const int MaxSpeedPrivateProtected = 400;
        internal const int MaxSpeedInternal = 400;
        protected internal const int MaxSpeedProtectedInternal = 400;

        public int weightPublic = 150;
        internal int weightInternal = 150;
        protected int weightProtected = 150;
        private int weightPrivate = 150;
        private protected int weightPrivateProtected = 150;
        protected internal int weightProtectedInternal = 150;

        public string colorPublic = "red";
        internal string colorInternal = "red";
        protected string colorProtected = "red";
        private string colorPrivate = "red";
        protected internal string colorProtectedInternal = "red";

        public Motorcycle(string manufacturer) =>
            Manufacturer = manufacturer;

        public void Start() { }

        protected void Stop() { }
    }
}
