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

        [ForeignKey("Product")]
        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("unit_price")]
        public decimal UnitPrice { get; set; }

        public SalesOrder SalesOrder { get; set; }
        public Product Product { get; set; }
    }
}
