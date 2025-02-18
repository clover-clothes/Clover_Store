using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Clover_Store.Migrations
{
    /// <inheritdoc />
    public partial class seed7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

        
            migrationBuilder.InsertData(
                table: "attributes",
                columns: new[] {  "ColorID", "Price", "ProductID", "Quantity", "SizeID" },
                values: new object[,]
                {
                    {  1, 699.99m, 1013, 10, 1 },
                    {  2, 975.00m, 1016, 8, 2 },
                    { 3, 975.00m, 1017, 14, 4 },
                    { 4, 899.99m, 1022, 10, 5 },
                    { 5, 699.99m, 1012, 10, 6 },
                    { 6, 799.99m, 1014, 10, 7 },
                    { 8, 675.00m, 1015, 10, 8 },
                    { 4, 899.99m, 1019, 10, 9 },
                    { 5, 899.99m, 1020, 10, 10 },
                    { 1, 899.99m, 1021, 10, 11 },
                    { 2, 899.99m, 1023, 10, 12 },
                    { 3, 899.99m, 1024, 15, 13 }
                });
        }

       
    }
}
