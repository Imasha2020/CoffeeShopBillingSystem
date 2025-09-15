using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopBilling
{
    public class Order
    {
        public int No { get; set; }
        public string customerName { get; set; }
        public DateTime OrderDate { get; set; }
        public string CoffeeType { get; set; }
        public int quantity { get; set; }
        public string addsOn { get; set;} 
        public double netPayement { get; set; }
    }
}
