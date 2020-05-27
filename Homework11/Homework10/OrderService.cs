using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    class OrderService
    {
        Model1 db;

        public void addOrder(string cusName,List<OrderItem> orderItems)
        {
            using (db= new Model1())
            {
                var order = new Order(cusName);
                order.OrderItems = orderItems;
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }

        public void deleteOrder(int orderId)
        {
            using(db=new Model1())
            {
                var order = db.Orders.Include("OrderItems").FirstOrDefault(p => p.OrderId == orderId);
                if(order!=null)
                {
                    db.Orders.Remove(order);
                    db.SaveChanges();
                }
            }
        }

        public Order searchOrderById(int id)
        {
            Order order=null;
            using(db=new Model1())
            {
                order = db.Orders.FirstOrDefault(p => p.OrderId == id);
                if (order == null)
                    return null;
            }
            return order;
        }

        public Order searchOrderByCustomer(string cusName)
        {
            Order order = null;
            using(db=new Model1())
            {
                order = db.Orders.FirstOrDefault(p => p.CustomerName == cusName);
                if (order == null)
                    return null;
            }
            return order;
        }
    }
}
