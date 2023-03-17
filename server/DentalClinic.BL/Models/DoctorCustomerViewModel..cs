using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.BL.Models
{
    public class DoctorCustomerViewModel
    {

        [Required]
        public Guid DoctorId { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; } = new List<Doctor>();

        [Required]
        public DateTime DateTimeSchedule { get; set; }

        [Required]
        public string CustomerId { get; set; } = null!;

        [Required]
        public string CustomerName { get; set; } = null!;

        [Required]
        public string CustomerEmail { get; set; } = null!;

        [Required]
        public string CustomerPhone { get; set; } = null!;

        [Required]
        public bool IsBusy { get; set; }    
    }
}
