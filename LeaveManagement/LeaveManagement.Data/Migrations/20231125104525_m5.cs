using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class m5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LeaveStatus",
                table: "LeaveRequests",
                newName: "ApprovalStatus");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18dd2c16-7c16-47f3-ac8f-0ea9a1cc4160",
                column: "ConcurrencyStamp",
                value: "09cc452c-83f4-4428-a03d-22bffc1768ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7eb86ba1-eafa-49db-b58b-87e2da0ea429",
                column: "ConcurrencyStamp",
                value: "ae1946da-7f0b-4385-bb0f-e7539748da59");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8442a53b-a77a-4bd9-b3c9-33b5e570f375",
                column: "ConcurrencyStamp",
                value: "ca87aef0-c7e1-4987-9392-22b3a72214d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5877ffc-ff2f-4a2e-af53-7144c89b3ae7",
                column: "ConcurrencyStamp",
                value: "4bb71b48-f883-4380-9bd6-5023085a6bce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5a1999e-a895-4b43-a22c-3c26e8e4e97d",
                column: "ConcurrencyStamp",
                value: "9db433b2-0ad6-47c0-a8ae-7548bfcb4b1c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e01d34fc-74e2-4298-9367-36ccc116efc6",
                column: "ConcurrencyStamp",
                value: "52635bc0-90a6-4e86-82f3-50001bf57652");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20811416-1ccb-440d-b2d7-cccfb739ac13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cb790a3-4c3d-44e6-9c32-78db65ddd0d6", "AQAAAAEAACcQAAAAEJA+j5FeTV/4j9KVFapvQ62x+vRhConERuVjgVNizBc8RWBvHs+lieNDsLoLiVH4UA==", "822c61cd-47d0-4177-b119-4c865e597791" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dbe310f-eb29-4ae2-adc3-8fe3376110ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9821d98b-178e-4189-8427-3dc8616e00c7", "AQAAAAEAACcQAAAAEIiwAD9Jar9Q72tjodPX0TqVIVbNf/DDcmSHDTNchS5P+ync+eDw7S9f6bbDEvQ5eA==", "52170247-016f-4187-a197-bfc186305d4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d2e1388-75c0-4163-b8fa-d9137e68d100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bf09d33-b810-4eb1-96cb-7799238a1468", "AQAAAAEAACcQAAAAEMh9EpnW1UfXv0pSdkl8lh9QDZkCJo4N3qVp5Z/7nJ6MAd+E/edWXrze2t2LlzpxVw==", "a5cfd72c-22fd-487a-9199-de17a938b1fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95b2be27-f576-4c78-a817-ffecb7144c47",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5f7b1bd-415f-4b6e-bba5-3f707b2d8719", "AQAAAAEAACcQAAAAEHzEkqVzO5MCcNtf4xfBV+IkWuHw54WzdBK+b1Cq8nHuO8QhRFPwuMcU0bDbLQWp0g==", "955cfe92-c048-485d-b57f-7bc38f8f8ac4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7a70c7f-6bad-4fb2-9a6c-2d5253b21008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03ece2d3-8c22-4d48-b5ec-f75ec2c132bd", "AQAAAAEAACcQAAAAEIjy58l+eV0rD9/M5aWtgvVHSO5qigBJRvo0dtH0JwtRnU+qI+fzPUK3vV1/KW8iQg==", "9bd4025a-8a9d-4873-af66-b6c8aa2b72d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd04ef2d-de41-4e5a-979f-fc4c1f241dfa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0046a929-ad18-40ca-83af-8fd432739721", "AQAAAAEAACcQAAAAEP1bU4+FSTGv0tEyGvwThlYOBO8bF25j2Kupo9QUG7JoJ9Yd7SONSpnE0KK3RpaC8w==", "4d6a6f65-aff4-46d6-a118-f5fa7030ce5c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApprovalStatus",
                table: "LeaveRequests",
                newName: "LeaveStatus");

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
                column: "ConcurrencyStamp",
                value: "711978d5-cf62-4a58-b1b7-c015f18c569b");

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
    }
}
