using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rice_store.Migrations
{
    /// <inheritdoc />
    public partial class remove_total_amount_in_PurchaseOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "total_amount",
                table: "purchase_orders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "total_amount",
                table: "purchase_orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
