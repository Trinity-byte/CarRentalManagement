using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRoleNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "a5b1d679-0984-4589-9f02-87a97b54f9db", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAELdhg0od3dPETndFJRFrHe6tIMoiy3v4/OzvtxrV1MCFAmTVR6DdEY1Q3uDqfdRG/g==", null, false, "3140daae-7171-486e-8a2c-3fad59eba9e7", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 14, 58, 608, DateTimeKind.Local).AddTicks(9919), new DateTime(2024, 11, 20, 11, 14, 58, 608, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 14, 58, 608, DateTimeKind.Local).AddTicks(9952), new DateTime(2024, 11, 20, 11, 14, 58, 608, DateTimeKind.Local).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 14, 58, 609, DateTimeKind.Local).AddTicks(617), new DateTime(2024, 11, 20, 11, 14, 58, 609, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 14, 58, 609, DateTimeKind.Local).AddTicks(625), new DateTime(2024, 11, 20, 11, 14, 58, 609, DateTimeKind.Local).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 14, 58, 609, DateTimeKind.Local).AddTicks(965), new DateTime(2024, 11, 20, 11, 14, 58, 609, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 14, 58, 609, DateTimeKind.Local).AddTicks(972), new DateTime(2024, 11, 20, 11, 14, 58, 609, DateTimeKind.Local).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 14, 58, 609, DateTimeKind.Local).AddTicks(976), new DateTime(2024, 11, 20, 11, 14, 58, 609, DateTimeKind.Local).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 14, 58, 609, DateTimeKind.Local).AddTicks(982), new DateTime(2024, 11, 20, 11, 14, 58, 609, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 10, 15, 241, DateTimeKind.Local).AddTicks(5229), new DateTime(2024, 11, 20, 11, 10, 15, 241, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 10, 15, 241, DateTimeKind.Local).AddTicks(5252), new DateTime(2024, 11, 20, 11, 10, 15, 241, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 10, 15, 241, DateTimeKind.Local).AddTicks(5843), new DateTime(2024, 11, 20, 11, 10, 15, 241, DateTimeKind.Local).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 10, 15, 241, DateTimeKind.Local).AddTicks(5849), new DateTime(2024, 11, 20, 11, 10, 15, 241, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 10, 15, 241, DateTimeKind.Local).AddTicks(6142), new DateTime(2024, 11, 20, 11, 10, 15, 241, DateTimeKind.Local).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 10, 15, 241, DateTimeKind.Local).AddTicks(6146), new DateTime(2024, 11, 20, 11, 10, 15, 241, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 10, 15, 241, DateTimeKind.Local).AddTicks(6151), new DateTime(2024, 11, 20, 11, 10, 15, 241, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 10, 15, 241, DateTimeKind.Local).AddTicks(6154), new DateTime(2024, 11, 20, 11, 10, 15, 241, DateTimeKind.Local).AddTicks(6155) });
        }
    }
}
