using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.BL.Models
{
    public class ReportDoctorCustomerViewModel
    {

        public string DoctorName { get; set; } = null!;

        public DateTime DateTimeSchedule { get; set; }

        public string? CustomerName { get; set; }

        public string? CustomerEmail { get; set; }

        public string? CustomerPhone { get; set; }
    }
}
