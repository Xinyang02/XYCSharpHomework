using System;
using System.Collections.Generic;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();
            while (true)
            {   Console.WriteLine("请选择功能：添加订单；删除订单；查找订单；设置订单；退出系统；序列化；反序列化。");
                string mod = Console.ReadLine();
                switch (mod)
                {
                    case "添加订单":
                        List<OrderItem> orderItems = new List<OrderItem>();
                        while (true)
                        {
                            Console.WriteLine("请输入商品名称:");
                            string goodname = Console.ReadLine();
                            Console.WriteLine("请输入商品数量:");
                            int goodnum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("请输入商品单价");
                            int goodprice = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("请输入客户名:");
                            string cusname = Console.ReadLine();
                            Console.WriteLine("是否购买其他商品：是/否");
                            string flag = Console.ReadLine();
                            if(flag=="是")
                            {
                                orderItems.Add(new OrderItem(goodname, goodnum, goodprice));
                            }
                            else if(flag=="否")
                            {
                                orderItems.Add(new OrderItem(goodname, goodnum, goodprice));
                                service.AddOrder(cusname, orderItems);
                                break;
                            }
                        }
                        break;
                    case "删除订单":
                        while(true)
                        {
                            Console.WriteLine("请输入订单号:");
                            int ornum = Int32.Parse(Console.ReadLine());
                            service.DeleteOrder(ornum);
                            Console.WriteLine("是否继续删除:是/否");
                            string flag = Console.ReadLine();
                            if (flag == "是")
                                continue;
                            else if (flag == "否")
                                break;
                        }
                        break;
                    case "查找订单":
                        while(true)
                        {
                            Console.WriteLine("请输入查找模式：订单号查找/商品名查找/客户名查找");
                            string mode = Console.ReadLine();
                            if(mode=="订单号查找")
                            {
                                Console.WriteLine("请输入订单号:");
                                int num = Int32.Parse(Console.ReadLine());
                                Console.WriteLine(service.SearchOrderNum(num));
                            }
                            else if(mode=="商品名查找")
                            {
                                Console.WriteLine("请输入商品名:");
                                string name = Console.ReadLine();
                                Console.WriteLine(service.SearchItemName(name));
                            }
                            else if(mode=="客户名查找")
                            {
                                Console.WriteLine("请输入客户名:");
                                string name = Console.ReadLine();
                                Console.WriteLine(service.SearchCustomer(name));
                            }
                            Console.WriteLine("是否继续查找:是/否");
                            string flag = Console.ReadLine();
                            if (flag == "是")
                                continue;
                            else if (flag == "否")
                                break;
                        }
                        break;
                    case "设置订单":
                        while(true)
                        {
                            Console.WriteLine("请输入订单号:");
                            int ornum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("请输入修改后的订单号");
                            int ornum1= Int32.Parse(Console.ReadLine());
                            service.SetOrderNum(ornum, ornum1);
                            Console.WriteLine("是否继续修改:是/否");
                            string flag = Console.ReadLine();
                            if (flag == "是")
                                continue;
                            else if (flag == "否")
                                break;
                        }
                        break;
                    case "序列化":
                        service.Export();
                        break;
                    case "反序列化":
                        service.Import("test.xml");
                        break;
                    case "退出系统":
                        break;
                    default:Console.WriteLine("无此功能");break;
                }
            }
        }
    }
}
