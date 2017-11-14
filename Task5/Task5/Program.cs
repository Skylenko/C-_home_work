using Library5_2;
using System;

namespace Task5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // First task
            var intArray = new ArrayPascal(11, -8);

            Random rand = new Random();
            for (int i = 11; i < 16; i++)
                intArray[i] = rand.Next(100);

            int arrlength = intArray.ArrLength;
            int firstindex = intArray.BeginIndex;
            int lastindex = intArray.EndIndex;
            intArray[15] = 3;
            int value = intArray[15];

            // Second Task
            Polinom p1 = null;
            Polinom p2 = new Polinom(3, 1, 2);

            var pow = p1.PolinomPow;
            var sumOfPolinoms = p1 + p2;
            var subOfPolinoms = p1 - p2;
            var mulOfPolinoms = p1 * p2;
        }
    }
}
