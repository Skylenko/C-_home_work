using System;

namespace Library5_2
{
    public class ArrayPascal
    {
        private int[] array;

        private int indexDelta;

        public ArrayPascal(int beginIndex, int arrayLength)
        {
            if (arrayLength <= 0)
            {
                throw new ArgumentOutOfRangeException("Argument must be not 0 or < 0");
            }
            indexDelta = beginIndex;
            array = new int[arrayLength];
        }

        public int this[int index]
        {
            get
            {
                return array[index - indexDelta];
            }
            set
            {
                array[index - indexDelta] = value;
            }
        }

        public int ArrLength
        {
            get { return array.Length; }
        }

        public int BeginIndex
        {
            get { return indexDelta; }
        }

        public int EndIndex
        {
            get { return indexDelta + array.Length - 1; }
        }
    }
}