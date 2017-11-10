using System;

using System.Linq;

namespace LibraryForTask5
{
    public static class Program
    {
        private static void Main()
        {
            Polinom polinom = new Polinom();
            Polinom p1 = new Polinom(0, 0, 0);
            Polinom p2 = new Polinom(3, 1, 2);
            Console.WriteLine(p1);
          //  Console.WriteLine(p1 + p2);
            Console.WriteLine();
            var i = p1.PolinomPow;

            Console.ReadKey();
        }
    }
    public class Polinom
    {
        private readonly int[] coefficients;

        public Polinom(params int[] coefficients)
        {
            for (int i = coefficients.Length - 1; i > 0; i--)
            {
                if (coefficients[i] == 0)
                {
                    //int[] query = coefficients.Where(n => coefficients.ElementAt(i) != n);
                    //this.coefficients = query[];
                    coefficients.Skip(coefficients[i]);
                }
                this.coefficients;
            }

            this.coefficients = coefficients;
        }

        public int this[int index]
        {
            get { return coefficients[index]; }
            set { coefficients[index] = value; }
        }

        public double PolinomPow
        {

            get
            {
                bool allzero = true;
                for (int i = 0; i < coefficients.Length; i++)
                {
                    if (coefficients[i] == 0)
                    {
                        allzero &= true;
                    }
                    else
                    {
                        allzero &= false;
                    }

                }

                if (allzero) return double.NegativeInfinity;
                return coefficients.Length - 1;
            }
        }


        public override string ToString()
        {
            string polinomToString = "";

            for (int i = coefficients.Length - 1; i >= 0; i--)
            {
                polinomToString += getPart(coefficients[i], i);
            }

            if (polinomToString.StartsWith("+")) polinomToString = polinomToString.Substring(1, polinomToString.Length - 1);

            return polinomToString;
        }

        private string getPart(int coeff, int pow)
        {
            string result = "";
            if (coeff == 0) return result;

            if (coeff < 0) result += "-";
            else result += "+";
            if (Math.Abs(coeff) != 1) result += Math.Abs(coeff);
            if (pow == 1) result += "x";
            else if (pow != 0) result += "x^" + pow;
            if (pow == 0 && Math.Abs(coeff) == 1) result += Math.Abs(coeff);

            return result;
        }
    }
}
