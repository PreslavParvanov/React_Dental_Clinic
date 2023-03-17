using DentalClinic.BL.Service;

namespace DentalClinic.BL.Models
{
    public class ReceptionCustomerViewModel
    {
        public Guid DoctorId { get; set; }
        public string DoctorName { get; set; } = null!;

        public DateTime DateTimeSchedule { get; set; }

        public string CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;

        public string CustomerEmail { get; set; } = null!;

        public string CustomerPhone { get; set; } = null!;

        public IEnumerable<DentalServiceViewModel> DentalServices { get; set; } = new List<DentalServiceViewModel>();
    }
}
