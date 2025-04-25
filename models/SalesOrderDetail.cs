using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rice_store.models
{
    [Table("sales_order_details")]
    public class SalesOrderDetail
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("SalesOrder")]
        [Column("sales_order_id")]
        public int SalesOrderId { get; set; }

        [ForeignKey("Warehouse")]
        [Column("warehouse_id")]
        public int WarehouseId { get; set; }

        [Column("quantity")]
        public decimal Quantity { get; set; }

        [Column("unit_price")]
        public decimal UnitPrice { get; set; }

        public SalesOrder SalesOrder { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
