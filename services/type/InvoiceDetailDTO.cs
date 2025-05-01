using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rice_store.services.type
{
    public class InvoiceDetailDTO
    {
        public string ProductName { get; set; }
        public string Quantity { get; set; }
        public string UnitPrice { get; set; }
        public string TotalPrice { get; set; }
    }
}
