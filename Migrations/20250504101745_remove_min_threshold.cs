using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rice_store.Migrations
{
    /// <inheritdoc />
    public partial class remove_min_threshold : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "min_threshold",
                table: "warehouses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "min_threshold",
                table: "warehouses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
