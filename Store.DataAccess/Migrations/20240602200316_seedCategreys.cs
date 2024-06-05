using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Clover_Store.Migrations
{
    /// <inheritdoc />
    public partial class seedCategreys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Products",
                columns: new[] { "Id", "Brand_name", "CategoryID", "Description", "Title", "Total_quantity", "Type" },
                values: new object[,]
                {
                    { 1, "LCW", 1, "Made from waffle fabric, this t-shirt offers a stylish and modern look with its polo collar design.\r\n With its soft and comfortable texture,\r\n it can be preferred both in daily life and on special occasions.", "Polo Yaka Kısa Kollu Pike Erkek Tişört", 13, "Male" },
                    { 2, "adedass", 5, "It is made of durable and easy-care polyester fabric.\r\n Its short sleeve design keeps you cool and comfortable even in hot weather conditions.", "Regular Fit Men's Short Sleeve Shirt", 13, "Male" },
                    { 3, "nike", 7, "Round neck, straight short sleeve oversize tunic, made of single jersey fabric. It provides coolness in summer with its light and breathable structure. \r\nIts oversize cut provides freedom of movement and is designed in hip-length length so that you can move comfortably.", "Crew Neck Plain Short Sleeve Oversize Women's Tunic", 13, "Male" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
