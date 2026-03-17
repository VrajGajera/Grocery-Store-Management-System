using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Grosary_net.Migrations
{
    /// <inheritdoc />
    public partial class AddMeatProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AddedDate", "Category", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 70, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meat", "Fresh boneless chicken breast perfect for grilling and cooking.", "https://images.pexels.com/photos/616353/pexels-photo-616353.jpeg", "Chicken Breast", 8.99m, 35 },
                    { 71, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meat", "Fresh goat meat ideal for curries and traditional dishes.", "https://images.pexels.com/photos/675951/pexels-photo-675951.jpeg", "Mutton", 12.99m, 25 },
                    { 72, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meat", "Premium beef steak perfect for grilling and roasting.", "https://images.pexels.com/photos/675951/pexels-photo-675951.jpeg", "Beef Steak", 14.99m, 20 },
                    { 73, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meat", "Fresh chicken drumsticks perfect for frying and BBQ.", "https://images.pexels.com/photos/65175/pexels-photo-65175.jpeg", "Chicken Drumsticks", 7.49m, 30 },
                    { 74, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meat", "Fresh minced meat ideal for burgers and meatballs.", "https://images.pexels.com/photos/361184/asparagus-steak-veal-chop-361184.jpeg", "Minced Meat", 9.49m, 28 },
                    { 75, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meat", "Lean turkey meat rich in protein and low in fat.", "https://images.pexels.com/photos/675951/pexels-photo-675951.jpeg", "Turkey Meat", 10.99m, 18 },
                    { 76, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meat", "Tender lamb chops perfect for grilling and roasting.", "https://images.pexels.com/photos/675951/pexels-photo-675951.jpeg", "Lamb Chops", 13.99m, 16 },
                    { 77, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meat", "Juicy sausages perfect for breakfast and grilling.", "https://images.pexels.com/photos/65175/pexels-photo-65175.jpeg", "Sausages", 6.99m, 40 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2026, 3, 13, 10, 30, 22, 891, DateTimeKind.Local).AddTicks(4467));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AddedDate", "Category", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grains", "High quality rice", "/images/rice.jpg", "Rice", 50m, 0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grocery", "Pure white sugar", "/images/sugar.jpg", "Sugar", 40m, 0 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cooking", "Refined cooking oil", "/images/oil.jpg", "Oil", 120m, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2026, 3, 13, 9, 31, 27, 45, DateTimeKind.Local).AddTicks(7759));
        }
    }
}
