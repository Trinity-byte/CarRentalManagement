using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class NewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 1, 24, 185, DateTimeKind.Local).AddTicks(2678), new DateTime(2024, 11, 18, 11, 1, 24, 185, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 1, 24, 185, DateTimeKind.Local).AddTicks(2694), new DateTime(2024, 11, 18, 11, 1, 24, 185, DateTimeKind.Local).AddTicks(2695) });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 1, 24, 185, DateTimeKind.Local).AddTicks(2887), new DateTime(2024, 11, 18, 11, 1, 24, 185, DateTimeKind.Local).AddTicks(2888), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 1, 24, 185, DateTimeKind.Local).AddTicks(2891), new DateTime(2024, 11, 18, 11, 1, 24, 185, DateTimeKind.Local).AddTicks(2891), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 1, 24, 185, DateTimeKind.Local).AddTicks(2982), new DateTime(2024, 11, 18, 11, 1, 24, 185, DateTimeKind.Local).AddTicks(2983), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 1, 24, 185, DateTimeKind.Local).AddTicks(2984), new DateTime(2024, 11, 18, 11, 1, 24, 185, DateTimeKind.Local).AddTicks(2985), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 11, 1, 24, 185, DateTimeKind.Local).AddTicks(2986), new DateTime(2024, 11, 18, 11, 1, 24, 185, DateTimeKind.Local).AddTicks(2987), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 11, 1, 24, 185, DateTimeKind.Local).AddTicks(2988), new DateTime(2024, 11, 18, 11, 1, 24, 185, DateTimeKind.Local).AddTicks(2988), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 10, 53, 13, 804, DateTimeKind.Local).AddTicks(1086), new DateTime(2024, 11, 18, 10, 53, 13, 804, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 10, 53, 13, 804, DateTimeKind.Local).AddTicks(1101), new DateTime(2024, 11, 18, 10, 53, 13, 804, DateTimeKind.Local).AddTicks(1101) });
        }
    }
}
