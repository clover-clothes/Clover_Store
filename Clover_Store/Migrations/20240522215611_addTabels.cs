using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clover_Store.Migrations
{
    /// <inheritdoc />
    public partial class addTabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "attributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    ColorID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Card_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Card_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Card_CVC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EXdate = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RGB_number = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cutomer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Full_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phon_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Log_date = table.Column<DateTime>(type: "Date", nullable: false),
                    Profile_image = table.Column<byte[]>(type: "Image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cutomer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_date = table.Column<DateTime>(type: "Date", nullable: false),
                    Customer = table.Column<int>(type: "int", nullable: false),
                    CardID = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zip_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total_price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    AttrbuteID = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Total_quantity = table.Column<int>(type: "int", nullable: false),
                    Brand_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Images = table.Column<byte[]>(type: "Image", nullable: true),
                    Images2 = table.Column<byte[]>(type: "Image", nullable: true),
                    Images3 = table.Column<byte[]>(type: "Image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviwe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    CusomerID = table.Column<int>(type: "int", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviwe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wishList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wishList", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "attributes");

            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Cutomer");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Reviwe");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "wishList");
        }
    }
}
