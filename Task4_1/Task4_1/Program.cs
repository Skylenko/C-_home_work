namespace Task4_1
{
    class Square
    {
        static void Main(string[] args)
        {
            int sideLength = 9;
            int perimetr = Perimetr(sideLength);
            int sq = SquareForm(sideLength);
        }

        static int Perimetr (int a)
        {
            return 4 * a;
        }

        static int SquareForm (int a)
        {
            return a * a;
        }
    }
}
