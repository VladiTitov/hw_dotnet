namespace HW05.Task04
{
    public class Address
    {
        public int House { get; }
        public string Street { get; }
        public Zipcode Zipcode { get; }

        public Address(string address)
        {
            string[] addressParts = address.Split(' ');
            House = int.Parse(addressParts[0]);
            int streetEndIndx = addressParts.Length - 2;
            Street = string.Join(' ', addressParts[1..streetEndIndx]);
            Zipcode = new Zipcode(addressParts[streetEndIndx..addressParts.Length]);
        }

        public override bool Equals(object obj)
        {
            Zipcode zipcode = (Zipcode) obj;
            return this.Zipcode.State.Equals(zipcode?.State) && 
                   this.Zipcode.ZipNums.Equals(zipcode?.ZipNums);
        }
    }
}
