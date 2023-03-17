using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DentalClinic.DB.Data.Models
{
    public class DentalService
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string ServiceName { get; set; } = null!;

        [MaxLength(1000)]
        public string? ServiceDescription { get; set; }

        [Required]

        public string Who { get; set; } = null!;


        [Required]
        public DateTime When { get; set; }
    }
}
