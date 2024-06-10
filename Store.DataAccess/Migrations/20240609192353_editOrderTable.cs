using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clover_Store.Migrations
{
    /// <inheritdoc />
    public partial class editOrderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_CustomerId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_CustomerId",
                table: "Order");

            migrationBuilder.AddColumn<string>(
                name: "CustomerUId",
                table: "Order",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image_url",
                value: "/Images/product/Screenshot2024-06-06160542.png");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image_url",
                value: "/Images/product/Screenshot2024-06-06161345.png");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image_url",
                value: "/Images/product/Screenshot2024-06-06160542.png");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image_url",
                value: "/Images/product/Screenshot2024-06-06160542.png");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image_url",
                value: "/Images/product/Screenshot2024-06-06160542.png");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image_url",
                value: "/Images/product/Screenshot2024-06-06160542.png");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerUId",
                table: "Order",
                column: "CustomerUId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_CustomerUId",
                table: "Order",
                column: "CustomerUId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_CustomerUId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_CustomerUId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CustomerUId",
                table: "Order");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image_url",
                value: "~/Images/product/Screenshot 2024-06-06 160542.png");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image_url",
                value: "~/Images/product/Screenshot 2024-06-06 161345.png");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image_url",
                value: "~/Images/product/Screenshot 2024-06-06 160542.png");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image_url",
                value: "~/Images/product/Screenshot 2024-06-06 160542.png");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image_url",
                value: "~/Images/product/Screenshot 2024-06-06 160542.png");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image_url",
                value: "~/Images/product/Screenshot 2024-06-06 160542.png");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_CustomerId",
                table: "Order",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
