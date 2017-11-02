namespace Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArifmProgres arifm = new ArifmProgres();
            double rez2 = arifm.SumOfFirstN();
        }

        //static double AverageOfFirstN(int a, int d, int n)



    }

    class ArifmProgres
    {
        int a = 3;
        int d = 2;
        int n = 1;

        public double SumOfFirstN()
        {
            //    int current = a;
            //    int sum = 0;
            //    for (int i = current; i <= n; i++)
            //    {
            //        sum += current;
            //        current = current + (n - 1) * d;
            //    }
            //    return sum;
            //}

            double rez = 0;
            int counter = 0;
            int current = a;

            while (counter < n)
            {
                rez += current;
                current = current + (n - 1) * d;
                counter++;
                n--;
            }
            return rez;
        }
    }
}
