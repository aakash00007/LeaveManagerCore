using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18dd2c16-7c16-47f3-ac8f-0ea9a1cc4160",
                column: "ConcurrencyStamp",
                value: "1ad85c5b-ca93-4310-9e40-1b6406bcadb3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7eb86ba1-eafa-49db-b58b-87e2da0ea429",
                column: "ConcurrencyStamp",
                value: "8420b29b-6896-4caa-a7df-ae49a0cad38c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8442a53b-a77a-4bd9-b3c9-33b5e570f375",
                column: "ConcurrencyStamp",
                value: "b4ee0598-3a38-45be-bf6b-f6feea856019");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5877ffc-ff2f-4a2e-af53-7144c89b3ae7",
                column: "ConcurrencyStamp",
                value: "a120fcdd-d5a4-49d3-8c65-24a77a8acea3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5a1999e-a895-4b43-a22c-3c26e8e4e97d",
                column: "ConcurrencyStamp",
                value: "1d608cbb-63d5-492f-87d9-95975c6e69c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e01d34fc-74e2-4298-9367-36ccc116efc6",
                column: "ConcurrencyStamp",
                value: "fa40d58c-b7d5-463c-adb3-8d44feb11831");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20811416-1ccb-440d-b2d7-cccfb739ac13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2afe1797-cffb-42d4-ba65-53bbcd7213cf", "AQAAAAEAACcQAAAAEHbTzdjziUITlv/vLxtnBHUx5QTxMGKDJQZEUYLewQdFRQX7D6jydmYWtPweVSPCIQ==", "9843c2fd-5976-44b7-8286-d5694e063f0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dbe310f-eb29-4ae2-adc3-8fe3376110ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "722ac554-5152-44f2-9e17-ae8d81930df2", "AQAAAAEAACcQAAAAEHLf1ZbuFwg8ggEUj1ZsYk94CzwlKmw/zsHSij4MG1humPcfHk8LU9m+jOFFM+cIeQ==", "7aaa7e35-75e7-4285-8f68-416f8ec05374" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d2e1388-75c0-4163-b8fa-d9137e68d100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d279bcb6-5fb8-4f8a-8b35-85cd47d715c7", "AQAAAAEAACcQAAAAEBsqxulmFZKs3iDQDRzVPYifGZ8U7cR6sJF1Fg3gImm2IGGKsHw+3pYhdNnfzEbiYQ==", "6b3b4cb2-76f1-468f-b595-515670f7429f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95b2be27-f576-4c78-a817-ffecb7144c47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f9d7dde-ad84-4dbb-acd7-f77667d473f4", "AQAAAAEAACcQAAAAEPKuxIotwDrul5Nj32DXVcIQqDudpKfq/GdXDd8Fp9ztbJ2YYWjcgxTLk6owysW9TQ==", "3f75fa4a-e04d-4fa5-956e-4132f2d5d071" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7a70c7f-6bad-4fb2-9a6c-2d5253b21008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41b2e872-4e0a-4270-b264-25cf266bb81d", "AQAAAAEAACcQAAAAEKhRXHFr1Sa4QBMGfhlivxLcrIK6S1xmflQ3TTP2BbR19G5inCH/r5A/rXgkBZ51ew==", "8b9b45a9-ba3c-410b-bd0e-05950374feae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd04ef2d-de41-4e5a-979f-fc4c1f241dfa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "004118e6-56c6-42f1-af74-943d0d67d0fc", "AQAAAAEAACcQAAAAENGJ7Y58mnbNIe4o2XoYk/vc7GfyYqIoBrWsCdxMFTfyL+OLDTLWoc8r3GiooAAXfQ==", "aab03875-ee8b-4c20-888d-6c0ac1224a4a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18dd2c16-7c16-47f3-ac8f-0ea9a1cc4160",
                column: "ConcurrencyStamp",
                value: "cd9d2ba9-bda4-4131-8d30-5726718e60e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7eb86ba1-eafa-49db-b58b-87e2da0ea429",
                column: "ConcurrencyStamp",
                value: "562ebb7f-a7d8-42a6-b281-875bfd63ac64");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8442a53b-a77a-4bd9-b3c9-33b5e570f375",
                column: "ConcurrencyStamp",
                value: "d902e7d2-238b-4f6f-9c5f-46f1583fd9e5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5877ffc-ff2f-4a2e-af53-7144c89b3ae7",
                column: "ConcurrencyStamp",
                value: "553131f6-c65d-406a-bfae-820f56703134");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5a1999e-a895-4b43-a22c-3c26e8e4e97d",
                column: "ConcurrencyStamp",
                value: "e599f09c-1a8b-445d-a451-a6c5bbf0fa05");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e01d34fc-74e2-4298-9367-36ccc116efc6",
                column: "ConcurrencyStamp",
                value: "3d1ea982-ed57-4b1f-97c7-9467c81ddf2c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20811416-1ccb-440d-b2d7-cccfb739ac13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef98c911-6a43-4e55-beec-7598384a2f4a", "AQAAAAEAACcQAAAAEL7+px7/pfAJD5OXTFp3mrQfPos94B+tW8ZJAcMwWbqVfpQ7qYf6lQ52cwMrHEvJOQ==", "4c6cd4d7-a3c2-4af4-9f23-a94e56b5da05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dbe310f-eb29-4ae2-adc3-8fe3376110ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89366048-3b14-4b5c-946b-6aed0a78f780", "AQAAAAEAACcQAAAAEPUqwvMQK1J2zF84Jth/bn/a3rDNPvqmG42M7EctwyEnBtbCW6D5AXXMvHyGHnXErQ==", "e5094357-ddca-42b1-92d0-88292361b102" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d2e1388-75c0-4163-b8fa-d9137e68d100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8eb1920a-8b40-4bf2-9199-167a2abec10e", "AQAAAAEAACcQAAAAEPqBuHnvOjHrk1fqJ3tp7vpNa1EU/nx7EgbUXhlVW6NPbjh3E85fKulN1P8EdjNRfQ==", "3dac8f1e-9158-4bc2-9b43-61d153f2a14a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95b2be27-f576-4c78-a817-ffecb7144c47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c66ac8a-e077-4367-b04d-b2688594ad78", "AQAAAAEAACcQAAAAEBXZBSxOuWEm0SAgHgjFYOhnJIpdy1GYUyYXiAgo2eMzYk9MDmkEtUS9Nkmi5DMC+w==", "76e1e415-f128-46c0-a3fe-422cfe81eda5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7a70c7f-6bad-4fb2-9a6c-2d5253b21008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7f201b7-1e50-4a2c-b778-fbec5ac6e651", "AQAAAAEAACcQAAAAELqR0JkSfSdYXmgeCmcd/rWN3mXlG8mJ86qZqDOinGKPmcCRkMIrNU+gU1EQuPX1fA==", "de2b07e3-2758-4253-85ac-1c21e16b221b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd04ef2d-de41-4e5a-979f-fc4c1f241dfa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77d73778-5457-4efd-b868-9e91aaab9fca", "AQAAAAEAACcQAAAAEK3ElkV7OG/Nowz3RTSAfNUt+DUuRYRsYqTS7+E6mEvXi0RpL24Dw5hWkxSD4sSkow==", "348acc94-f71f-4e89-a03f-26357b8987fe" });
        }
    }
}
