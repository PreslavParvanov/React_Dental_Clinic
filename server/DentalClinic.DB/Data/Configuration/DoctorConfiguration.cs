using DentalClinic.DB.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentalClinic.DB.Data.Configuration
{
    internal class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {

        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasData(CreateDoctors());
        }

        private List<Doctor> CreateDoctors()
        {
            List<Doctor> doctors = new List<Doctor>()
             {
                new Doctor
                {
                    Id = Guid.NewGuid(),
                    Name = "Dr. Radeva",
                    Qualification = "Dentist",
                    MoreInfo = "Doctor Radeva has 5 years of experience as a dentist.",
                    IsActive = 1,
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now,
                    ImageUrl="https://res.cloudinary.com/ddfrnob2x/image/upload/v1670968085/avatar_nifdc5.jpg"
                },
                new Doctor
                {
                    Id = Guid.NewGuid(),
                    Name = "Dr. Valeva",
                    Qualification = "Оrthodontist",
                    MoreInfo = "Doctor Valeva has 3 years of experience as a оrthodontist.",
                    IsActive = 1,
                    Who="0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                    When = DateTime.Now,
                    ImageUrl="https://res.cloudinary.com/ddfrnob2x/image/upload/v1670968085/avatar_nifdc5.jpg"
                }
            };

            return doctors;
        }
    }
}


