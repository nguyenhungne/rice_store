using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rice_store.Migrations
{
    /// <inheritdoc />
    public partial class ReplaceLoyaltyPointsWithRank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "loyalty_points",
                table: "customers");

            migrationBuilder.AddColumn<string>(
                name: "rank",
                table: "customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rank",
                table: "customers");

            migrationBuilder.AddColumn<int>(
                name: "loyalty_points",
                table: "customers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
