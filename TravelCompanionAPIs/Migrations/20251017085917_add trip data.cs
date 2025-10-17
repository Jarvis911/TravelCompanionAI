using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelCompanionAPIs.Migrations
{
    /// <inheritdoc />
    public partial class addtripdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Budget", "Destination", "EndDate", "Preference", "StartDate" },
                values: new object[,]
                {
                    { 1, 10000m, "Ho Chi Minh", new DateTime(1989, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ABC", new DateTime(1989, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 10000m, "Ho Chi Minh", new DateTime(1989, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ABC", new DateTime(1989, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
