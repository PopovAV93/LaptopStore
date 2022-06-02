using System.ComponentModel.DataAnnotations;

namespace LaptopStore.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Enter your name")]
        [MaxLength(20, ErrorMessage = "The name must be less than 20 characters long")]
        [MinLength(3, ErrorMessage = "The name must be longer than 3 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}