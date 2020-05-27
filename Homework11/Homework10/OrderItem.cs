using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public class OrderItem
    {
        [Key]
        public String ItemName { get; set; }
        public int UnitPrice { get; set; }
        public int Number { get; set; }
        public Order Order { get; set; }
    }
}
