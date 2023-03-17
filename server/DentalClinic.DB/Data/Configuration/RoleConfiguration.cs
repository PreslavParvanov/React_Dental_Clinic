using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentalClinic.DB.Data.Configuration
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {

        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(CreateRoles());
        }

        private List<Role> CreateRoles()
        {
            List<Role> roles = new List<Role>()
             {
                new Role
                {
                    Id="3a3caf80-c223-498d-901b-c8fc4504bb3f",
                    Name="Admin",
                    NormalizedName="ADMIN"
                }
            };

            return roles;
        }
    }
}


