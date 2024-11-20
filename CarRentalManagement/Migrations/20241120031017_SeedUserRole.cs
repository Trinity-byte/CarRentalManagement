using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 28, 30, 503, DateTimeKind.Local).AddTicks(3235), new DateTime(2024, 11, 18, 11, 28, 30, 503, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 28, 30, 503, DateTimeKind.Local).AddTicks(3250), new DateTime(2024, 11, 18, 11, 28, 30, 503, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 28, 30, 503, DateTimeKind.Local).AddTicks(3442), new DateTime(2024, 11, 18, 11, 28, 30, 503, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 28, 30, 503, DateTimeKind.Local).AddTicks(3445), new DateTime(2024, 11, 18, 11, 28, 30, 503, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 28, 30, 503, DateTimeKind.Local).AddTicks(3536), new DateTime(2024, 11, 18, 11, 28, 30, 503, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 28, 30, 503, DateTimeKind.Local).AddTicks(3538), new DateTime(2024, 11, 18, 11, 28, 30, 503, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 28, 30, 503, DateTimeKind.Local).AddTicks(3539), new DateTime(2024, 11, 18, 11, 28, 30, 503, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 28, 30, 503, DateTimeKind.Local).AddTicks(3541), new DateTime(2024, 11, 18, 11, 28, 30, 503, DateTimeKind.Local).AddTicks(3542) });
        }
    }
}
