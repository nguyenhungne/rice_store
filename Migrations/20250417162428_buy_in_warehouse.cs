using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rice_store.Migrations
{
    /// <inheritdoc />
    public partial class buy_in_warehouse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sales_order_details_products_product_id",
                table: "sales_order_details");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "sales_order_details",
                newName: "warehouse_id");

            migrationBuilder.RenameIndex(
                name: "IX_sales_order_details_product_id",
                table: "sales_order_details",
                newName: "IX_sales_order_details_warehouse_id");

            migrationBuilder.AddForeignKey(
                name: "FK_sales_order_details_warehouses_warehouse_id",
                table: "sales_order_details",
                column: "warehouse_id",
                principalTable: "warehouses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sales_order_details_warehouses_warehouse_id",
                table: "sales_order_details");

            migrationBuilder.RenameColumn(
                name: "warehouse_id",
                table: "sales_order_details",
                newName: "product_id");

            migrationBuilder.RenameIndex(
                name: "IX_sales_order_details_warehouse_id",
                table: "sales_order_details",
                newName: "IX_sales_order_details_product_id");

            migrationBuilder.AddForeignKey(
                name: "FK_sales_order_details_products_product_id",
                table: "sales_order_details",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
