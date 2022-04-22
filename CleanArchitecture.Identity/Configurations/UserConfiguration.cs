using CleanArchitecture.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(
                    new ApplicationUser
                    {
                        Id = "f1816951-5cad-4019-9757-9d00ae5465b8",
                        Email = "joseduquee@gmail.com",
                        NormalizedEmail = "joseduquee@gmail.com",
                        Name = "Alexander",
                        LastName = "Duque",
                        UserName = "admin",
                        NormalizedUserName = "admin",
                        PasswordHash = hasher.HashPassword(null, "Madrid2020*"),
                        EmailConfirmed = true
                    },
                    new ApplicationUser
                    {
                        Id = "fafc9d5e-b09e-4a3d-b5c9-3fb9117ed53a",
                        Email = "joseduqueep@hotmail.com",
                        NormalizedEmail = "joseduqueep@hotmail.com",
                        Name = "Antonio",
                        LastName = "Perez",
                        UserName = "antduq95",
                        NormalizedUserName = "antduq95",
                        PasswordHash = hasher.HashPassword(null, "Madrid2020*"),
                        EmailConfirmed = true
                    }
                );
        }
    }
}
