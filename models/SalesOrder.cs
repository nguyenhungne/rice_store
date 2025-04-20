using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rice_store.models
{
    [Table("sales_orders")]
    public class SalesOrder
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("Customer")]
        [Column("customer_id")]
        public int? CustomerId { get; set; }

        [Column("order_date")]
        public DateTime OrderDate { get; set; }

        [Column("payment_method")]
        public string PaymentMethod { get; set; }

        [Column("status")]
        public string Status { get; set; }

        public Customer? Customer { get; set; }
    }
}
