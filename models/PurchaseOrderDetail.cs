using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rice_store.models
{
    [Table("purchase_order_details")]
    public class PurchaseOrderDetail
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("PurchaseOrder")]
        [Column("purchase_order_id")]
        public int PurchaseOrderId { get; set; }

        [ForeignKey("Warehouse")]
        [Column("warehouse_id")]
        public int WarehouseId { get; set; }

        [Column("quantity")]
        public decimal Quantity { get; set; }

        [Column("unit_price")]
        public decimal UnitPrice { get; set; }

        [Column("expiration_date")]
        public DateTime ExpirationDate { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
