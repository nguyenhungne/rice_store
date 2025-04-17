using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rice_store.Migrations
{
    /// <inheritdoc />
    public partial class revert_change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_warehouses_inventory_id",
                table: "warehouses",
                column: "inventory_id");

            migrationBuilder.CreateIndex(
                name: "IX_warehouses_product_id",
                table: "warehouses",
                column: "product_id");

            migrationBuilder.AddForeignKey(
                name: "FK_warehouses_inventories_inventory_id",
                table: "warehouses",
                column: "inventory_id",
                principalTable: "inventories",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_warehouses_products_product_id",
                table: "warehouses",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_warehouses_inventories_inventory_id",
                table: "warehouses");

            migrationBuilder.DropForeignKey(
                name: "FK_warehouses_products_product_id",
                table: "warehouses");

            migrationBuilder.DropIndex(
                name: "IX_warehouses_inventory_id",
                table: "warehouses");

            migrationBuilder.DropIndex(
                name: "IX_warehouses_product_id",
                table: "warehouses");
        }
    }
}
