using System;
using Library5;
using Library5_2;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //first task
            var intarray = new arraypascal(11, 5);

            random rand = new random();
            for (int i = 11; i < 16; i++)
                intarray[i] = rand.next(100);

            int arrlength = intarray.arrlength;
            int firstindex = intarray.beginindex;
            int lastindex = intarray.endindex;
            intarray[15] = 3;
            int value = intarray[15];

            // Second Task
            Polinom p1 = new Polinom(1, 0, 455);
            Polinom p2 = new Polinom(3, 1, 2);

            var pow = p1.PolinomPow; 
            var sumOfPolinoms = p1 + p2;
            var subOfPolinoms = p1 - p2;
            var mulOfPolinoms = p1 * p2;
        }
    }
}

