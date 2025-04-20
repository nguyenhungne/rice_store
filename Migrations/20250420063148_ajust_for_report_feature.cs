using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rice_store.Migrations
{
    /// <inheritdoc />
    public partial class ajust_for_report_feature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "financial_transactions");

            migrationBuilder.DropColumn(
                name: "total_amount",
                table: "sales_orders");

            migrationBuilder.AlterColumn<int>(
                name: "customer_id",
                table: "sales_orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "customer_id",
                table: "sales_orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "total_amount",
                table: "sales_orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "financial_transactions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    related_order_id = table.Column<int>(type: "int", nullable: true),
                    related_purchase_id = table.Column<int>(type: "int", nullable: true),
                    amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    transaction_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    transaction_type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_financial_transactions", x => x.id);
                    table.ForeignKey(
                        name: "FK_financial_transactions_purchase_orders_related_purchase_id",
                        column: x => x.related_purchase_id,
                        principalTable: "purchase_orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_financial_transactions_sales_orders_related_order_id",
                        column: x => x.related_order_id,
                        principalTable: "sales_orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_financial_transactions_related_order_id",
                table: "financial_transactions",
                column: "related_order_id");

            migrationBuilder.CreateIndex(
                name: "IX_financial_transactions_related_purchase_id",
                table: "financial_transactions",
                column: "related_purchase_id");
        }
    }
}
