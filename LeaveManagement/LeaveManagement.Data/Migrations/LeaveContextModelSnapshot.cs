﻿// <auto-generated />
using System;
using LeaveManagement.Data.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    [DbContext(typeof(LeaveContext))]
    partial class LeaveContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("ApprovalReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ApprovalStatus")
                        .HasColumnType("int");

                    b.Property<int?>("LeaveRequestId")
                        .HasColumnType("int");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

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

                    b.Property<int>("ApprovalStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Priority")
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
                            ConcurrencyStamp = "4cb790a3-4c3d-44e6-9c32-78db65ddd0d6",
                            Email = "employee@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Arun",
                            NormalizedEmail = "EMPLOYEE@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJA+j5FeTV/4j9KVFapvQ62x+vRhConERuVjgVNizBc8RWBvHs+lieNDsLoLiVH4UA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "822c61cd-47d0-4177-b119-4c865e597791",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "5dbe310f-eb29-4ae2-adc3-8fe3376110ce",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9821d98b-178e-4189-8427-3dc8616e00c7",
                            Email = "teamlead@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Aditya",
                            NormalizedEmail = "TEAMLEAD@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIiwAD9Jar9Q72tjodPX0TqVIVbNf/DDcmSHDTNchS5P+ync+eDw7S9f6bbDEvQ5eA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "52170247-016f-4187-a197-bfc186305d4f",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "f7a70c7f-6bad-4fb2-9a6c-2d5253b21008",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "03ece2d3-8c22-4d48-b5ec-f75ec2c132bd",
                            Email = "manager@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Udit",
                            NormalizedEmail = "MANAGER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIjy58l+eV0rD9/M5aWtgvVHSO5qigBJRvo0dtH0JwtRnU+qI+fzPUK3vV1/KW8iQg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9bd4025a-8a9d-4873-af66-b6c8aa2b72d4",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "fd04ef2d-de41-4e5a-979f-fc4c1f241dfa",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0046a929-ad18-40ca-83af-8fd432739721",
                            Email = "astmanager@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Kiran",
                            NormalizedEmail = "ASTMANAGER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEP1bU4+FSTGv0tEyGvwThlYOBO8bF25j2Kupo9QUG7JoJ9Yd7SONSpnE0KK3RpaC8w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4d6a6f65-aff4-46d6-a118-f5fa7030ce5c",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "6d2e1388-75c0-4163-b8fa-d9137e68d100",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6bf09d33-b810-4eb1-96cb-7799238a1468",
                            Email = "genmanager@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Ajay",
                            NormalizedEmail = "GENMANAGER@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMh9EpnW1UfXv0pSdkl8lh9QDZkCJo4N3qVp5Z/7nJ6MAd+E/edWXrze2t2LlzpxVw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a5cfd72c-22fd-487a-9199-de17a938b1fc",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "95b2be27-f576-4c78-a817-ffecb7144c47",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b5f7b1bd-415f-4b6e-bba5-3f707b2d8719",
                            Email = "hr77@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            Name = "Rishi",
                            NormalizedEmail = "HR77@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHzEkqVzO5MCcNtf4xfBV+IkWuHw54WzdBK+b1Cq8nHuO8QhRFPwuMcU0bDbLQWp0g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "955cfe92-c048-485d-b57f-7bc38f8f8ac4",
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
                            ConcurrencyStamp = "ae1946da-7f0b-4385-bb0f-e7539748da59",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE",
                            Priority = 1
                        },
                        new
                        {
                            Id = "c5a1999e-a895-4b43-a22c-3c26e8e4e97d",
                            ConcurrencyStamp = "9db433b2-0ad6-47c0-a8ae-7548bfcb4b1c",
                            Name = "Team Lead",
                            NormalizedName = "TEAM LEAD",
                            Priority = 2
                        },
                        new
                        {
                            Id = "8442a53b-a77a-4bd9-b3c9-33b5e570f375",
                            ConcurrencyStamp = "ca87aef0-c7e1-4987-9392-22b3a72214d8",
                            Name = "Manager",
                            NormalizedName = "MANAGER",
                            Priority = 3
                        },
                        new
                        {
                            Id = "18dd2c16-7c16-47f3-ac8f-0ea9a1cc4160",
                            ConcurrencyStamp = "09cc452c-83f4-4428-a03d-22bffc1768ba",
                            Name = "Assistant Manager",
                            NormalizedName = "ASSISTANT MANAGER",
                            Priority = 4
                        },
                        new
                        {
                            Id = "a5877ffc-ff2f-4a2e-af53-7144c89b3ae7",
                            ConcurrencyStamp = "4bb71b48-f883-4380-9bd6-5023085a6bce",
                            Name = "General Manager",
                            NormalizedName = "GENERAL MANAGER",
                            Priority = 5
                        },
                        new
                        {
                            Id = "e01d34fc-74e2-4298-9367-36ccc116efc6",
                            ConcurrencyStamp = "52635bc0-90a6-4e86-82f3-50001bf57652",
                            Name = "HR",
                            NormalizedName = "HR",
                            Priority = 6
                        });
                });

            modelBuilder.Entity("LeaveManagement.Data.Models.Approval", b =>
                {
                    b.HasOne("LeaveManagement.Data.Models.LeaveRequest", "LeaveRequest")
                        .WithMany("Approvals")
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

            modelBuilder.Entity("LeaveManagement.Data.Models.LeaveRequest", b =>
                {
                    b.Navigation("Approvals");
                });
#pragma warning restore 612, 618
        }
    }
}
