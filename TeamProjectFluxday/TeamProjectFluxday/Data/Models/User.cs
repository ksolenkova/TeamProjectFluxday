namespace SeleniumWebDriver.Data.Models
{
    public class User
    {
        public User(string email, string password, string name)
        {
            Email = email;
            Password = password;
            Name = name;
        }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }
    }
}
