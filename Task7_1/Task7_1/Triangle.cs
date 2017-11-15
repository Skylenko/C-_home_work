using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_1
{
    class Triangle : Shape
    {
        double side, height;

        public Triangle(double side, double height)
        {
            this.side = side;
            this.height = height;
        }

        public override double GetArea()
        {
            return 0.5 * side * height; ;
        }

        public override string GetName()
        {
            return "Triangle";
        }
    }
}
