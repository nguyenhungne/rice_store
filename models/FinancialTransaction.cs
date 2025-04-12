using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rice_store.models
{
    [Table("financial_transactions")]
    public class FinancialTransaction
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("transaction_type")]
        public string TransactionType { get; set; }

        [Column("amount")]
        public decimal Amount { get; set; }

        [Column("transaction_date")]
        public DateTime TransactionDate { get; set; }

        [ForeignKey("SalesOrder")]
        [Column("related_order_id")]
        public int? RelatedOrderId { get; set; }

        [ForeignKey("PurchaseOrder")]
        [Column("related_purchase_id")]
        public int? RelatedPurchaseId { get; set; }

        [Column("description")]
        public string Description { get; set; }

        public SalesOrder SalesOrder { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
    }
}
