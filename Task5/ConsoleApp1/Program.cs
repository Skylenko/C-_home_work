using LibraryForTask5;
using System;

namespace Task5
{
    class Program
    {
        static void Main()
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
