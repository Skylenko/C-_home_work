namespace Task4_2
{
    class ArifmProgres
    {
        static void Main(string[] args)
        {
            int a = 1;
            int d = 2;
            int n = 3;

           // double rez = AverageOfFirstN(a, d, n);

            int rez2 = SumOfFirstN(a, d, n);
        }

        //static double AverageOfFirstN(int a, int d, int n)
        //{
        //    double rez = 0;
        //    int counter = 0;
        //    int current = a;

        //    while (counter < n)
        //    {
        //        rez += current;
        //        current = current + (n - 1) * d;
        //        n--;
        //        counter++;
        //    }
        //    return rez / n;
        //}

        static int SumOfFirstN(int a, int d, int n)
        {
            int rez2 = 0;
            int counter = 0;
            int current = a;

            while (counter < n)
            {
                rez2 += current;
                current = current + (n - 1) * d;
                n--;
                counter++;
            }
            return rez2;
        }
    }
}
