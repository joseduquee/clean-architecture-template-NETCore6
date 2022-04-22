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
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "c48874e5-6676-42a0-9c54-6b91335be812",
                        UserId = "f1816951-5cad-4019-9757-9d00ae5465b8"
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "077fa688-4565-4c6a-bdbf-d5dd478c80ca",
                        UserId = "fafc9d5e-b09e-4a3d-b5c9-3fb9117ed53a"
                    }

                );
        }
    }
}
