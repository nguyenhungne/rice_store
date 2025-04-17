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

        [Column("name")]
        public string name { get; set; }
    }
}
