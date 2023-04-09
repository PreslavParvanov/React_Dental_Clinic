using DentalClinic.DB.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Api.Models
{
    public class DoctorScheduleModel
    {
        [Required]
        public Guid DoctorId { get; set; }

        [Required]
        [Range(typeof(DateTime), "01/01/2022", "01/01/2100", ErrorMessage = "Date is out of Range")]
        public DateTime startDate { get; set; }

        [Required]
        [Range(typeof(DateTime), "01/01/2022", "01/01/2100", ErrorMessage = "Date is out of Range")]
        public DateTime endDate { get; set; }

        public string startTime { get; set; }

        public string endTime { get; set; }

        [Required]
        public string Who { get; set; } = null!;

        public bool IsBusy { get; set; }
    }
}
