using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rice_store.Migrations
{
    /// <inheritdoc />
    public partial class SeedInventoryData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "inventories",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Quận 7, Tp. Hồ Chí Minh" },
                    { 2, "Quận 10, Tp. Hồ Chí Minh" },
                    { 3, "Quận Thủ Đức, Tp. Hồ Chí Minh" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "inventories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "inventories",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "inventories",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
