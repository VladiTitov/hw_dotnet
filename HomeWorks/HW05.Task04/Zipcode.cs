namespace HW05.Task04
{
    public class Zipcode
    {
        public string State { get; }
        public int ZipNums { get; }

        public Zipcode(string[] zipcodeParts)
        {
            State = zipcodeParts[0];
            ZipNums = int.Parse(zipcodeParts[1]);
        }
    }
}
