using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement.Data.Models
{
    public static class ModelBuilderExtention
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            modelBuilder.Entity<RoleConfig>().HasData(
                new RoleConfig
                {
                    Id = "7eb86ba1-eafa-49db-b58b-87e2da0ea429",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE",
                    Priority = 1,
                },
                new RoleConfig
                {
                    Id = "c5a1999e-a895-4b43-a22c-3c26e8e4e97d",
                    Name = "Team Lead",
                    NormalizedName = "TEAM LEAD",
                    Priority = 2,
                },
                new RoleConfig
                {
                    Id = "8442a53b-a77a-4bd9-b3c9-33b5e570f375",
                    Name = "Manager",
                    NormalizedName = "MANAGER",
                    Priority = 3,
                },
                new RoleConfig
                {
                    Id = "18dd2c16-7c16-47f3-ac8f-0ea9a1cc4160",
                    Name = "Assistant Manager",
                    NormalizedName = "ASSISTANT MANAGER",
                    Priority = 4,
                },
                new RoleConfig
                {
                    Id = "a5877ffc-ff2f-4a2e-af53-7144c89b3ae7",
                    Name = "General Manager",
                    NormalizedName = "GENERAL MANAGER",
                    Priority = 5,
                },
                new RoleConfig
                {
                    Id = "e01d34fc-74e2-4298-9367-36ccc116efc6",
                    Name = "HR",
                    NormalizedName = "HR",
                    Priority = 6,
                }
                );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = "20811416-1ccb-440d-b2d7-cccfb739ac13",
                    Name = "Arun",
                    Email = "employee@gmail.com",
                    NormalizedEmail = "EMPLOYEE@GMAIL.COM",
                    PasswordHash = passwordHasher.HashPassword(null,"Employee@123"),
                    LockoutEnabled = true
                },
                new User
                {
                    Id = "5dbe310f-eb29-4ae2-adc3-8fe3376110ce",
                    Name = "Aditya",
                    Email = "teamlead@gmail.com",
                    NormalizedEmail = "TEAMLEAD@GMAIL.COM",
                    PasswordHash = passwordHasher.HashPassword(null, "Teamlead@123"),
                    LockoutEnabled = true
                },
                new User
                {
                    Id = "f7a70c7f-6bad-4fb2-9a6c-2d5253b21008",
                    Name = "Udit",
                    Email = "manager@gmail.com",
                    NormalizedEmail = "MANAGER@GMAIL.COM",
                    PasswordHash = passwordHasher.HashPassword(null, "Manager@123"),
                    LockoutEnabled = true
                },
                new User
                {
                    Id = "fd04ef2d-de41-4e5a-979f-fc4c1f241dfa",
                    Name = "Kiran",
                    Email = "astmanager@gmail.com",
                    NormalizedEmail = "ASTMANAGER@GMAIL.COM",
                    PasswordHash = passwordHasher.HashPassword(null, "Astmanager@123"),
                    LockoutEnabled = true
                },
                new User
                {
                    Id = "6d2e1388-75c0-4163-b8fa-d9137e68d100",
                    Name = "Ajay",
                    Email = "genmanager@gmail.com",
                    NormalizedEmail = "GENMANAGER@GMAIL.COM",
                    PasswordHash = passwordHasher.HashPassword(null, "Genmanager@123"),
                    LockoutEnabled = true
                },
                new User
                {
                    Id = "95b2be27-f576-4c78-a817-ffecb7144c47",
                    Name = "Rishi",
                    Email = "hr77@gmail.com",
                    NormalizedEmail = "HR77@GMAIL.COM",
                    PasswordHash = passwordHasher.HashPassword(null, "Hr77@123"),
                    LockoutEnabled = true
                }
                );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "20811416-1ccb-440d-b2d7-cccfb739ac13",
                    RoleId = "7eb86ba1-eafa-49db-b58b-87e2da0ea429"
                },
                new IdentityUserRole<string>
                {
                    UserId = "5dbe310f-eb29-4ae2-adc3-8fe3376110ce",
                    RoleId = "c5a1999e-a895-4b43-a22c-3c26e8e4e97d"
                },
                new IdentityUserRole<string>
                {
                    UserId = "f7a70c7f-6bad-4fb2-9a6c-2d5253b21008",
                    RoleId = "8442a53b-a77a-4bd9-b3c9-33b5e570f375"
                },
                new IdentityUserRole<string>
                {
                    UserId = "fd04ef2d-de41-4e5a-979f-fc4c1f241dfa",
                    RoleId = "18dd2c16-7c16-47f3-ac8f-0ea9a1cc4160"
                },
                new IdentityUserRole<string>
                {
                    UserId = "6d2e1388-75c0-4163-b8fa-d9137e68d100",
                    RoleId = "a5877ffc-ff2f-4a2e-af53-7144c89b3ae7"
                },
                new IdentityUserRole<string>
                {
                    UserId = "95b2be27-f576-4c78-a817-ffecb7144c47",
                    RoleId = "e01d34fc-74e2-4298-9367-36ccc116efc6"
                }
                );
        }
    }
}
