namespace DentalClinic.Api.Models
{
    public class DoctorScheduleReportModel
    {
        public DoctorScheduleReportModel()
        {

        }

        public Guid DoctorId { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
