using DentalClinic.DB.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DentalClinic.DB.Data.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<User> CreateUsers()
        {
            var users = new List<User>();
            var hasher = new PasswordHasher<User>();

            var user = new User()
            {
                Id = "0f14ce82-fd75-4d7e-b5c1-6eaccb374faa",
                FirstName = "admin",
                LastName = "admin",
                IsActive = 1,
                When = DateTime.Now,
                LastLogin = DateTime.Now,
                UserName = "admin@admin.com",
                Email = "admin@admin.com",
                EmailConfirmed = true,
                
            };

            user.PasswordHash =
                hasher.HashPassword(user, "Admin@123");

            users.Add(user);

            return users;
        }
    }
}


