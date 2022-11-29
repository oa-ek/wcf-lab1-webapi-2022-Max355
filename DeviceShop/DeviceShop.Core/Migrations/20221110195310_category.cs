using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeviceShop.Core.Migrations
{
    public partial class category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4882cbf5-36da-4f3e-8d02-869035e00fd3", "2d062992-dc0d-45ed-98bf-558f468bf2d1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8b67d02c-2a6c-4b1d-b827-f1dbd34362ee", "2d062992-dc0d-45ed-98bf-558f468bf2d1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8b67d02c-2a6c-4b1d-b827-f1dbd34362ee", "a916da9c-bd44-4293-aef6-4352b16992e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4882cbf5-36da-4f3e-8d02-869035e00fd3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b67d02c-2a6c-4b1d-b827-f1dbd34362ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d062992-dc0d-45ed-98bf-558f468bf2d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a916da9c-bd44-4293-aef6-4352b16992e4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a421f08-e362-4abe-aa94-6d076cb59ee3", "f98be3bc-ed59-4cd6-b2b1-b505fc7db336", "User", "USER" },
                    { "e4b652a0-0973-499b-a0d9-ca251151c98a", "08491c93-7389-47e9-a6fd-718bdadab7b3", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "12f24c40-2a36-4840-ba8d-0c397bcf88a2", 0, "6f35502a-fd24-4841-820b-ccf981cb8f35", "user@deviceshop.com", true, null, null, false, null, "USER@DEVICESHOP.COM", "USER@DEVICESHOP.COM", "AQAAAAEAACcQAAAAEMN1VeRJ5jgM/ulAmlXuyaKSYV8eMGnEultwznds+qk6bZnwzV00B5PmIFKVU1MzDQ==", null, false, "7d1c0493-ea72-46a7-816e-59fa1047d8c5", false, "user@deviceshop.com" },
                    { "b8e87175-dfb4-470e-9e52-18ec458af3fd", 0, "f17e00d0-911a-4590-9625-9ff8ee5834fe", "admin@deviceshop.com", true, null, null, false, null, "ADMIN@DEVICESHOP.COM", "ADMIN@DEVICESHOP.COM", "AQAAAAEAACcQAAAAEKQ6ib02zQ4q0ldIcAFc7Np7m7DxRko+uSszJGuIT35OkgrWQUGbNIzFMrBpMNhi0A==", null, false, "3e1f5326-8387-4b55-a02b-e64943a33caf", false, "admin@deviceshop.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4a421f08-e362-4abe-aa94-6d076cb59ee3", "12f24c40-2a36-4840-ba8d-0c397bcf88a2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4a421f08-e362-4abe-aa94-6d076cb59ee3", "b8e87175-dfb4-470e-9e52-18ec458af3fd" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e4b652a0-0973-499b-a0d9-ca251151c98a", "b8e87175-dfb4-470e-9e52-18ec458af3fd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4a421f08-e362-4abe-aa94-6d076cb59ee3", "12f24c40-2a36-4840-ba8d-0c397bcf88a2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4a421f08-e362-4abe-aa94-6d076cb59ee3", "b8e87175-dfb4-470e-9e52-18ec458af3fd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e4b652a0-0973-499b-a0d9-ca251151c98a", "b8e87175-dfb4-470e-9e52-18ec458af3fd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a421f08-e362-4abe-aa94-6d076cb59ee3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4b652a0-0973-499b-a0d9-ca251151c98a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12f24c40-2a36-4840-ba8d-0c397bcf88a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8e87175-dfb4-470e-9e52-18ec458af3fd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4882cbf5-36da-4f3e-8d02-869035e00fd3", "4f450341-ca76-4454-8d55-338ceeadbc61", "Admin", "ADMIN" },
                    { "8b67d02c-2a6c-4b1d-b827-f1dbd34362ee", "2493a2cf-6df8-4c4b-85a0-5986de1a9693", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2d062992-dc0d-45ed-98bf-558f468bf2d1", 0, "736980fd-af11-4688-81a1-d6218277c20a", "admin@deviceshop.com", true, null, null, false, null, "ADMIN@DEVICESHOP.COM", "ADMIN@DEVICESHOP.COM", "AQAAAAEAACcQAAAAEOH+TvorRq62Jkx4b3uTDoJLyK2ehVkfNzUDO1qdqnUyV007YWGi8xA5LZgwnFcd+g==", null, false, "77288c40-cce3-4413-9f62-e7f14e81988d", false, "admin@deviceshop.com" },
                    { "a916da9c-bd44-4293-aef6-4352b16992e4", 0, "97ce6aba-c2ec-420a-9a7a-b28343d42612", "user@deviceshop.com", true, null, null, false, null, "USER@DEVICESHOP.COM", "USER@DEVICESHOP.COM", "AQAAAAEAACcQAAAAEFOdAjk6DI3F9uLLc/qU+Rmc04Cthdsh2LB6tiGRoTji9kebmDL+lOF6R1q7qbj3Ng==", null, false, "cd2ae069-a11c-4ea7-a585-8eed6e3eed5c", false, "user@deviceshop.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4882cbf5-36da-4f3e-8d02-869035e00fd3", "2d062992-dc0d-45ed-98bf-558f468bf2d1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8b67d02c-2a6c-4b1d-b827-f1dbd34362ee", "2d062992-dc0d-45ed-98bf-558f468bf2d1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8b67d02c-2a6c-4b1d-b827-f1dbd34362ee", "a916da9c-bd44-4293-aef6-4352b16992e4" });
        }
    }
}
