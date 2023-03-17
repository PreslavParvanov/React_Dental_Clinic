using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DentalClinic.DB.Data.Models
{
    public class DoctorSchedule
    {
        [Required]
        public Guid DoctorId { get; set; }
        public Doctor Doctors { get; set; } = null!;

        [Required]
        public DateTime ScheduleDateTime { get; set; }

        [Required]
        public bool IsBusy { get; set; }

        [Required]
        public string Who { get; set; } = null!;

        [Required]
        public DateTime When { get; set; }

    }
}
