using System;


namespace Library5_2

{
       public class Polinom
    {
        private readonly int[] coefficients;

        public Polinom(params int[] coefficients)
        {

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

        public static Polinom operator +(Polinom polinomFirst, Polinom polinomSecond)
        {
            int itemsCount = Math.Max(polinomFirst.coefficients.Length, polinomSecond.coefficients.Length);
            var result = new int[itemsCount];
            for (int i = 0; i < itemsCount; i++)
            {
                int a = 0;
                int b = 0;
                if (i < polinomFirst.coefficients.Length)
                {
                    a = polinomFirst[i];
                }
                if (i < polinomSecond.coefficients.Length)
                {
                    b = polinomSecond[i];
                }
                result[i] = a + b;
            }
            return new Polinom(result);
        }


        public static Polinom operator -(Polinom polinomFirst, Polinom polinomSecond)
        {
            int itemsCount = Math.Max(polinomFirst.coefficients.Length, polinomSecond.coefficients.Length);
            var result = new int[itemsCount];
            for (int i = 0; i < itemsCount; i++)
            {
                int a = 0;
                int b = 0;
                if (i < polinomFirst.coefficients.Length)
                {
                    a = polinomFirst[i];
                }
                if (i < polinomSecond.coefficients.Length)
                {
                    b = polinomSecond[i];
                }
                result[i] = a - b;
            }
            return new Polinom(result);
        }


        public static Polinom operator *(Polinom polinomFirst, Polinom polinomSecond)
        {

            int itemsCount = polinomFirst.coefficients.Length + polinomSecond.coefficients.Length - 1;
            var result = new int[itemsCount];
            for (int i = 0; i < polinomFirst.coefficients.Length; i++)
            {
                for (int j = 0; j < polinomSecond.coefficients.Length; j++)
                {
                    result[i + j] += polinomFirst[i] * polinomSecond[j];
                }
            }

            return new Polinom(result);
        }
    }
}
