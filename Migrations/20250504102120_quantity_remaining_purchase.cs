using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rice_store.Migrations
{
    /// <inheritdoc />
    public partial class quantity_remaining_purchase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "quantity_remaining",
                table: "purchase_order_details",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quantity_remaining",
                table: "purchase_order_details");
        }
    }
}
