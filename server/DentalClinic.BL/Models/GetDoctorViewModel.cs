using System.ComponentModel.DataAnnotations;

namespace DentalClinic.BL.Models
{
    public class GetDoctorViewModel
    {
        [Required]
        public Guid Id { get; set; }
        
        [Required]
        [MinLength(1), MaxLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [MinLength(1),MaxLength(100)]
        public string Qualification { get; set; } = null!;

        [Required]
        [MinLength(1), MaxLength(1000)]
        public string MoreInfo { get; set; } = null!;

        [Required]
        [MinLength(5), MaxLength(1000)]
        public string ImageUrl { get; set; } = null!;

    }
}
