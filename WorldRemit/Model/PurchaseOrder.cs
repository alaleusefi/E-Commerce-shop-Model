using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldRemit.Model
{
    public class PurchaseOrder
    {
        public int ID { get; set; }
        public Customer Customer { get; set; }
        public double TotalPrice { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
