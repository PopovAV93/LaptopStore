namespace LaptopStore.Data.Models
{
    public class Profile
    {
        public long id { get; set; }
        
        public string address { get; set; }
        
        public short age { get; set; }

        public long userId { get; set; }
        
        public User user { get; set; }
    }
}