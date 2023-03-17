using DentalClinic.DB.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic.BL.Models
{
    public class DentalServiceViewModel
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        [MinLength(1)]
        public string ServiceName { get; set; } = null!;

        [MaxLength(1000)]
        public string? ServiceDescription { get; set; }

        [Required]

        public string Who { get; set; } = null!;

        [Required]
        public DateTime When { get; set; }
    }
}
