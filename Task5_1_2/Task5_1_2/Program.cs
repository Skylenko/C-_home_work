using System;
using L
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //First task
            var intArray = new ArrayPascal(11, 5);

            Random rand = new Random();
            for (int i = 11; i < 16; i++)
                intArray[i] = rand.Next(100);

            int arrLength = intArray.ArrLength;
            int firstIndex = intArray.BeginIndex;
            int lastIndex = intArray.EndIndex;
            int value = intArray[15];
        }
    }
}
