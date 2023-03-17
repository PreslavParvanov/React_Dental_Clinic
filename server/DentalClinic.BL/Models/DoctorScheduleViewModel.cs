using DentalClinic.DB.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.BL.Models
{
    public class DoctorScheduleViewModel
    {
        [Required]
        public Guid DoctorId { get; set; }

        public IEnumerable<Doctor> Doctors { get; set; } = new List<Doctor>();

        [Required]
        [Range(typeof(DateTime), "01/01/2022", "01/01/2100", ErrorMessage = "Date is out of Range")]
        public DateTime startDate { get; set; }

        [Required]
        [Range(typeof(DateTime), "01/01/2022", "01/01/2100", ErrorMessage = "Date is out of Range")]
        public DateTime endDate { get; set; }

        [Required]
        public string Who { get; set; } = null!;

        public bool IsBusy { get; set; }

    }
}
