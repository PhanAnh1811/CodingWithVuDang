using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Triangle:Point2D
    {
        public Triangle(Point2D p1,Point2D p2,Point2D p3) { }
        public double Perimeter(double d1,double d2,double d3)
        {
            return d1 + d2 + d3;
        }
        public double Area(double halfPerimeter,double d1,double d2,double d3)
        {
            return Math.Sqrt(halfPerimeter * (halfPerimeter - d1) * (halfPerimeter - d2) * (halfPerimeter - d3));
        }
    }
}
