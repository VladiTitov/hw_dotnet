namespace HW07.Booking.Com.Models
{
    class User
    {
        public string Mail { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public User(string mail, string name, string password)
        {
            Mail = mail;
            Name = name;
            Password = password;
        }

        public void ChangePassword(string password) => Password = password;
    }
}
