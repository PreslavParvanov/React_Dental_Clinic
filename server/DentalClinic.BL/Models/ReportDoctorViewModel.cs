using System.ComponentModel.DataAnnotations;

namespace DentalClinic.BL.Models
{
    public class ReportDoctorViewModel
    {
        public string Name { get; set; } = null!;
        public string Qualification { get; set; } = null!;
        public string MoreInfo { get; set; } = null!;
        public byte IsActive { get; set; }
    }
}
