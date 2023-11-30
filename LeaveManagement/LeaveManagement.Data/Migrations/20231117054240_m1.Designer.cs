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
    [Migration("20231117054240_m1")]
    partial class m1
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

                    b.Property<int>("Priority")
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
                            ConcurrencyStamp = "2afe1797-cffb-42d4-ba65-53bbcd7213cf",
                            Email = "employee@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Arun",
                            NormalizedEmail = "EMPLOYEE@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHbTzdjziUITlv/vLxtnBHUx5QTxMGKDJQZEUYLewQdFRQX7D6jydmYWtPweVSPCIQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9843c2fd-5976-44b7-8286-d5694e063f0c",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "5dbe310f-eb29-4ae2-adc3-8fe3376110ce",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "722ac554-5152-44f2-9e17-ae8d81930df2",
                            Email = "teamlead@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Aditya",
                            NormalizedEmail = "TEAMLEAD@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHLf1ZbuFwg8ggEUj1ZsYk94CzwlKmw/zsHSij4MG1humPcfHk8LU9m+jOFFM+cIeQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7aaa7e35-75e7-4285-8f68-416f8ec05374",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "f7a70c7f-6bad-4fb2-9a6c-2d5253b21008",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "41b2e872-4e0a-4270-b264-25cf266bb81d",
                            Email = "manager@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Udit",
                            NormalizedEmail = "MANAGER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKhRXHFr1Sa4QBMGfhlivxLcrIK6S1xmflQ3TTP2BbR19G5inCH/r5A/rXgkBZ51ew==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8b9b45a9-ba3c-410b-bd0e-05950374feae",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "fd04ef2d-de41-4e5a-979f-fc4c1f241dfa",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "004118e6-56c6-42f1-af74-943d0d67d0fc",
                            Email = "astmanager@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Kiran",
                            NormalizedEmail = "ASTMANAGER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENGJ7Y58mnbNIe4o2XoYk/vc7GfyYqIoBrWsCdxMFTfyL+OLDTLWoc8r3GiooAAXfQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "aab03875-ee8b-4c20-888d-6c0ac1224a4a",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "6d2e1388-75c0-4163-b8fa-d9137e68d100",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d279bcb6-5fb8-4f8a-8b35-85cd47d715c7",
                            Email = "genmanager@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Ajay",
                            NormalizedEmail = "GENMANAGER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBsqxulmFZKs3iDQDRzVPYifGZ8U7cR6sJF1Fg3gImm2IGGKsHw+3pYhdNnfzEbiYQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6b3b4cb2-76f1-468f-b595-515670f7429f",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "95b2be27-f576-4c78-a817-ffecb7144c47",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9f9d7dde-ad84-4dbb-acd7-f77667d473f4",
                            Email = "hr77@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Rishi",
                            NormalizedEmail = "HR77@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPKuxIotwDrul5Nj32DXVcIQqDudpKfq/GdXDd8Fp9ztbJ2YYWjcgxTLk6owysW9TQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3f75fa4a-e04d-4fa5-956e-4132f2d5d071",
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
                            ConcurrencyStamp = "8420b29b-6896-4caa-a7df-ae49a0cad38c",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE",
                            Priority = 1
                        },
                        new
                        {
                            Id = "c5a1999e-a895-4b43-a22c-3c26e8e4e97d",
                            ConcurrencyStamp = "1d608cbb-63d5-492f-87d9-95975c6e69c8",
                            Name = "Team Lead",
                            NormalizedName = "TEAM LEAD",
                            Priority = 2
                        },
                        new
                        {
                            Id = "8442a53b-a77a-4bd9-b3c9-33b5e570f375",
                            ConcurrencyStamp = "b4ee0598-3a38-45be-bf6b-f6feea856019",
                            Name = "Manager",
                            NormalizedName = "MANAGER",
                            Priority = 3
                        },
                        new
                        {
                            Id = "18dd2c16-7c16-47f3-ac8f-0ea9a1cc4160",
                            ConcurrencyStamp = "1ad85c5b-ca93-4310-9e40-1b6406bcadb3",
                            Name = "Assistant Manager",
                            NormalizedName = "ASSISTANT MANAGER",
                            Priority = 4
                        },
                        new
                        {
                            Id = "a5877ffc-ff2f-4a2e-af53-7144c89b3ae7",
                            ConcurrencyStamp = "a120fcdd-d5a4-49d3-8c65-24a77a8acea3",
                            Name = "Generl Manager",
                            NormalizedName = "GENERAL MANAGER",
                            Priority = 5
                        },
                        new
                        {
                            Id = "e01d34fc-74e2-4298-9367-36ccc116efc6",
                            ConcurrencyStamp = "fa40d58c-b7d5-463c-adb3-8d44feb11831",
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
