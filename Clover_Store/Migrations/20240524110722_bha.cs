using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Clover_Store.Migrations
{
    /// <inheritdoc />
    public partial class bha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Cutomer",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Log_date",
                table: "Cutomer",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Cutomer",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)",
                oldMaxLength: 24);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Log_date",
                table: "Cutomer",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
    }
}
