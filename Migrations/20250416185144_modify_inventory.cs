using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rice_store.Migrations
{
    /// <inheritdoc />
    public partial class modify_inventory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inventories_products_product_id",
                table: "inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_purchase_order_details_products_product_id",
                table: "purchase_order_details");

            migrationBuilder.DropIndex(
                name: "IX_inventories_product_id",
                table: "inventories");

            migrationBuilder.DropColumn(
                name: "min_threshold",
                table: "inventories");

            migrationBuilder.DropColumn(
                name: "product_id",
                table: "inventories");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "purchase_order_details",
                newName: "warehouse_id");

            migrationBuilder.RenameIndex(
                name: "IX_purchase_order_details_product_id",
                table: "purchase_order_details",
                newName: "IX_purchase_order_details_warehouse_id");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "inventories",
                newName: "name");

            migrationBuilder.CreateTable(
                name: "warehouses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    inventory_id = table.Column<int>(type: "int", nullable: false),
                    batch_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    min_threshold = table.Column<int>(type: "int", nullable: false),
                    expiration_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_warehouses", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_purchase_order_details_warehouses_warehouse_id",
                table: "purchase_order_details",
                column: "warehouse_id",
                principalTable: "warehouses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_purchase_order_details_warehouses_warehouse_id",
                table: "purchase_order_details");

            migrationBuilder.DropTable(
                name: "warehouses");

            migrationBuilder.RenameColumn(
                name: "warehouse_id",
                table: "purchase_order_details",
                newName: "product_id");

            migrationBuilder.RenameIndex(
                name: "IX_purchase_order_details_warehouse_id",
                table: "purchase_order_details",
                newName: "IX_purchase_order_details_product_id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "inventories",
                newName: "quantity");

            migrationBuilder.AddColumn<int>(
                name: "min_threshold",
                table: "inventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "product_id",
                table: "inventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_inventories_product_id",
                table: "inventories",
                column: "product_id");

            migrationBuilder.AddForeignKey(
                name: "FK_inventories_products_product_id",
                table: "inventories",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_purchase_order_details_products_product_id",
                table: "purchase_order_details",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
