﻿// <auto-generated />
using System;
using LeaveManagement.Data.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    [DbContext(typeof(LeaveContext))]
    [Migration("20231116121803_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LeaveManagement.Data.Models.Approval", b =>
                {
                    b.Property<int>("ApprovalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApprovalId"), 1L, 1);

                    b.Property<int>("ApprovalStatus")
                        .HasColumnType("int");

                    b.Property<int?>("LeaveRequestId")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ApprovalId");

                    b.HasIndex("LeaveRequestId");

                    b.HasIndex("UserId");

                    b.ToTable("Approvals");
                });

            modelBuilder.Entity("LeaveManagement.Data.Models.LeaveRequest", b =>
                {
                    b.Property<int>("LeaveRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeaveRequestId"), 1L, 1);

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<int>("LeaveStatus")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LeaveRequestId");

                    b.HasIndex("UserId");

                    b.ToTable("LeaveRequests");
                });

            modelBuilder.Entity("LeaveManagement.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "20811416-1ccb-440d-b2d7-cccfb739ac13",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ef98c911-6a43-4e55-beec-7598384a2f4a",
                            Email = "employee@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Arun",
                            NormalizedEmail = "EMPLOYEE@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEL7+px7/pfAJD5OXTFp3mrQfPos94B+tW8ZJAcMwWbqVfpQ7qYf6lQ52cwMrHEvJOQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4c6cd4d7-a3c2-4af4-9f23-a94e56b5da05",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "5dbe310f-eb29-4ae2-adc3-8fe3376110ce",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "89366048-3b14-4b5c-946b-6aed0a78f780",
                            Email = "teamlead@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Aditya",
                            NormalizedEmail = "TEAMLEAD@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPUqwvMQK1J2zF84Jth/bn/a3rDNPvqmG42M7EctwyEnBtbCW6D5AXXMvHyGHnXErQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e5094357-ddca-42b1-92d0-88292361b102",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "f7a70c7f-6bad-4fb2-9a6c-2d5253b21008",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e7f201b7-1e50-4a2c-b778-fbec5ac6e651",
                            Email = "manager@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Udit",
                            NormalizedEmail = "MANAGER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELqR0JkSfSdYXmgeCmcd/rWN3mXlG8mJ86qZqDOinGKPmcCRkMIrNU+gU1EQuPX1fA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "de2b07e3-2758-4253-85ac-1c21e16b221b",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "fd04ef2d-de41-4e5a-979f-fc4c1f241dfa",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "77d73778-5457-4efd-b868-9e91aaab9fca",
                            Email = "astmanager@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Kiran",
                            NormalizedEmail = "ASTMANAGER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEK3ElkV7OG/Nowz3RTSAfNUt+DUuRYRsYqTS7+E6mEvXi0RpL24Dw5hWkxSD4sSkow==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "348acc94-f71f-4e89-a03f-26357b8987fe",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "6d2e1388-75c0-4163-b8fa-d9137e68d100",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8eb1920a-8b40-4bf2-9199-167a2abec10e",
                            Email = "genmanager@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Ajay",
                            NormalizedEmail = "GENMANAGER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPqBuHnvOjHrk1fqJ3tp7vpNa1EU/nx7EgbUXhlVW6NPbjh3E85fKulN1P8EdjNRfQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3dac8f1e-9158-4bc2-9b43-61d153f2a14a",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "95b2be27-f576-4c78-a817-ffecb7144c47",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2c66ac8a-e077-4367-b04d-b2688594ad78",
                            Email = "hr77@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Rishi",
                            NormalizedEmail = "HR77@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBXZBSxOuWEm0SAgHgjFYOhnJIpdy1GYUyYXiAgo2eMzYk9MDmkEtUS9Nkmi5DMC+w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "76e1e415-f128-46c0-a3fe-422cfe81eda5",
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "20811416-1ccb-440d-b2d7-cccfb739ac13",
                            RoleId = "7eb86ba1-eafa-49db-b58b-87e2da0ea429"
                        },
                        new
                        {
                            UserId = "5dbe310f-eb29-4ae2-adc3-8fe3376110ce",
                            RoleId = "c5a1999e-a895-4b43-a22c-3c26e8e4e97d"
                        },
                        new
                        {
                            UserId = "f7a70c7f-6bad-4fb2-9a6c-2d5253b21008",
                            RoleId = "8442a53b-a77a-4bd9-b3c9-33b5e570f375"
                        },
                        new
                        {
                            UserId = "fd04ef2d-de41-4e5a-979f-fc4c1f241dfa",
                            RoleId = "18dd2c16-7c16-47f3-ac8f-0ea9a1cc4160"
                        },
                        new
                        {
                            UserId = "6d2e1388-75c0-4163-b8fa-d9137e68d100",
                            RoleId = "a5877ffc-ff2f-4a2e-af53-7144c89b3ae7"
                        },
                        new
                        {
                            UserId = "95b2be27-f576-4c78-a817-ffecb7144c47",
                            RoleId = "e01d34fc-74e2-4298-9367-36ccc116efc6"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LeaveManagement.Data.Models.RoleConfig", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("RoleConfig");

                    b.HasData(
                        new
                        {
                            Id = "7eb86ba1-eafa-49db-b58b-87e2da0ea429",
                            ConcurrencyStamp = "562ebb7f-a7d8-42a6-b281-875bfd63ac64",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE",
                            Priority = 1
                        },
                        new
                        {
                            Id = "c5a1999e-a895-4b43-a22c-3c26e8e4e97d",
                            ConcurrencyStamp = "e599f09c-1a8b-445d-a451-a6c5bbf0fa05",
                            Name = "Team Lead",
                            NormalizedName = "TEAM LEAD",
                            Priority = 2
                        },
                        new
                        {
                            Id = "8442a53b-a77a-4bd9-b3c9-33b5e570f375",
                            ConcurrencyStamp = "d902e7d2-238b-4f6f-9c5f-46f1583fd9e5",
                            Name = "Manager",
                            NormalizedName = "MANAGER",
                            Priority = 3
                        },
                        new
                        {
                            Id = "18dd2c16-7c16-47f3-ac8f-0ea9a1cc4160",
                            ConcurrencyStamp = "cd9d2ba9-bda4-4131-8d30-5726718e60e2",
                            Name = "Assistant Manager",
                            NormalizedName = "ASSISTANT MANAGER",
                            Priority = 4
                        },
                        new
                        {
                            Id = "a5877ffc-ff2f-4a2e-af53-7144c89b3ae7",
                            ConcurrencyStamp = "553131f6-c65d-406a-bfae-820f56703134",
                            Name = "Generl Manager",
                            NormalizedName = "GENERAL MANAGER",
                            Priority = 5
                        },
                        new
                        {
                            Id = "e01d34fc-74e2-4298-9367-36ccc116efc6",
                            ConcurrencyStamp = "3d1ea982-ed57-4b1f-97c7-9467c81ddf2c",
                            Name = "HR",
                            NormalizedName = "HR",
                            Priority = 6
                        });
                });

            modelBuilder.Entity("LeaveManagement.Data.Models.Approval", b =>
                {
                    b.HasOne("LeaveManagement.Data.Models.LeaveRequest", "LeaveRequest")
                        .WithMany()
                        .HasForeignKey("LeaveRequestId");

                    b.HasOne("LeaveManagement.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("LeaveRequest");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LeaveManagement.Data.Models.LeaveRequest", b =>
                {
                    b.HasOne("LeaveManagement.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LeaveManagement.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LeaveManagement.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeaveManagement.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LeaveManagement.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}