using System;
using LibPrj3;

namespace ConsolePrj2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 6;
            Console.WriteLine(Arithmetic.Add(a, b));
            Console.WriteLine(Arithmetic.Subtract(a, b));
            Console.WriteLine(Arithmetic.Multiply(a, b));
            Console.WriteLine(Arithmetic.Divide(a, b));
        }
    }
}
