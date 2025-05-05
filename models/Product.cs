using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rice_store.models
{
    [Table("products")]
    public class Product
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("weight")]
        public float Weight { get; set; }

        [Column("origin")]
        public string Origin { get; set; }

        [Column("quality")]
        public string Quality { get; set; }

        [Column("selling_price")]
        public decimal SellingPrice { get; set; }

        [ForeignKey("Category")]
        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; } = false;

        public Category Category { get; set; }
    }
}
