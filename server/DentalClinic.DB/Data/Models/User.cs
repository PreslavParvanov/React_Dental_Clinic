using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.DB.Data.Models
{
    public class User : IdentityUser
    {

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;


        [Range(0, 1)]
        public byte IsActive { get; set; }

        [Required]
        public DateTime When { get; set; } 

        [Required]
        public DateTime LastLogin { get; set; }

        public string Discriminator { get; set; } = null!;
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<DoctorCustomer> DoctorCustomers { get; set; } = new List<DoctorCustomer>();
        public List<DoctorSchedule> DoctorSchedules { get; set; } = new List<DoctorSchedule>();

        public List<DentalService> DentalServices { get; set; } = new List<DentalService>();

    }
}
