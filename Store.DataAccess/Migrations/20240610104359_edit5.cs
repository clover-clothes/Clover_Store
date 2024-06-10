using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clover_Store.Migrations
{
    /// <inheritdoc />
    public partial class edit5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_AspNetUsers_CustomerId",
                table: "ShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCart_CustomerId",
                table: "ShoppingCart");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "ShoppingCart");

            migrationBuilder.DropColumn(
                name: "CustomerUsersId",
                table: "ShoppingCart");

            migrationBuilder.AddColumn<string>(
                name: "CustomerUId",
                table: "ShoppingCart",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_CustomerUId",
                table: "ShoppingCart",
                column: "CustomerUId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_AspNetUsers_CustomerUId",
                table: "ShoppingCart",
                column: "CustomerUId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_AspNetUsers_CustomerUId",
                table: "ShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCart_CustomerUId",
                table: "ShoppingCart");

            migrationBuilder.DropColumn(
                name: "CustomerUId",
                table: "ShoppingCart");

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "ShoppingCart",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerUsersId",
                table: "ShoppingCart",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_CustomerId",
                table: "ShoppingCart",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_AspNetUsers_CustomerId",
                table: "ShoppingCart",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
