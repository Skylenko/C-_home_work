using System;

namespace Task4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();

            double perimetr = square.Perimetr();
            double sq = square.SquareForm();
        }
    }

    class Square
    {
        private uint a = 0;

        public double Perimetr()
        {
            if (a == 0) return double.NaN;
            return 4 * a;
        }

        public double SquareForm()
        {
            if (a == 0) return double.NaN;
            return Math.Pow(a, 2);
        }
    }
}
