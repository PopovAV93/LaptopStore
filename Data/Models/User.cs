using LaptopStore.Data.Enum;

namespace LaptopStore.Data.Models
{
    public class User
    {
        public long id { get; set; }
        
        public string password { get; set; }

        public string name { get; set; }

        public string lastName { get; set; }

        public Role role { get; set; }
        
        public Profile profile { get; set; }
    }
}