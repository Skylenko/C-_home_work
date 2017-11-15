using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_1
{
    class Circle : Shape
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }

        public override string GetName()
        {
            return "Circle";
        }

    }
}

