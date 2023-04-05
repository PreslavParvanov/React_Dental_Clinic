namespace DentalClinic.Api.Models
{
    public class BookedByDateModel
    {
        public BookedByDateModel()
        {

        }

        public Guid DoctorId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }   
    }
}
