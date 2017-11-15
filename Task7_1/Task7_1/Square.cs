using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_1
{
     class Square : Fectangle
    {
        double sideFirst = 0;

        public Square(double sideFirst) : base(sideFirst, sideFirst)
        {
            this.sideFirst = sideFirst;
        }

        public override double GetArea()
        {
            return Math.Pow(sideFirst, 2);
        }

        public override string GetName()
        {
            return "Square";
        }
    }
}
