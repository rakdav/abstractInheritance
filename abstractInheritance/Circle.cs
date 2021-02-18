using System;
using System.Collections.Generic;
using System.Text;

namespace abstractInheritance
{
    class Circle:Figure
    {
        public Circle(double x, double y,double R) : base(x, y)
        {
            Radius = R;
        }

        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI*Radius*Radius;
        }

        public override double Perimetr()
        {
            return 2*Math.PI*Radius;
        }
    }
}
