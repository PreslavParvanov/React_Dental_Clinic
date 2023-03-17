using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DentalClinic.DB.Data.Models
{
    public class DoctorCustomer
    {

        [Required]
        public Guid DoctorId { get; set; }

        [Required]
        public Doctor Doctors { get; set; } = null!;

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public string CustomerId { get; set; } = null!;

        [Required]
        public string CustomerName { get; set; } = null!;
        
        [Required]
        public string CustomerEmail { get; set; } = null!;

        [Required]
        public string CustomerPhone { get; set; } = null!;

        [Required]
        public DateTime When { get; set; }

    }
}
