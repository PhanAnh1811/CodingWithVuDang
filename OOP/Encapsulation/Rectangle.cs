using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Rectangle
    {
        private double length;
        private double width;
        
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public Rectangle() { }
        public Rectangle(double length,double width)
        {
            Length = length;
            Width = width;
        }
        public void Input()
        {
            Console.Write("Nhap chieu dai hinh chu nhat: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong hinh chu nhat: ");
            width = double.Parse(Console.ReadLine());
        }
        public string Output()
        {
            return "Rectangle[length=" + Length + ", width=" + Width + "]";
        }
        public double Perimeter()
        {
            return (Length + Width) * 2; ;
        }
        public double Area()
        {
            return Length * Width;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Width, 2));
        }
    }
}
