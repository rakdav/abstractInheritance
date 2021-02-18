using System;
using System.Collections.Generic;
using System.Text;

namespace abstractInheritance
{
    abstract class Figure
    {
        public double X { get; set; }
        public double Y { get; set; }
        protected Figure(double x, double y)
        {
            X = x;
            Y = y;
        }
        public abstract double Area();
        public abstract double Perimetr();
    }
}
