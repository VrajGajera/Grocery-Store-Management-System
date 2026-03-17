using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grosary_net.Migrations
{
    /// <inheritdoc />
    public partial class CartUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2026, 3, 13, 9, 30, 14, 665, DateTimeKind.Local).AddTicks(6185));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2026, 3, 13, 9, 29, 45, 224, DateTimeKind.Local).AddTicks(2635));
        }
    }
}
