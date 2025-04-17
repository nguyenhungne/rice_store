using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rice_store.models
{
    [Table("warehouses")]
    public class Warehouse
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("Product")]
        [Column("product_id")]
        public int ProductId { get; set; }

        [ForeignKey("Inventory")]
        [Column("inventory_id")]
        public int InventoryId { get; set; }

        [Column("batch_number")]
        public string BatchNumber { get; set; }

        [Column("min_threshold")]
        public int MinThreshold { get; set; }

        [Column("expiration_date")]
        public DateTime ExpirationDate { get; set; }

        public Product Product { get; set; }
        public Inventory Inventory { get; set; }
        public ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}
