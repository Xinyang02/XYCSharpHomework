using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class Order
    {
        public int OrderId { get; set; }
        public String CustomerName { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int TotalPrice
        {
            get
            {
                int total = 0;
                foreach (OrderItem orderItem in OrderItems)
                    total += orderItem.UnitPrice * orderItem.Number;
                return total;
            }
        }

        public Order(string cusName)
        {
            CustomerName = cusName;
        }
    }
}
