namespace Task3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int t = 2;
            int n = 5;


            int arifmProgres = ComposOfArithmProgresRecurs(a, t, n);
            
            double alim = 1;
            double geometrProgres = ComposOfGeomProgresRecurs(a, t, alim);
        }

        static int ComposOfArithmProgresRecurs(int a, int t, int n)
        {
            if (n == 0) return 0;
            if (n == 1) return a;

            return ComposOfArithmProgresRecurs((a + t), t, n - 1) * a;
        }

        static double ComposOfGeomProgresRecurs(double a, double t, double alim)
        {
            if (a <= alim) return 1;
            if (t == 0) return 0;

            return ComposOfGeomProgresRecurs((a / t), t, alim) * a;
        }
    }
}
