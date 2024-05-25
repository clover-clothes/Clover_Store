using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Clover_Store.Migrations
{
    /// <inheritdoc />
    public partial class seedProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "Id", "Details", "Name" },
                values: new object[] { 1, "", "short" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand_name", "CategoryID", "Description", "Gender", "Images", "Images2", "Images3", "Title", "Total_quantity" },
                values: new object[,]
                {
                    { 1, "nike", 1, "guzel", "Male", null, null, null, "sweatsheart", 13 },
                    { 2, "nike", 1, "guzel", "Male", null, null, null, "sweat", 13 },
                    { 3, "adedas", 1, "amazing", "Male", null, null, null, "man style", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 1);

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
        }
    }
}
