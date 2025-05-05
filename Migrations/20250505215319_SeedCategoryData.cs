using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rice_store.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoryData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "id", "is_deleted", "name" },
                values: new object[,]
                {
                    { 1, false, "Gạo Tám Thơm" },
                    { 2, false, "Gạo ST25" },
                    { 3, false, "Gạo Lứt" },
                    { 4, false, "Gạo Nếp" },
                    { 5, false, "Gạo Tài Nguyên" },
                    { 6, false, "Gạo Hương Lài" },
                    { 7, false, "Gạo Nhật" },
                    { 8, false, "Gạo Tấm" },
                    { 9, false, "Gạo Hữu Cơ" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 9);
        }
    }
}
