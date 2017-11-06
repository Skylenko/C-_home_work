using System;

namespace Task4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();

            uint perimetr = square.Perimetr();
            uint sq = square.SquareForm();
        }
    }

    class Square
    {
        uint a = 9;

        public uint Perimetr()
        {
            if (a == 0) return 0;
            return 4 * a;
        }

        public uint SquareForm()
        {
            if (a == 0) return 0;
            return (uint)Math.Pow(a, 2);
        }
    }
}
