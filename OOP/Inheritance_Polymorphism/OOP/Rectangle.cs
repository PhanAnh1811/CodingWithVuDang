using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Rectangle:Shape
    {
        private double width;
        private double length;

        public double Width { get; set; }
        public double Length { get; set; }
        public Rectangle() { }
        public Rectangle(string color,bool filled,double width,double length)
            : base(color, filled)
        {
            Color = color;
            Filled = filled;
            Width = width;
            Length = length;
        }
        public override double getArea()
        {
            return Width * Length;
        }
        public override double getPerimeter()
        {
            return (Width + Length) * 2;
        }
        public override string toString()
        {
            return "Dien tich hinh chu nhat " + getArea() + "\n"
                + "Chu vi hinh chu nhat " + getPerimeter() + "\n";
        }
    }
}
