using System.ComponentModel.DataAnnotations;

namespace LaptopStore.ViewModels
{
    public class UserViewModel
    {
        public long Id { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public short Age { get; set; }
        
        public string Address { get; set; }
    }
}