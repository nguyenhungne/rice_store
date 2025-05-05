    using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rice_store.models
{
    [Table("purchase_orders")]
    public class PurchaseOrder
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
            
        [ForeignKey("Supplier")]
        [Column("supplier_id")]
        public int SupplierId { get; set; }

        [Column("order_date")]
        public DateTime OrderDate { get; set; }

        [Column("status")]  
        public string Status { get; set; }

        public Supplier Supplier { get; set; }
    }
}
