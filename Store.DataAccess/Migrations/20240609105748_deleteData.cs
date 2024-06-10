using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Clover_Store.Migrations
{
    /// <inheritdoc />
    public partial class deleteData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "attributes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "attributes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "attributes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "attributes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "attributes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "attributes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "attributes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "attributes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6);

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

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 7);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "Details", "Name" },
                values: new object[,]
                {
                    { 1, "", "pants" },
                    { 2, "", "sport" },
                    { 3, "", "dress" },
                    { 4, "", "skirt" },
                    { 5, "", "shirt" },
                    { 6, "", "sweat" },
                    { 7, "", "Tunic" },
                    { 8, "", "Coat" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Blue", "Green", "Name", "Red" },
                values: new object[,]
                {
                    { 1, 54, 67, "Green", 37 },
                    { 2, 142, 193, "Sage", 181 },
                    { 3, 163, 183, "Brown", 199 },
                    { 4, 58, 29, "Maroon", 169 },
                    { 5, 124, 169, "Ecru", 185 },
                    { 6, 65, 86, "Khaki", 91 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Details", "Name" },
                values: new object[,]
                {
                    { 1, "", "XS" },
                    { 2, "", "S" },
                    { 3, "", "M" },
                    { 4, "", "L" },
                    { 5, "", "XL" },
                    { 6, "", "2XL" },
                    { 7, "", "3XL" },
                    { 8, "", "26" },
                    { 9, "", "27" },
                    { 10, "", "28" },
                    { 11, "", "29" },
                    { 12, "", "30" },
                    { 13, "", "30-31" },
                    { 14, "", "30-32" },
                    { 15, "", "31" },
                    { 16, "", "32" },
                    { 17, "", "32-31" },
                    { 18, "", "36" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand_name", "CategoryID", "Description", "Material", "Title", "Total_quantity", "Type" },
                values: new object[,]
                {
                    { 1, "LCW", 1, "Made from waffle fabric, this t-shirt offers a stylish and modern look with its polo collar design.\r\n With its soft and comfortable texture,\r\n it can be preferred both in daily life and on special occasions.", "100% Cotton", "Polo Yaka Kısa Kollu Pike Erkek Tişört", 13, "Male" },
                    { 2, "adidas", 5, "It is made of durable and easy-care polyester fabric.\r\n Its short sleeve design keeps you cool and comfortable even in hot weather conditions.", "100% Cotton", "Regular Fit Men's Short Sleeve Shirt", 13, "Male" },
                    { 3, "ZARA", 7, "Round neck, straight short sleeve oversize tunic, made of single jersey fabric. It provides coolness in summer with its light and breathable structure.", "100% Cotton", "Crew Neck Plain Short Sleeve Oversize Women's Tunic", 13, "Male" }
                });

            migrationBuilder.InsertData(
                table: "attributes",
                columns: new[] { "Id", "ColorID", "Price", "ProductID", "Quantity", "SizeID" },
                values: new object[,]
                {
                    { 1, 2, 699.99m, 1, 10, 2 },
                    { 2, 4, 699.99m, 1, 10, 3 },
                    { 3, 4, 799.99m, 1, 10, 4 },
                    { 4, 2, 675.00m, 2, 10, 3 },
                    { 5, 2, 975.00m, 2, 8, 6 },
                    { 6, 6, 975.00m, 2, 14, 3 },
                    { 7, 6, 899.99m, 2, 10, 5 },
                    { 8, 2, 899.99m, 3, 15, 2 }
                });
        }
    }
}
