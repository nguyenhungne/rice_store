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

        [ForeignKey("Product")]
        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("unit_price")]
        public decimal UnitPrice { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
        public Product Product { get; set; }
    }
}
