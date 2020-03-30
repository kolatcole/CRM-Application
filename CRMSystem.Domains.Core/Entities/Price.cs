using System;
using System.Collections.Generic;
using System.Text;

namespace CRMSystem.Domains
{
    public class Price:BaseEntity
    {
       
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
    }
}
