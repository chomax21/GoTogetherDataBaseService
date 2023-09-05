namespace GoTogetherDataBaseService.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int Age { get; set; }
        public int Rating { get; set; }
        public DateTime RegDay { get; set; }

        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public UserProperties userProperties { get; set; }  = new UserProperties();
    }
}
