using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF02_Demo.Migrations
{
    /// <inheritdoc />
    public partial class dataseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepId", "DateOfCreation", "DepartmentName" },
                values: new object[,]
                {
                    { 10, new DateTime(2025, 9, 19, 15, 4, 49, 776, DateTimeKind.Local).AddTicks(1061), "HR" },
                    { 20, new DateTime(2025, 9, 19, 15, 4, 49, 776, DateTimeKind.Local).AddTicks(1107), "PR" },
                    { 30, new DateTime(2025, 9, 19, 15, 4, 49, 776, DateTimeKind.Local).AddTicks(1109), "Sales" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepId",
                keyValue: 30);
        }
    }
}
