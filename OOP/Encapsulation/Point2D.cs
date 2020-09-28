using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Point2D
    {
        //fields
        private int x;
        private int y;
        
        //Properties
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        //Constructor
        public Point2D()
        {
            x = 0;
            y = 0;
        }

        //Parameter
        public Point2D(int x,int y)
        {
            X = x;
            Y = y;
        }

        //Coppy Constructor
        public Point2D(Point2D point)
        {
            X = point.X;
            Y = point.Y;
        }

        public void Input()
        {
            Console.Write("Nhap x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
        public void Move(int x,int y)
        {
            this.x = X;
            this.y = Y;
        }
        public bool isOrigin()
        {
            return x == 0 & y == 0;
        }
        public double Distance(Point2D p)
        {
            return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
        }
        public static double Distance(Point2D p1,Point2D p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }
}
