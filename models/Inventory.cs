using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rice_store.models
{
    [Table("inventories")]
    public class Inventory
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("Product")]
        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("min_threshold")]
        public int MinThreshold { get; set; }

        public Product Product { get; set; }
    }
}
