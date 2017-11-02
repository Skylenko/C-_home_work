namespace Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArifmProgres arifm = new ArifmProgres();
            int rez = arifm.SumOfFirstN();
            double rez2 = arifm.AverageOfArifmeticProgres();
        }
    }

    class ArifmProgres
    {
        int a = 1;
        int d = 2;
        int n = 3;

        public int SumOfFirstN()
        {
            int rez = 0;

            int current = a;

            for (int i = 1; i <= n; i++)
            {
                current = a + (i - 1) * d;
                rez += current;
            }
            return rez;
        }

        public double AverageOfArifmeticProgres()
        {
            return SumOfFirstN() / n;
        }
    }
}
