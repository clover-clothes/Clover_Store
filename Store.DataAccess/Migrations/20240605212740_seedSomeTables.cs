using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Clover_Store.Migrations
{
    /// <inheritdoc />
    public partial class seedSomeTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Material",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Material",
                value: "100% Cotton");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand_name", "Material" },
                values: new object[] { "adidas", "100% Cotton" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand_name", "Material" },
                values: new object[] { "ZARA", "100% Cotton" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Material",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Brand_name",
                value: "adedass");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Brand_name",
                value: "nike");
        }
    }
}
