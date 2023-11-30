using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Approvals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18dd2c16-7c16-47f3-ac8f-0ea9a1cc4160",
                column: "ConcurrencyStamp",
                value: "c137ca9b-2d2e-4ec5-93b8-4ae47675b35d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7eb86ba1-eafa-49db-b58b-87e2da0ea429",
                column: "ConcurrencyStamp",
                value: "1b20ff63-1daa-45ed-9723-d0f7edbdeb83");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8442a53b-a77a-4bd9-b3c9-33b5e570f375",
                column: "ConcurrencyStamp",
                value: "23fe150c-12fe-4d25-ab36-8e3c2953dd5e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5877ffc-ff2f-4a2e-af53-7144c89b3ae7",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "711978d5-cf62-4a58-b1b7-c015f18c569b", "General Manager" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5a1999e-a895-4b43-a22c-3c26e8e4e97d",
                column: "ConcurrencyStamp",
                value: "ab0beeb1-ce06-43ee-ba58-9afa9e831fe2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e01d34fc-74e2-4298-9367-36ccc116efc6",
                column: "ConcurrencyStamp",
                value: "d2b874d4-b9d9-4d3e-9e2f-9ca24ce6a1ed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20811416-1ccb-440d-b2d7-cccfb739ac13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ccb1018-729b-4b86-a15e-18070bcaebd3", "AQAAAAEAACcQAAAAEBn/NmKrqV8vUdBEiBcqG1vm9osg/5VpO6rvZIAk5MwlIa6FhOgudWVG0VKQLhUfOw==", "86249b50-5dbd-4c60-8a45-29b02c9ccbd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dbe310f-eb29-4ae2-adc3-8fe3376110ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fac050cb-7c23-4076-960c-9374712a6e2b", "AQAAAAEAACcQAAAAEO48//7LIWhxYp/pVu8g27G5tFhiCOEiINGRibOMC1idFYpYnveyAVBU4ZC7op2oog==", "80e0a56b-dd24-4c16-9269-88661903da38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d2e1388-75c0-4163-b8fa-d9137e68d100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55542c2f-ffe8-4f1c-b39a-787e939eff90", "AQAAAAEAACcQAAAAEHmGQiz80n6YccegpIPXjkqhk4tQuDrnl5zBhVODmqM1UO9Bzj0NSyrlJqyMrJmwCg==", "7507423a-e770-4200-b60c-b249340613f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95b2be27-f576-4c78-a817-ffecb7144c47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f0551da-2117-4779-a731-8e26d77a9263", "AQAAAAEAACcQAAAAEIP7738Z//UYvd2utEyWIlQ5wvz7xBV27zPypsgYfxl2Hpd9wlSYor7WcRLOJc4d2A==", "847341cf-545b-4a77-ba57-1a4805297ed7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7a70c7f-6bad-4fb2-9a6c-2d5253b21008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "541a729c-c98b-40cb-8557-876ec025a65f", "AQAAAAEAACcQAAAAEAaqROi0XDYt41XnWqDyPxedYLbozAi+2jrvvQBFWx/rhx9Z3AF51t2sjGbq9ir8jQ==", "d4789af4-756b-431c-a715-4a538c47f8db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd04ef2d-de41-4e5a-979f-fc4c1f241dfa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f34c593b-9df5-482f-a239-332f125d64e2", "AQAAAAEAACcQAAAAEE0ZNlftQY8Z58A7sq48XfXa09LoQ6BziPgsnCNO3WEsw3/y7SrwdL0NIvM9/afW4Q==", "4040d7db-c6f5-47aa-b410-cfe11440df3c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Approvals");

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
    }
}
