using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rice_store.models
{
    [Table("reports")]
    public class Report
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("report_type")]
        public string ReportType { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [ForeignKey("User")]
        [Column("generated_by")]
        public int GeneratedBy { get; set; }

        [Column("month")]
        public int Month { get; set; }

        [Column("year")]
        public int Year { get; set; }

        [Column("total_income")]
        public decimal TotalIncome { get; set; }

        [Column("total_expense")]
        public decimal TotalExpense { get; set; }

        [Column("profit")]
        public decimal Profit { get; set; }

        public User User { get; set; }
    }
}
