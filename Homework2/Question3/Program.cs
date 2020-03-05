using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] flag = new bool[101];
            for(int i = 2; i < 101; i++)
            {
                flag[i] = true;
            }
            Console.WriteLine("2-100以内的素数有：");
            for(int i = 2; i <= 100; i++)
            {
                if (flag[i])
                {
                    Console.Write(i + " ");
                    for(int j = i + i; j <= 100; j += i)
                    {
                        if (flag[j])
                        {
                            flag[j] = false;
                        }
                    }
                }
            }
        }
    }
}
