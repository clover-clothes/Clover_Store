using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clover_Store.Migrations
{
    /// <inheritdoc />
    public partial class editTables6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviwe_Customer_CusomerID",
                table: "Reviwe");

            migrationBuilder.DropForeignKey(
                name: "FK_wishList_Customer_CustomerID",
                table: "wishList");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "wishList",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CusomerID",
                table: "Reviwe",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviwe_AspNetUsers_CusomerID",
                table: "Reviwe",
                column: "CusomerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_wishList_AspNetUsers_CustomerID",
                table: "wishList",
                column: "CustomerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviwe_AspNetUsers_CusomerID",
                table: "Reviwe");

            migrationBuilder.DropForeignKey(
                name: "FK_wishList_AspNetUsers_CustomerID",
                table: "wishList");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "wishList",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "CusomerID",
                table: "Reviwe",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviwe_Customer_CusomerID",
                table: "Reviwe",
                column: "CusomerID",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_wishList_Customer_CustomerID",
                table: "wishList",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
