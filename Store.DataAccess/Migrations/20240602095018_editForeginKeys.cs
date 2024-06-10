using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clover_Store.Migrations
{
    /// <inheritdoc />
    public partial class editForeginKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Products_ProductId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Image",
                newName: "attributId");

            migrationBuilder.RenameIndex(
                name: "IX_Image_ProductId",
                table: "Image",
                newName: "IX_Image_attributId");

            migrationBuilder.CreateIndex(
                name: "IX_wishList_CustomerID",
                table: "wishList",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_wishList_ProductID",
                table: "wishList",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviwe_CusomerID",
                table: "Reviwe",
                column: "CusomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviwe_ProductID",
                table: "Reviwe",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_AttrbuteID",
                table: "OrderItem",
                column: "AttrbuteID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CardID",
                table: "Order",
                column: "CardID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_attributes_ColorID",
                table: "attributes",
                column: "ColorID");

            migrationBuilder.CreateIndex(
                name: "IX_attributes_ProductID",
                table: "attributes",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_attributes_SizeID",
                table: "attributes",
                column: "SizeID");

            migrationBuilder.AddForeignKey(
                name: "FK_attributes_Colors_ColorID",
                table: "attributes",
                column: "ColorID",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_attributes_Products_ProductID",
                table: "attributes",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_attributes_Sizes_SizeID",
                table: "attributes",
                column: "SizeID",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_attributes_attributId",
                table: "Image",
                column: "attributId",
                principalTable: "attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Card_CardID",
                table: "Order",
                column: "CardID",
                principalTable: "Card",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Cutomer_CustomerId",
                table: "Order",
                column: "CustomerId",
                principalTable: "Cutomer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderID",
                table: "OrderItem",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_attributes_AttrbuteID",
                table: "OrderItem",
                column: "AttrbuteID",
                principalTable: "attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categorys_CategoryID",
                table: "Products",
                column: "CategoryID",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviwe_Cutomer_CusomerID",
                table: "Reviwe",
                column: "CusomerID",
                principalTable: "Cutomer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviwe_Products_ProductID",
                table: "Reviwe",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_wishList_Cutomer_CustomerID",
                table: "wishList",
                column: "CustomerID",
                principalTable: "Cutomer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_wishList_Products_ProductID",
                table: "wishList",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attributes_Colors_ColorID",
                table: "attributes");

            migrationBuilder.DropForeignKey(
                name: "FK_attributes_Products_ProductID",
                table: "attributes");

            migrationBuilder.DropForeignKey(
                name: "FK_attributes_Sizes_SizeID",
                table: "attributes");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_attributes_attributId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Card_CardID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Cutomer_CustomerId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderID",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_attributes_AttrbuteID",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categorys_CategoryID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviwe_Cutomer_CusomerID",
                table: "Reviwe");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviwe_Products_ProductID",
                table: "Reviwe");

            migrationBuilder.DropForeignKey(
                name: "FK_wishList_Cutomer_CustomerID",
                table: "wishList");

            migrationBuilder.DropForeignKey(
                name: "FK_wishList_Products_ProductID",
                table: "wishList");

            migrationBuilder.DropIndex(
                name: "IX_wishList_CustomerID",
                table: "wishList");

            migrationBuilder.DropIndex(
                name: "IX_wishList_ProductID",
                table: "wishList");

            migrationBuilder.DropIndex(
                name: "IX_Reviwe_CusomerID",
                table: "Reviwe");

            migrationBuilder.DropIndex(
                name: "IX_Reviwe_ProductID",
                table: "Reviwe");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_AttrbuteID",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_Order_CardID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_CustomerId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_attributes_ColorID",
                table: "attributes");

            migrationBuilder.DropIndex(
                name: "IX_attributes_ProductID",
                table: "attributes");

            migrationBuilder.DropIndex(
                name: "IX_attributes_SizeID",
                table: "attributes");

            migrationBuilder.RenameColumn(
                name: "attributId",
                table: "Image",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Image_attributId",
                table: "Image",
                newName: "IX_Image_ProductId");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "OrderItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Products_ProductId",
                table: "Image",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
