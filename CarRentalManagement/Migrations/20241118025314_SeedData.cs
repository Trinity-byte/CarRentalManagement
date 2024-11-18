using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 10, 53, 13, 804, DateTimeKind.Local).AddTicks(1086), new DateTime(2024, 11, 18, 10, 53, 13, 804, DateTimeKind.Local).AddTicks(1099), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 10, 53, 13, 804, DateTimeKind.Local).AddTicks(1101), new DateTime(2024, 11, 18, 10, 53, 13, 804, DateTimeKind.Local).AddTicks(1101), "Blue", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
