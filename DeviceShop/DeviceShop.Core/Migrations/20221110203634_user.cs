using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeviceShop.Core.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "DeviceUser",
                columns: table => new
                {
                    DevicesDeviceId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceUser", x => new { x.DevicesDeviceId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_DeviceUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeviceUser_Devices_DevicesDeviceId",
                        column: x => x.DevicesDeviceId,
                        principalTable: "Devices",
                        principalColumn: "DeviceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "016d53de-4e64-4993-8819-9fd2e04deaef", "ae5e5808-089c-428e-87f7-140dd57176b0", "Admin", "ADMIN" },
                    { "c793aa2c-5e3d-4da2-83c7-e1bab7ce665a", "6d307e9c-1dd7-4446-b123-4fd7d8bbe9c2", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5fd33c41-a328-4843-af9b-1dee8b29cea1", 0, "09b3c929-9dc1-46c8-86e6-2f701af6fe0e", "admin@deviceshop.com", true, null, null, false, null, "ADMIN@DEVICESHOP.COM", "ADMIN@DEVICESHOP.COM", "AQAAAAEAACcQAAAAEARbjHkyttaWaranZ1nV7A1vUiYBeIZoCeWaOe9lNs/2aN+La8YrsIqkCo/CVh4ZSg==", null, false, "33fc7a65-4f8a-4461-ab3d-213949e40c6d", false, "admin@deviceshop.com" },
                    { "b329406e-f4a3-46ed-9fc0-58f62978a0ca", 0, "3fb46a59-ba6e-4eaa-9429-02181f769b9d", "user@deviceshop.com", true, null, null, false, null, "USER@DEVICESHOP.COM", "USER@DEVICESHOP.COM", "AQAAAAEAACcQAAAAECigOleCuI/8zulyWfylI6eeoN38Klyybyjv34l4haLY75d9L35DPFB7wIB5o9FqyA==", null, false, "bf7b28d7-a9c3-4021-85c9-ef7bcf56295c", false, "user@deviceshop.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "016d53de-4e64-4993-8819-9fd2e04deaef", "5fd33c41-a328-4843-af9b-1dee8b29cea1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c793aa2c-5e3d-4da2-83c7-e1bab7ce665a", "5fd33c41-a328-4843-af9b-1dee8b29cea1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c793aa2c-5e3d-4da2-83c7-e1bab7ce665a", "b329406e-f4a3-46ed-9fc0-58f62978a0ca" });

            migrationBuilder.CreateIndex(
                name: "IX_DeviceUser_UsersId",
                table: "DeviceUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceUser");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "016d53de-4e64-4993-8819-9fd2e04deaef", "5fd33c41-a328-4843-af9b-1dee8b29cea1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c793aa2c-5e3d-4da2-83c7-e1bab7ce665a", "5fd33c41-a328-4843-af9b-1dee8b29cea1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c793aa2c-5e3d-4da2-83c7-e1bab7ce665a", "b329406e-f4a3-46ed-9fc0-58f62978a0ca" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "016d53de-4e64-4993-8819-9fd2e04deaef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c793aa2c-5e3d-4da2-83c7-e1bab7ce665a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fd33c41-a328-4843-af9b-1dee8b29cea1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b329406e-f4a3-46ed-9fc0-58f62978a0ca");

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
    }
}
