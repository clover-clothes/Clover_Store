using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clover_Store.Migrations
{
    /// <inheritdoc />
    public partial class tablsedit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Images",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Images2",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Images3",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Profile_image",
                table: "Cutomer");

            migrationBuilder.DropColumn(
                name: "RGB_number",
                table: "Colors");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Products",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Customer",
                table: "Order",
                newName: "CustomerId");

            migrationBuilder.AlterColumn<string>(
                name: "User_name",
                table: "Cutomer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Cutomer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Full_name",
                table: "Cutomer",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Image_url",
                table: "Cutomer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Blue",
                table: "Colors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Green",
                table: "Colors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Red",
                table: "Colors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Card_number",
                table: "Card",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Card_CVC",
                table: "Card",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProductId",
                table: "Image",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropColumn(
                name: "Image_url",
                table: "Cutomer");

            migrationBuilder.DropColumn(
                name: "Blue",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "Green",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "Red",
                table: "Colors");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Products",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Order",
                newName: "Customer");

            migrationBuilder.AddColumn<byte[]>(
                name: "Images",
                table: "Products",
                type: "Image",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Images2",
                table: "Products",
                type: "Image",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Images3",
                table: "Products",
                type: "Image",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "User_name",
                table: "Cutomer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Cutomer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Full_name",
                table: "Cutomer",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<byte[]>(
                name: "Profile_image",
                table: "Cutomer",
                type: "Image",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RGB_number",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Card_number",
                table: "Card",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "Card_CVC",
                table: "Card",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);
        }
    }
}
