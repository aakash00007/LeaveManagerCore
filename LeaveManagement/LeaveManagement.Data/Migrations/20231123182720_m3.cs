using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Reason",
                table: "Approvals",
                newName: "ApprovalReason");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18dd2c16-7c16-47f3-ac8f-0ea9a1cc4160",
                column: "ConcurrencyStamp",
                value: "2d0d66ca-69d7-44ef-9e17-0e40e196e73b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7eb86ba1-eafa-49db-b58b-87e2da0ea429",
                column: "ConcurrencyStamp",
                value: "618ce467-040c-484e-a91d-a2a767523bd1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8442a53b-a77a-4bd9-b3c9-33b5e570f375",
                column: "ConcurrencyStamp",
                value: "b4a8dc5b-c680-4c1f-87e9-143125b0413a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5877ffc-ff2f-4a2e-af53-7144c89b3ae7",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "ab1cba78-b97b-48ae-8f7b-001841c91a84", "General Manager" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5a1999e-a895-4b43-a22c-3c26e8e4e97d",
                column: "ConcurrencyStamp",
                value: "8c0b6569-8ff1-4a29-b20b-6f31934b9a0f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e01d34fc-74e2-4298-9367-36ccc116efc6",
                column: "ConcurrencyStamp",
                value: "310b9d70-2dc4-4501-96f5-35df02a7db8b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20811416-1ccb-440d-b2d7-cccfb739ac13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12d25ed4-628d-4a1b-b89d-9f7c9b74d2ce", "AQAAAAEAACcQAAAAENjtT7lTga/JB0y6rKtTp41dBhN5imaswp/YhCZn3/OEWjnjI+wQMbMVJnDs12iNog==", "d0f1f4d7-6077-48e7-9187-b972956f1220" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dbe310f-eb29-4ae2-adc3-8fe3376110ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9e06cd6-bc29-4be4-ab88-f2486cd92b67", "AQAAAAEAACcQAAAAELmKeN7050oFoOWsiT0fQLnki2UdONzYZCm0YsGMRgXNdzhbfb7WRBvpkvBb/EXfKA==", "1b12cd27-105d-4fdd-a696-9cbbe48798d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d2e1388-75c0-4163-b8fa-d9137e68d100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbef0f3d-2940-41c4-94bb-0f3cb639bfca", "AQAAAAEAACcQAAAAEJZWVJpWvvm0tkEZ6WG78Dc9URDnoaYEUURDnMozWVJ0sxrmmvyqmnRd19y8Z8NnwA==", "27f15560-cf80-4f98-970a-a558b753cbf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95b2be27-f576-4c78-a817-ffecb7144c47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acde173b-e06f-44e8-8ed0-711fcf7e101f", "AQAAAAEAACcQAAAAENljWEhHF5DYB/EinUlKdwxAYFz2MKjDAkKCk3XKV61eRwK6VzNJ/jDaRnLDGP8Vdw==", "d3c2bd67-ddda-463f-89b8-2842b63910c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7a70c7f-6bad-4fb2-9a6c-2d5253b21008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e63007bd-2702-4846-b72b-3ea9842fad60", "AQAAAAEAACcQAAAAEHURy6YzhdfnnMMatbf144Q8JeH6yCEgP/yu69r9Y8z/AwFwcUIofJ/Wvz69ib8loA==", "2ee3c98c-afd3-4352-9e1a-c718e79d0499" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd04ef2d-de41-4e5a-979f-fc4c1f241dfa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5a920f2-d7ba-47c1-ba1d-1b78acdec9d2", "AQAAAAEAACcQAAAAEJNTk0ViSV6VIiJkD39HMY+eO5gsHUYofu94+bAJJiZX1+6tuAPOR3tw9iz3exkfOQ==", "8e8a1c02-b048-4603-9a3a-f0ec2a2ee227" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApprovalReason",
                table: "Approvals",
                newName: "Reason");

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
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "79b5ccbc-dfc8-4d15-91a6-76b664026c8d", "General Manager" });

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
    }
}
