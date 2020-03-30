using System;
using System.Collections.Generic;
using System.Text;

namespace CRMSystem.Domains
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public int PriceID { get; set; }
        public Price Price { get; set; }
    }
}
