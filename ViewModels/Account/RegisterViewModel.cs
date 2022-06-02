using System.ComponentModel.DataAnnotations;

namespace LaptopStore.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Enter your name")]
        [MaxLength(20, ErrorMessage = "The name must be less than 20 characters long")]
        [MinLength(3, ErrorMessage = "The name must be longer than 3 characters")]
        public string Name { get; set; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter your password")]
        [MinLength(6, ErrorMessage = "Password must be longer than 6 characters")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirm the password")]
        [Compare("password", ErrorMessage = "Passwords do not match")]
        public string PasswordConfirm { get; set; }
    }
}