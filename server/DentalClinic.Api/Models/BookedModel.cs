namespace DentalClinic.Api.Models
{
    public class BookedModel
    {
        public BookedModel()
        {

        }
        public Guid DoctorId { get; set; }

        public DateTime DateBooked { get; set; }
        public string User { get; set; }
    }
}
