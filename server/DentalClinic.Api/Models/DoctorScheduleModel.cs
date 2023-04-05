namespace DentalClinic.Api.Models
{
    public class DoctorScheduleModel
    {
        public DoctorScheduleModel()
        {

        }

        public Guid DoctorId { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
