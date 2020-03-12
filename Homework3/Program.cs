using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public interface Shape
    {
        bool IShape();
        double CountArea();
    }

    class Rectangle : Shape
    {
        private double Width, Heigth;
        public double width { get => Width; }
        public double heigth { get => Heigth; }
        public Rectangle(double a,double b)
        {            
            this.Width = a; this.Heigth = b;
            this.Draw();
        }
        public bool IShape()
        {
            return true;
        }
        public double CountArea()
        {
            return width * heigth;
        }
        public void Draw()
        {
            if (this.IShape())
            {
                Console.Write("Rectangle"+" ");
                Console.WriteLine("area=" + this.CountArea());
            }
        }
    }

    class Square : Shape
    {
        private double edge;
        public Square(double a)
        {
            this.edge = a;
            this.Draw();
        }
        public bool IShape()
        {
            return true;
        }
        public double CountArea()
        {
            return this.edge*this.edge;
        }
        public void Draw()
        {
            if (this.IShape())
            {
                Console.Write("Square" + " ");
                Console.WriteLine("area=" + this.CountArea());
            }
        }
    }

    class Triangle : Shape
    {
        private double edge1, edge2, edge3;
        public Triangle(double a, double b,double c)
        {
            this.edge1 = a; this.edge2 = b; this.edge3 = c;
            this.Draw();
        }
        public bool IShape()
        {
            if(this.edge1+ this.edge2> this.edge3&& this.edge1 + this.edge3 > this.edge2 && this.edge3 + this.edge2 > this.edge1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double CountArea()
        {
            double p = (this.edge1 + this.edge2 + this.edge3)/2;
            return Math.Sqrt(p * (p - this.edge1) * (p - this.edge2) * (p - this.edge3));
        }
        public void Draw()
        {
            if (this.IShape())
            {
                Console.Write("Triangle" + " ");
                Console.WriteLine("area=" + this.CountArea());
            }
        }
    }

    class Factory
    {
        private static readonly Random R = new Random();
        public static Object GetShape(int shapeType)
        {
            switch (shapeType)
            {
                case 1:
                    return new Rectangle(10 * R.NextDouble(), 10 * R.NextDouble());
                case 2:
                    return new Square(10 * R.NextDouble());
                case 3:
                    return new Triangle(10 * R.NextDouble(), 10 * R.NextDouble(), 10 * R.NextDouble());
                default:
                    throw new ArgumentException(message: "can't do it");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            Object[] shapes = new Object[10];
            for(int i = 0; i < 10; i++)
            {
                shapes[i] = Factory.GetShape(rd.Next(1, 3));
            }
        }
    }
}
