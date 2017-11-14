using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPrj3
{
    public class Arithmetic
    {
        public static int Add(int value1, int value2)
        {
            return value1 + value2;
        }
        public static int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }
        public static int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }
        public static double Divide(int value1, int value2)
        {
            return (double)value1 / value2;
        }
    }
}
