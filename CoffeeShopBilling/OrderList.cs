using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopBilling
{
    public class OrderList
    {
        private static List<Order> orders = new List<Order>();

        public static void AddOrder(Order order) {
            orders.Add(order);
        }

        public static List<Order> getOrders()
        {
            return orders;
        }

        public static int GetNextOrderNumber() {
            if (orders.Count == 0) {
                return 1;
            }
            else
            {
                return orders.Count + 1;
            }
        }
    }
}
