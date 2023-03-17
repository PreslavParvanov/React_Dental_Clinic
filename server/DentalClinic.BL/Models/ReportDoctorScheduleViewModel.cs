using DentalClinic.DB.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.BL.Models
{
    public class ReportDoctorScheduleViewModel
    {
        public string DoctorName { get; set; } = null!;
        public DateTime ScheduleDateTime { get; set; }
        public string DayOfWeek { get; set; } = null!;
        public bool IsBusy { get; set; }

    }
}
