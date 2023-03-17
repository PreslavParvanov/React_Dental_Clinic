using DentalClinic.DB.Data.Configuration;
using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DentalClinic.DB.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            modelBuilder.ApplyConfiguration(new DentalServiceConfiguration());
  

            modelBuilder.Entity<DoctorCustomer>(entity =>
            {
                entity.HasKey(dc => new { dc.DoctorId, dc.CustomerId, dc.DateTime });

                entity.HasOne(d => d.Doctors)
                    .WithMany(dc => dc.DoctorCustomers)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_DoctorCustomers_Doctors");

            });

            modelBuilder.Entity<DoctorSchedule>(entity =>
            {
                entity.HasKey(ds => new { ds.DoctorId, ds.ScheduleDateTime });

                entity.HasOne(d => d.Doctors)
                    .WithMany(ds => ds.DoctorSchedules)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_DoctorSchedules_Doctors");
            });

        }

        public DbSet<Doctor> Doctors { get; set; } = null!;
        public DbSet<DoctorCustomer> DoctorsCustomers { get; set; } = null!;
        public DbSet<DoctorSchedule> DoctorsSchedules { get; set; } = null!;
        public DbSet<DentalService> DentalServices { get; set; } = null!;

    }
}
