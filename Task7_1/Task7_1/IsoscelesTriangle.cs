using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_1
{
    class IsoscelesTriangle : Triangle
    {
        double side;
        double height;

        public IsoscelesTriangle(double side, double height) : base (side, height)
        {
            this.height = height;
            this.side = side;
        }

        public override string GetName()
        {
            return "IsoscelesTriangle";
        }
    }
}
