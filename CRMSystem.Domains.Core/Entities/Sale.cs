using System;
using System.Collections.Generic;
using System.Text;

namespace CRMSystem.Domains
{
    public class Sale: BaseEntity
    {
        public int ProductID { get; set; }
        public int CustomerID { get; set; }

        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public string InvoiceNo { get; set; }

    }
}
