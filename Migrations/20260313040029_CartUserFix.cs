using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grosary_net.Migrations
{
    /// <inheritdoc />
    public partial class CartUserFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2026, 3, 13, 9, 30, 28, 701, DateTimeKind.Local).AddTicks(2559));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2026, 3, 13, 9, 30, 14, 665, DateTimeKind.Local).AddTicks(6185));
        }
    }
}
