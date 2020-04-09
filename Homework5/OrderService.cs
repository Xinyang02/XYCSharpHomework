using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class OrderService
    {
        public List<Order> orders = new List<Order>();
        public void AddOrder(string cusname, List<OrderItem> items)
        {
            int count = 0;
            foreach (Order order in orders)
                count++;
            orders.Add(new Order(count, cusname, items));
        }

        public Order SearchOrderNum(int num)
        {
            var order = orders.Where(or => or.OrderNum == num)
                .OrderBy(or => or.TotalPrice());
            Order[] ods = order.ToArray<Order>();
            if (ods.Length == 0)
                throw new OrderException("无此订单");
            return ods[0];
        }

        public Order[] SearchItemName(string name)
        {
            var order = orders.Where(or => or.orderItems.Contains(new OrderItem(name, 0, 0)))
                .OrderBy(or => or.TotalPrice());
            Order[] ods = order.ToArray<Order>();
            if (ods.Length == 0)
                throw new OrderException("无此订单");
            Foreach(ods, m => Console.WriteLine(m));
            return ods;
        }

        public Order[] SearchCustomer(string cus)
        {
            var order = orders.Where(or => or.Customer == cus)
                .OrderBy(or => or.TotalPrice());
            Order[] ods = order.ToArray<Order>();
            if (ods.Length == 0)
                throw new OrderException("无此订单");
            Foreach(ods, m => Console.WriteLine(m));
            return ods;
        }

        public void DeleteOrder(int num)
        {
            Order order = SearchOrderNum(num);
            orders.Remove(order);
        }

        public void SetOrderNum(int prenum, int num)
        {
            Order order = SearchOrderNum(prenum);
            for (int i = 0; i < orders.Count; i++)
                if (orders[i].OrderNum == num)
                    throw new OrderException("订单号已存在");
            order.OrderNum = num;
        }

        public void SetItemName(int num, int itemnum, string name)
        {
            Order order = SearchOrderNum(num);
            order.orderItems[itemnum].Name = name;
        }

        public void SetItemNum(int num, int item, int itemnum)
        {
            Order order = SearchOrderNum(num);
            order.orderItems[item].Number = itemnum;
        }

        public void SetItemPrice(int num, int item, int itemprice)
        {
            Order order = SearchOrderNum(num);
            order.orderItems[item].UnitPrice = itemprice;
        }

        public void SetCusName(int num, string name)
        {
            Order order = SearchOrderNum(num);
            order.Customer = name;
        }

        public void OrderSort()
        {
            orders.Sort();
        }

        public void Delete(int ordermnum)
        {
            if (orders[ordermnum] == null)
                throw new OrderException("无此订单");
            orders.Remove(orders[ordermnum]);
        }

        private static void Foreach(Order[] orderlist, Action<Order> action)
        {
            for (int i = 0; i < orderlist.Length; i++)
                action(orderlist[i]);
        }
    }
}
