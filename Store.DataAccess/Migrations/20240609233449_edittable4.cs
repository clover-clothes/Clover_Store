using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clover_Store.Migrations
{
    /// <inheritdoc />
    public partial class edittable4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Products_ProductId",
                table: "ShoppingCart");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ShoppingCart",
                newName: "AttributId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCart_ProductId",
                table: "ShoppingCart",
                newName: "IX_ShoppingCart_AttributId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_attributes_AttributId",
                table: "ShoppingCart",
                column: "AttributId",
                principalTable: "attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_attributes_AttributId",
                table: "ShoppingCart");

            migrationBuilder.RenameColumn(
                name: "AttributId",
                table: "ShoppingCart",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCart_AttributId",
                table: "ShoppingCart",
                newName: "IX_ShoppingCart_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Products_ProductId",
                table: "ShoppingCart",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
