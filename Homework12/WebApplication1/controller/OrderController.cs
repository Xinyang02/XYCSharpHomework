using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.models;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Microsoft.Extensions.Configuration;

namespace WebApplication1.controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController :ControllerBase
    {
        private readonly OrderContext orderDb;

        public OrderController(OrderContext context)
        {
            orderDb = context;
        }

        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            List<Order> orders = orderDb.Orders.Where(p=>p.Id>0).ToList<Order>();
            if (orders.Count==0)
                return NoContent();
            foreach(Order order in orders)
                order.OrderItems = orderDb.OrderItems.Where(p => p.Order.Id == order.Id).ToList<OrderItem>();
            return orders;
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetOrderById(int id)
        {
            Order order = orderDb.Orders.FirstOrDefault(p => p.Id == id);
            if (order == null)
                return NoContent();
            order.OrderItems = orderDb.OrderItems.Where(p => p.Order.Id == id).ToList<OrderItem>();
            return order;
        }

        [HttpGet("getorder")]
        public ActionResult<List<Order>> GetOrderByCus(string cusName)
        {
            List<Order> orders = orderDb.Orders.Where(p => p.CustomerName == cusName).ToList<Order>();
            foreach (Order order in orders)
                order.OrderItems = orderDb.OrderItems.Where(p => p.Order.Id == order.Id).ToList<OrderItem>();
            return orders;
        }

        [HttpPost]
        public ActionResult PostOrder(Order order)
        {
            try
            {
                foreach (OrderItem orderItem in order.OrderItems)
                    order.TotalPrice += orderItem.Amount * orderItem.UnitPrice;
                orderDb.Orders.Add(order);
                orderDb.SaveChanges();
            }catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            var order=orderDb.Orders.Include("OrderItems").FirstOrDefault(p => p.Id == id);
            if(order!=null)
            {
                orderDb.Orders.Remove(order);
                orderDb.SaveChanges();
                return Content("删除成功");
            }
            return Content("该订单不存在");
        }

        [HttpDelete("deleteorder")]
        public ActionResult DeleteOrderByCus(string cusName)
        {
            var order = orderDb.Orders.Include("OrderItems").Where(p => p.CustomerName == cusName).ToList<Order>();
            if (order.Count!=0)
            {
                orderDb.Orders.RemoveRange(order);
                orderDb.SaveChanges();
                return Content("删除成功");
            }
            return Content("该订单不存在");
        }

        [HttpPut("{id}")]
        public ActionResult ModifyOrder(int id,Order order)
        {
            if (id != order.Id)
                return BadRequest("无法修改");
            try
            {
                orderDb.Entry(order).State = EntityState.Modified;
                foreach (OrderItem orderItem in order.OrderItems)
                    orderDb.Entry(orderItem).State = EntityState.Modified;
                orderDb.SaveChanges();
            }catch(Exception e)
            {
                return Content(e.Message);
            }
            return Content("修改成功");
        }
    }
}
