using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rice_store.services.type
{
    class InvoiceDTO
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }

        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public string PaymentMethod { get; set; }
        public string OrderDate { get; set; }
        public string Inventory { get; set; }
        public List<InvoiceDetailDTO> InvoiceDetails { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmountAfterDiscount { get; set; }

    }
}
