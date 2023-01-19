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
    public class UserSeedConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var hasher = new PasswordHasher<IdentityUser>();
            builder.HasData(
                new IdentityUser
                {
                    Id = "dd10f17b-6c30-43c8-b326-c69a807ba2c5",
                    Email = "thanha1@admin.com",
                    NormalizedEmail = "THANHA1@ADMIN.COM",
                    UserName = "thanha1@admin.com",
                    NormalizedUserName = "THANHA1@ADMIN.COM",
                    PasswordHash = hasher.HashPassword(null, "Abc@123456"),
                    EmailConfirmed = true,
                },

                new IdentityUser
                {
                    Id = "5c286ddc-e0fd-4a35-bada-c33ba1dc90ed",
                    Email = "thanhu1@user.com",
                    NormalizedEmail = "THANHU1@USER.COM",
                    UserName = "thanhu1@user.com",
                    NormalizedUserName = "THANHU1@USER.COM",
                    PasswordHash = hasher.HashPassword(null, "Abc@123456"),
                    EmailConfirmed = true,
                },
                new IdentityUser
                {
                    Id = "29a1edd8-8a04-4ad4-9cc3-a0402f533017",
                    Email = "thanhu2@user.com",
                    NormalizedEmail = "THANHU2@USER.COM",
                    UserName = "thanhu2@user.com",
                    NormalizedUserName = "THANHU2@USER.COM",
                    PasswordHash = hasher.HashPassword(null, "Abc@123456"),
                    EmailConfirmed = true,
                },
                 new IdentityUser
                  {
                      Id = "7d1cb70a-6c6f-4920-b353-30f5a97e9767",
                      Email = "thanhu3@user.com",
                      NormalizedEmail = "THANHU3@USER.COM",
                      UserName = "thanhu3@user.com",
                      NormalizedUserName = "THANHU3@USER.COM",
                      PasswordHash = hasher.HashPassword(null, "Abc@123456"),
                      EmailConfirmed = true,
                  },
                 new IdentityUser
                    {
                        Id = "e6e01470-3dcd-41b3-9eac-b11cdc461330",
                        Email = "thanhu4@user.com",
                        NormalizedEmail = "THANHU4@USER.COM",
                        UserName = "thanhu4@user.com",
                        NormalizedUserName = "THANHU4@USER.COM",
                        PasswordHash = hasher.HashPassword(null, "Abc@123456"),
                        EmailConfirmed = true,
                    },
                 new IdentityUser
                    {
                        Id = "a2d6f7a5-7249-407c-8518-effb9df83f4d",
                        Email = "thanhu5@user.com",
                        NormalizedEmail = "THANHU5@USER.COM",
                        UserName = "thanhu5@user.com",
                        NormalizedUserName = "THANHU5@USER.COM",
                        PasswordHash = hasher.HashPassword(null, "Abc@123456"),
                        EmailConfirmed = true,
                    }

                );
        }
    }
}
