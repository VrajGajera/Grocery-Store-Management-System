using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Grosary_net.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdToCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2026, 3, 13, 9, 30, 58, 458, DateTimeKind.Local).AddTicks(3643));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2026, 3, 13, 9, 30, 28, 701, DateTimeKind.Local).AddTicks(2559));
        }
    }
}
