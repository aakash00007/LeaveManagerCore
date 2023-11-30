using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    LeaveRequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaveStatus = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.LeaveRequestId);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Approvals",
                columns: table => new
                {
                    ApprovalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LeaveRequestId = table.Column<int>(type: "int", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovalStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approvals", x => x.ApprovalId);
                    table.ForeignKey(
                        name: "FK_Approvals_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Approvals_LeaveRequests_LeaveRequestId",
                        column: x => x.LeaveRequestId,
                        principalTable: "LeaveRequests",
                        principalColumn: "LeaveRequestId");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName", "Priority" },
                values: new object[,]
                {
                    { "18dd2c16-7c16-47f3-ac8f-0ea9a1cc4160", "cd9d2ba9-bda4-4131-8d30-5726718e60e2", "RoleConfig", "Assistant Manager", "ASSISTANT MANAGER", 4 },
                    { "7eb86ba1-eafa-49db-b58b-87e2da0ea429", "562ebb7f-a7d8-42a6-b281-875bfd63ac64", "RoleConfig", "Employee", "EMPLOYEE", 1 },
                    { "8442a53b-a77a-4bd9-b3c9-33b5e570f375", "d902e7d2-238b-4f6f-9c5f-46f1583fd9e5", "RoleConfig", "Manager", "MANAGER", 3 },
                    { "a5877ffc-ff2f-4a2e-af53-7144c89b3ae7", "553131f6-c65d-406a-bfae-820f56703134", "RoleConfig", "Generl Manager", "GENERAL MANAGER", 5 },
                    { "c5a1999e-a895-4b43-a22c-3c26e8e4e97d", "e599f09c-1a8b-445d-a451-a6c5bbf0fa05", "RoleConfig", "Team Lead", "TEAM LEAD", 2 },
                    { "e01d34fc-74e2-4298-9367-36ccc116efc6", "3d1ea982-ed57-4b1f-97c7-9467c81ddf2c", "RoleConfig", "HR", "HR", 6 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "20811416-1ccb-440d-b2d7-cccfb739ac13", 0, "ef98c911-6a43-4e55-beec-7598384a2f4a", "employee@gmail.com", false, true, null, "Arun", "EMPLOYEE@GMAIL.COM", null, "AQAAAAEAACcQAAAAEL7+px7/pfAJD5OXTFp3mrQfPos94B+tW8ZJAcMwWbqVfpQ7qYf6lQ52cwMrHEvJOQ==", null, false, "4c6cd4d7-a3c2-4af4-9f23-a94e56b5da05", false, null },
                    { "5dbe310f-eb29-4ae2-adc3-8fe3376110ce", 0, "89366048-3b14-4b5c-946b-6aed0a78f780", "teamlead@gmail.com", false, true, null, "Aditya", "TEAMLEAD@GMAIL.COM", null, "AQAAAAEAACcQAAAAEPUqwvMQK1J2zF84Jth/bn/a3rDNPvqmG42M7EctwyEnBtbCW6D5AXXMvHyGHnXErQ==", null, false, "e5094357-ddca-42b1-92d0-88292361b102", false, null },
                    { "6d2e1388-75c0-4163-b8fa-d9137e68d100", 0, "8eb1920a-8b40-4bf2-9199-167a2abec10e", "genmanager@gmail.com", false, true, null, "Ajay", "GENMANAGER@GMAIL.COM", null, "AQAAAAEAACcQAAAAEPqBuHnvOjHrk1fqJ3tp7vpNa1EU/nx7EgbUXhlVW6NPbjh3E85fKulN1P8EdjNRfQ==", null, false, "3dac8f1e-9158-4bc2-9b43-61d153f2a14a", false, null },
                    { "95b2be27-f576-4c78-a817-ffecb7144c47", 0, "2c66ac8a-e077-4367-b04d-b2688594ad78", "hr77@gmail.com", false, true, null, "Rishi", "HR77@GMAIL.COM", null, "AQAAAAEAACcQAAAAEBXZBSxOuWEm0SAgHgjFYOhnJIpdy1GYUyYXiAgo2eMzYk9MDmkEtUS9Nkmi5DMC+w==", null, false, "76e1e415-f128-46c0-a3fe-422cfe81eda5", false, null },
                    { "f7a70c7f-6bad-4fb2-9a6c-2d5253b21008", 0, "e7f201b7-1e50-4a2c-b778-fbec5ac6e651", "manager@gmail.com", false, true, null, "Udit", "MANAGER@GMAIL.COM", null, "AQAAAAEAACcQAAAAELqR0JkSfSdYXmgeCmcd/rWN3mXlG8mJ86qZqDOinGKPmcCRkMIrNU+gU1EQuPX1fA==", null, false, "de2b07e3-2758-4253-85ac-1c21e16b221b", false, null },
                    { "fd04ef2d-de41-4e5a-979f-fc4c1f241dfa", 0, "77d73778-5457-4efd-b868-9e91aaab9fca", "astmanager@gmail.com", false, true, null, "Kiran", "ASTMANAGER@GMAIL.COM", null, "AQAAAAEAACcQAAAAEK3ElkV7OG/Nowz3RTSAfNUt+DUuRYRsYqTS7+E6mEvXi0RpL24Dw5hWkxSD4sSkow==", null, false, "348acc94-f71f-4e89-a03f-26357b8987fe", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7eb86ba1-eafa-49db-b58b-87e2da0ea429", "20811416-1ccb-440d-b2d7-cccfb739ac13" },
                    { "c5a1999e-a895-4b43-a22c-3c26e8e4e97d", "5dbe310f-eb29-4ae2-adc3-8fe3376110ce" },
                    { "a5877ffc-ff2f-4a2e-af53-7144c89b3ae7", "6d2e1388-75c0-4163-b8fa-d9137e68d100" },
                    { "e01d34fc-74e2-4298-9367-36ccc116efc6", "95b2be27-f576-4c78-a817-ffecb7144c47" },
                    { "8442a53b-a77a-4bd9-b3c9-33b5e570f375", "f7a70c7f-6bad-4fb2-9a6c-2d5253b21008" },
                    { "18dd2c16-7c16-47f3-ac8f-0ea9a1cc4160", "fd04ef2d-de41-4e5a-979f-fc4c1f241dfa" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_LeaveRequestId",
                table: "Approvals",
                column: "LeaveRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_UserId",
                table: "Approvals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_UserId",
                table: "LeaveRequests",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Approvals");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
