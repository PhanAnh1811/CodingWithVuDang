using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    abstract class Shape
    {
        protected string color;
        protected bool filled;

        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }

        public Shape() { }
        public Shape(string color,bool filled)
        {
            Color = color;
            Filled = filled;
        }
        public bool isFilled()
        {
            if (filled) return true;
            return false;
        }
        public bool setFilled()
        {
            if (!isFilled()) return true;
            return false;
        }
        public abstract double getArea();
        public abstract double getPerimeter();
        public abstract string toString();
    }
}
