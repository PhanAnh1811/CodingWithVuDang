using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Square:Rectangle
    {
        private double side;
        public double Side { get; set; }
        public Square() { }
        public Square(string color,bool filled, double length,double width,double side)
            : base(color, filled,width,length)
        {
            Color = color;
            Filled = filled;
            Length = length;
            Width = width;
            Side = side;
        }
        public override string toString()
        {
            return "I'm square";
        }
    }
}
