using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop_withDB.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public string CustomerName { get; set; }
    }
}
