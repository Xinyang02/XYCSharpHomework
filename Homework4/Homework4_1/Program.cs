using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_1
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> temp = head;
            while (temp != tail)
            {
                action(temp.Data);
                temp = temp.Next;
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x <= 10; x++)
            {
                intlist.Add(x);
            }
            intlist.ForEach(x => Console.WriteLine(x));
            int sum = 0;
            int max, min;
            max = min = intlist.Head.Data;
            intlist.ForEach(x => { sum += x; });
            Console.WriteLine("sum=" + sum);
            intlist.ForEach(x => { max = max < x ? x : max; });
            intlist.ForEach(x => { min = min > x ? x : min; });
            Console.WriteLine("Max=" + max + "  Min=" + min);
        }
    }
}
