using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Grosary_net.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AddedDate", "Category", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { 101, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fruits", "Fresh sweet red apples.", "https://images.pexels.com/photos/102104/pexels-photo-102104.jpeg", "Red Apples", 4.99m, 50 },
                    { 102, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fruits", "Organic bananas rich in potassium.", "https://images.pexels.com/photos/1093038/pexels-photo-1093038.jpeg", "Bananas", 3.49m, 60 },
                    { 103, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fruits", "Sweet fresh strawberries.", "https://images.pexels.com/photos/89778/strawberries-frisch-ripe-sweet-89778.jpeg", "Strawberries", 6.99m, 30 },
                    { 104, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fruits", "Juicy oranges rich in vitamin C.", "https://images.pexels.com/photos/327098/pexels-photo-327098.jpeg", "Oranges", 5.99m, 40 },
                    { 105, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fruits", "Sweet tropical mango.", "https://images.pexels.com/photos/918643/pexels-photo-918643.jpeg", "Mango", 7.49m, 35 },
                    { 106, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fruits", "Fresh pineapple.", "https://images.pexels.com/photos/594589/pexels-photo-594589.jpeg", "Pineapple", 6.49m, 20 },
                    { 107, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fruits", "Juicy green grapes.", "https://images.pexels.com/photos/708777/pexels-photo-708777.jpeg", "Green Grapes", 4.59m, 30 },
                    { 108, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fruits", "Refreshing watermelon.", "https://images.pexels.com/photos/615705/pexels-photo-615705.jpeg", "Watermelon", 7.49m, 25 },
                    { 110, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vegetables", "Fresh green spinach.", "https://images.pexels.com/photos/143133/pexels-photo-143133.jpeg", "Spinach", 2.49m, 20 },
                    { 111, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vegetables", "Organic crunchy carrots.", "https://images.pexels.com/photos/65174/pexels-photo-65174.jpeg", "Carrots", 2.99m, 40 },
                    { 112, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vegetables", "Fresh red tomatoes.", "https://images.pexels.com/photos/533280/pexels-photo-533280.jpeg", "Tomatoes", 3.99m, 50 },
                    { 113, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vegetables", "Fresh green bell peppers.", "https://images.pexels.com/photos/128420/pexels-photo-128420.jpeg", "Bell Peppers", 2.99m, 30 },
                    { 114, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vegetables", "Healthy broccoli.", "https://images.pexels.com/photos/143133/pexels-photo-143133.jpeg", "Broccoli", 3.49m, 35 },
                    { 115, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vegetables", "Fresh cucumber.", "https://images.pexels.com/photos/2329440/pexels-photo-2329440.jpeg", "Cucumber", 2.29m, 30 },
                    { 116, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vegetables", "Fresh red onions.", "https://images.pexels.com/photos/175414/pexels-photo-175414.jpeg", "Onions", 2.39m, 40 },
                    { 117, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vegetables", "Farm fresh potatoes.", "https://images.pexels.com/photos/144248/potatoes-food-vegetables-organic-144248.jpeg", "Potatoes", 3.19m, 50 },
                    { 120, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Snacks", "Crunchy salted chips.", "https://images.pexels.com/photos/568805/pexels-photo-568805.jpeg", "Potato Chips", 2.99m, 50 },
                    { 121, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Snacks", "Sweet milk chocolate.", "https://images.pexels.com/photos/65882/chocolate-dark-coffee-confiserie-65882.jpeg", "Chocolate Bar", 1.99m, 60 },
                    { 122, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Snacks", "Crunchy tea biscuits.", "https://images.pexels.com/photos/230325/pexels-photo-230325.jpeg", "Biscuits", 2.49m, 40 },
                    { 123, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Snacks", "Salted popcorn snack.", "https://images.pexels.com/photos/33129/popcorn-movie-party-entertainment.jpg", "Popcorn", 2.99m, 30 },
                    { 124, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Snacks", "Crunchy nachos snack.", "https://images.pexels.com/photos/461198/pexels-photo-461198.jpeg", "Nachos", 3.49m, 35 },
                    { 125, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Snacks", "Sweet cupcake dessert.", "https://images.pexels.com/photos/357573/pexels-photo-357573.jpeg", "Cupcake", 2.79m, 20 },
                    { 126, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Snacks", "Fresh baked cookies.", "https://images.pexels.com/photos/4110541/pexels-photo-4110541.jpeg", "Cookies", 3.49m, 30 },
                    { 127, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Snacks", "Healthy granola snack.", "https://images.pexels.com/photos/1128678/pexels-photo-1128678.jpeg", "Granola Bar", 2.19m, 25 },
                    { 130, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverages", "Fresh orange juice.", "https://images.pexels.com/photos/96974/pexels-photo-96974.jpeg", "Orange Juice", 3.99m, 30 },
                    { 131, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverages", "Natural apple juice.", "https://images.pexels.com/photos/96974/pexels-photo-96974.jpeg", "Apple Juice", 3.49m, 35 },
                    { 132, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverages", "Cold cola beverage.", "https://images.pexels.com/photos/2983101/pexels-photo-2983101.jpeg", "Cola Drink", 2.49m, 50 },
                    { 133, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverages", "Refreshing energy drink.", "https://images.pexels.com/photos/2775860/pexels-photo-2775860.jpeg", "Energy Drink", 3.99m, 40 },
                    { 134, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverages", "Iced coffee drink.", "https://images.pexels.com/photos/302899/pexels-photo-302899.jpeg", "Cold Coffee", 4.49m, 20 },
                    { 135, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverages", "Healthy green tea.", "https://images.pexels.com/photos/1417945/pexels-photo-1417945.jpeg", "Green Tea", 3.19m, 30 },
                    { 136, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverages", "Sweet milkshake drink.", "https://images.pexels.com/photos/1435735/pexels-photo-1435735.jpeg", "Milkshake", 4.29m, 25 },
                    { 137, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverages", "Pure drinking water.", "https://images.pexels.com/photos/327090/pexels-photo-327090.jpeg", "Mineral Water", 1.49m, 100 },
                    { 140, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seafood", "Fresh salmon fish.", "https://images.pexels.com/photos/725991/pexels-photo-725991.jpeg", "Salmon Fish", 12.99m, 20 },
                    { 141, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seafood", "Premium tuna fish.", "https://images.pexels.com/photos/3296277/pexels-photo-3296277.jpeg", "Tuna Fish", 11.49m, 18 },
                    { 142, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seafood", "Fresh shrimp seafood.", "https://images.pexels.com/photos/566345/pexels-photo-566345.jpeg", "Shrimp", 13.99m, 25 },
                    { 143, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seafood", "Fresh sea crab.", "https://images.pexels.com/photos/3296390/pexels-photo-3296390.jpeg", "Crab", 14.49m, 15 },
                    { 144, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seafood", "Premium lobster seafood.", "https://images.pexels.com/photos/566345/pexels-photo-566345.jpeg", "Lobster", 19.99m, 10 },
                    { 145, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seafood", "Fresh sardine fish.", "https://images.pexels.com/photos/3296390/pexels-photo-3296390.jpeg", "Sardines", 8.49m, 30 },
                    { 146, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seafood", "Fresh tilapia fish.", "https://images.pexels.com/photos/725991/pexels-photo-725991.jpeg", "Tilapia", 9.99m, 22 },
                    { 147, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seafood", "Fresh prawns seafood.", "https://images.pexels.com/photos/566345/pexels-photo-566345.jpeg", "Prawns", 12.49m, 28 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2026, 3, 13, 10, 36, 28, 947, DateTimeKind.Local).AddTicks(7466));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegistrationDate",
                value: new DateTime(2026, 3, 13, 10, 30, 22, 891, DateTimeKind.Local).AddTicks(4467));
        }
    }
}
