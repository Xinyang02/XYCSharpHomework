using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork5;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService service = new OrderService();
        [TestInitialize]
        public void init()
        {
            List<OrderItem> items = new List<OrderItem>();
            OrderItem item = new OrderItem("book", 10, 2);
            items.Add(item);
            service.AddOrder("djw", items);
        }
        [TestMethod()]
        public void AddOrderTest()
        {
            List<Order> orders = new List<Order>();
            List<OrderItem> items = new List<OrderItem>();
            OrderItem item = new OrderItem("book", 10, 2);
            items.Add(item);
            Order order = new Order(0, "djw", items);
            orders.Add(order);
            service.AddOrder("djw", items);
            CollectionAssert.Equals(orders, service.orders);
        }

        [TestMethod()]
        //[ExpectedException(typeof(OrderException))]
        public void SearchOrderNumTest()
        {
            service.SearchOrderNum(0);
        }

        [TestMethod()]
        //[ExpectedException(typeof(OrderException))]
        public void SearchItemNameTest()
        {
            service.SearchItemName("book");
        }

        [TestMethod()]
        //[ExpectedException(typeof(OrderException))]
        public void SearchCustomerTest()
        {
            service.SearchCustomer("djw");
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            service.DeleteOrder(0);
            List<Order> orders = new List<Order>();
            CollectionAssert.Equals(orders, service.orders);
        }

        [TestMethod()]
        public void SetOrderNumTest()
        {
            service.SetOrderNum(0, 1);
            Assert.AreEqual(service.orders[0].OrderNum,1);
        }

        [TestMethod()]
        public void SetItemNameTest()
        {
            service.SetItemName(0, 0, "roast duck");
            Assert.AreEqual(service.orders[0].orderItems[0].Name, "roast duck");
        }

        [TestMethod()]
        public void SetItemNumTest()
        {
            service.SetItemNum(0, 0, 1);
            Assert.AreEqual(service.orders[0].orderItems[0].Number,1);
        }

        [TestMethod()]
        public void SetItemPriceTest()
        {
            service.SetItemPrice(0, 0, 100);
            Assert.AreEqual(service.orders[0].orderItems[0].UnitPrice,100);
        }

        [TestMethod()]
        public void SetCusNameTest()
        {
            service.SetCusName(0, "ddj");
            Assert.AreEqual(service.orders[0].Customer,"ddj");
        }

        [TestMethod()]
        public void DeleteTest()
        {
            service.Delete(0);
            Assert.AreEqual(service.orders.Count, 0);
        }

        [TestMethod()]
        public void ExportTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ImportTest()
        {
            Assert.Fail();
        }
    }
}