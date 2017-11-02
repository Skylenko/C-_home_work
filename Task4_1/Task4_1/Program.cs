namespace Task4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();

            int perimetr = square.Perimetr();
            int sq = square.SquareForm();
        }
    }

    class Square
    {
        int a = 9;
        public int Perimetr()
        {
            return 4 * a;
        }

        public int SquareForm()
        {
            return a * a;
        }
    }
}
