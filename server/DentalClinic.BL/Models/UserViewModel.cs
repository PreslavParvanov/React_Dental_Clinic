using System.ComponentModel.DataAnnotations;

namespace DentalClinic.BL.Models
{
    public class UserViewModel
    {
        

        [Required]
        [MinLength(1),MaxLength(50)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        public string Email { get; set; } = null!;

        [Required]
        [MinLength(1), MaxLength(1000)]
        public string Password { get; set; } = null!;
    }
}
