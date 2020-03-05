using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static double[] dealArray(int[] num)
        {
            double[] ans = new double[4];
            ans[0] = -1e9;ans[1] = 1e9;
            for(int i = 0; i < num.Length; i++)
            {
                if (num[i] > ans[0]) ans[0] = num[i];
                if (num[i] < ans[1]) ans[1] = num[i];
                ans[2] += num[i];
                ans[3] += num[i];
            }
            ans[3] /= num.Length;
            return ans;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数组长度：");
            String s = Console.ReadLine();
            int n = Int32.Parse(s);
            int[] a = new int[n];
            Console.WriteLine("请输入数组的值：");
            for(int i = 0; i < n; i++)
            {
                String s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
            double[] answer=dealArray(a);
            Console.WriteLine("此数组的最大值为：" + answer[0]);
            Console.WriteLine("此数组的最小值为：" + answer[1]);
            Console.WriteLine("此数组值的和为：" + answer[2]);
            Console.WriteLine("此数组的平均值为：" + answer[3]);
        }
    }
}
