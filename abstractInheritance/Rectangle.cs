using System;
using System.Collections.Generic;
using System.Text;

namespace abstractInheritance
{
    class Rectangle:Figure
    {
        public Rectangle(double x, double y,double w,double h) : base(x, y)
        {
            Width = w;
            Height = h;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override double Perimetr()
        {
            return 2 * (Width + Height);
        }
    }
}
