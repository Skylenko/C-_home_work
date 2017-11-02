using System;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int m = 6;
            AverageNum(n, m);

            int n1 = 5;
            int n2 = 10;
            SumOfСountNumbers(n1);

            SumOfСountNumsSecond(n1, n2);
        }

        public static double AverageNum(int a, int b)
        {
            double rez = 0;

            for (double i = a; i <= b; i++)
            {
                rez += i;
            }
            return rez / (b - a);
        }

        public static int SumOfСountNumbers(int a)
        {
            int rez = 0;
            for (int i = 0; i <= a; i += 2)
            {
                rez += i;
            }
            return rez;
        }

        public static int SumOfСountNumsSecond(int a, int b)
        {
            int rez = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    rez += i;
                }
            }
            return rez;
        }
    }
}