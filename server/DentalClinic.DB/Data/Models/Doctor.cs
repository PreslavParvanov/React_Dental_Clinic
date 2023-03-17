using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DentalClinic.DB.Data.Models
{
    public class Doctor
    {
        [Key]
        public Guid Id { get; set; }
        public List<DoctorCustomer> DoctorCustomers { get; set; } = new List<DoctorCustomer>();
        public List<DoctorSchedule> DoctorSchedules { get; set; } = new List<DoctorSchedule>();

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Qualification { get; set; } = null!;
        [Required]
        public string MoreInfo { get; set; } = null!;

        [Range(0,1)]
        public byte IsActive { get; set; }

        [Required]
        public string Who { get; set; } = null!;

        [Required]
        public DateTime When { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;
    }
}
