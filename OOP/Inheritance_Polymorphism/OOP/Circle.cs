using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Circle : Shape
    {
        private double radius;

        public double Radius { get; set; }
        public Circle() { }
        public Circle(string color,bool filled,double radius)
            :base(color,filled)
        {
            Color = color;
            Filled = filled;
            Radius = radius;
        }
        public override double getArea()
        {
            return Math.PI * (Radius * Radius);
        }

        public override double getPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string toString()
        {
            return "Dien tich hinh tron la " + getArea() + "\n"
                + "Chu vi hinh tron la " + getPerimeter() + "\n";
        }
    }
}
