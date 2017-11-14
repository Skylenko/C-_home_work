namespace Task4_2
{
    class ArifmeticProgresion
    {
        private int a;
        private int d;
        int n = 3;

        public ArifmeticProgresion(int a, int d)
        {
            this.a = a;
            this.d = d;
        }

        public double SumOfFirstArguments()
        {
            int rez = 0;
            int current = a;

            if (d == 0) return double.NaN;
            if (n == 0) return double.PositiveInfinity;

            for (int i = 1; i <= n; i++)
            {
                current = a + (i - 1) * d;
                rez += current;
            }
            return rez;
        }

        public double AverageOfArifmeticProgress()
        {
            return SumOfFirstArguments() / n;
        }
    }
}

