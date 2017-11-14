using System;

namespace Task4_1
{
    class Square
    {
        private uint side;

        public Square (uint side)
        {
            this.side = side;
        }

        public double Perimetr()
        {
            if (side == 0) return double.NaN;
            return 4 * side;
        }

        public double SquareForm()
        {
            if (side == 0) return double.NaN;
            return Math.Pow(side, 2);
        }
    }
}
