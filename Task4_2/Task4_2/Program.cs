namespace Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArifmeticProgress arifm = new ArifmeticProgress();
            int rez = arifm.SumOfFirstArguments();
            double rez2 = arifm.AverageOfArifmeticProgress();
        }
    }

    class ArifmeticProgress
    {
        int a = 1;
        int d = 2;
        int n = 3;

        public int SumOfFirstArguments()
        {
            int rez = 0;
            int current = a;

            if (d == 0) return 0;

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