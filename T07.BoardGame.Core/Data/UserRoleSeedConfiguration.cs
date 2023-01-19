using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07.BoardGame.Core.Data
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "d6039682-54c4-434a-920a-d91b3888d18d",
                    UserId = "dd10f17b-6c30-43c8-b326-c69a807ba2c5",
                },




                new IdentityUserRole<string>
                {
                    RoleId = "12fc2c0e-99bf-447d-9b4d-45996a250f16",
                    UserId = "5c286ddc-e0fd-4a35-bada-c33ba1dc90ed",
                },

                new IdentityUserRole<string>
                {
                    RoleId = "12fc2c0e-99bf-447d-9b4d-45996a250f16",
                    UserId = "29a1edd8-8a04-4ad4-9cc3-a0402f533017",
                },
                new IdentityUserRole<string>
                {
                    RoleId = "12fc2c0e-99bf-447d-9b4d-45996a250f16",
                    UserId = "7d1cb70a-6c6f-4920-b353-30f5a97e9767",
                },

                new IdentityUserRole<string>
                {
                    RoleId = "12fc2c0e-99bf-447d-9b4d-45996a250f16",
                    UserId = "e6e01470-3dcd-41b3-9eac-b11cdc461330",
                },
                new IdentityUserRole<string>
                {
                    RoleId = "12fc2c0e-99bf-447d-9b4d-45996a250f16",
                    UserId = "a2d6f7a5-7249-407c-8518-effb9df83f4d",
                }
                
                );
        }
    }
}
