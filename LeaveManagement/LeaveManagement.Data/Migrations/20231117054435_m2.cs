using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Priority",
                table: "LeaveRequests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18dd2c16-7c16-47f3-ac8f-0ea9a1cc4160",
                column: "ConcurrencyStamp",
                value: "1463659f-f428-4e7c-a8b9-efade789c5c5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7eb86ba1-eafa-49db-b58b-87e2da0ea429",
                column: "ConcurrencyStamp",
                value: "0c505844-802d-4330-bfab-f671ba78164e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8442a53b-a77a-4bd9-b3c9-33b5e570f375",
                column: "ConcurrencyStamp",
                value: "58317d15-fdba-4a53-b204-79d472ce4560");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5877ffc-ff2f-4a2e-af53-7144c89b3ae7",
                column: "ConcurrencyStamp",
                value: "79b5ccbc-dfc8-4d15-91a6-76b664026c8d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5a1999e-a895-4b43-a22c-3c26e8e4e97d",
                column: "ConcurrencyStamp",
                value: "36f89311-a218-426b-820e-f467fce50f67");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e01d34fc-74e2-4298-9367-36ccc116efc6",
                column: "ConcurrencyStamp",
                value: "6f739ab7-ae63-4985-9c95-0f1eef7aa884");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20811416-1ccb-440d-b2d7-cccfb739ac13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eca870cd-3635-43ec-a870-8531cecc7b9c", "AQAAAAEAACcQAAAAEBheXP0G3NWbecFXFFZXqB/jzuSS7Tet7Es+lcO2ItlyLitGf53/hWbTtZW59VsTSQ==", "91fd5600-ec6b-4296-bd3d-daf09256322c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dbe310f-eb29-4ae2-adc3-8fe3376110ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "402c0c85-9701-4615-a54f-c505b48247a3", "AQAAAAEAACcQAAAAEDmZqG6gZbhA42NF4PNiehHuAkB58hLLZAtY07mmrT2sBpnIM8q1M5PCP6fCh7jP1w==", "1647a796-d6be-4dca-a294-e503b5e4511a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d2e1388-75c0-4163-b8fa-d9137e68d100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49c40c53-f6de-4b4a-bbae-917e43d16d92", "AQAAAAEAACcQAAAAENAQ7qXUGa/jm7RT6ZGLu9N3Z4v/1XylUpesj98hy/wgwJ8msaVvy0QOmUa1qqf5ZQ==", "6a1f07a8-5db8-4952-a536-5d74e2326812" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95b2be27-f576-4c78-a817-ffecb7144c47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f10c55a-20ad-4bf5-a04d-b07d5d197acd", "AQAAAAEAACcQAAAAEOMpdqF7aOreA1KLxeHmZs5AUCFMgSlZLg/UdoUoYEZW04wY/rMKzkxILiFz51sqyw==", "98ca1126-1904-481c-abf5-5817f7ee08bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7a70c7f-6bad-4fb2-9a6c-2d5253b21008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "134fbed8-48a2-4c8d-be47-9f3b8cbc7476", "AQAAAAEAACcQAAAAEFHAX6krIBu3ZnKWE0UeBZSfYZFCUnZJiqo01jAKfs/yPqSF/njuqu+K5UEqEgqJeg==", "cfec5436-31ea-4b58-bf81-3a40d3f1af92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd04ef2d-de41-4e5a-979f-fc4c1f241dfa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12a59f9f-7a53-4151-bb25-d219caef172d", "AQAAAAEAACcQAAAAEEbZwvfMjC6px0wUJ5kllCiUhf/lYh1fXHTkbTzlwVsplUytYXHXncfQsRDXqPr6tg==", "bc7d9551-76b1-4588-93bc-eb4202f04c1b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Priority",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
