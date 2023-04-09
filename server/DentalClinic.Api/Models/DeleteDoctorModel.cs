namespace DentalClinic.Api.Models
{
    public class DeleteDoctorModel
    {
        public Guid DoctorId { get; set; }
        public string Who { get; set; } = null!;
    }
}
