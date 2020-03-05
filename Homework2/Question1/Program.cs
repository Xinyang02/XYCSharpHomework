using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入一个正整数：");
                String s = Console.ReadLine();
                int num = Int32.Parse(s);
                if (num <= 0)
                {
                    Console.WriteLine("输入的数不是正数！");
                    return;
                }
                Console.WriteLine("这个数的所有素数因子为：");
                for(int i = 2; i <= num;)
                {
                    if(num % i == 0)
                    {
                        Console.Write(i + " ");
                        num /= i;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("输入的数不是整数！");
            }
        }
    }
}
