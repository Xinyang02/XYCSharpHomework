using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int TotalPrice { get; set; }
       
    }
}
