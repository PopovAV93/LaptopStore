using System.ComponentModel.DataAnnotations;

namespace LaptopStore.ViewModels
{
    public class ProfileViewModel
    {
        public long Id { get; set; }
        
        [Required(ErrorMessage = "Enter your age")]
        [Range(0, 150, ErrorMessage = "age range must be between 0 and 150")]
        public short Age { get; set; }
        
        [Required(ErrorMessage = "Enter your address")]
        [MinLength(5, ErrorMessage = "The minimum length must be greater than 5 characters")] 
        [MaxLength(250, ErrorMessage = "The maximum length must be less than 250 characters")]
        public string Address { get; set; }
    }
}