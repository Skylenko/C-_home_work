using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_1
{
    class Fectangle : Shape
    {
        double firstSide;
        double secondSide;

        public Fectangle(double firstSide, double secondSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
        }

        public override double GetArea()
        {
            return firstSide * secondSide;
        }

        public override string GetName()
        {
            return "Fectangle";
        }

    }
}

