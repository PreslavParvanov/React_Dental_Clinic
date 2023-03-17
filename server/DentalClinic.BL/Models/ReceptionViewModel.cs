using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.BL.Models
{
    public class ReceptionViewModel
    {
        public Guid DoctorId { get; set; }
        public string DoctorName { get; set; } = null!;

        public DateTime DateTimeSchedule { get; set; }

        public string CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;

        public string CustomerEmail { get; set; } = null!;

        public string CustomerPhone { get; set; } = null!;
    }
}
