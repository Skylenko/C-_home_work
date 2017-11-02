using System;
using System.Linq;

namespace Task3_1
{
    class Program
    {
        enum SortOrder
        {
            ASCENDING, DESCENDING
        }

        static void Main(string[] args)
        {
            int[] array = { 2, 5, 4, 87, 5, 12, 89, 34, 67 };

            int[] arr = SortArray(array, SortOrder.DESCENDING);
            string res = String.Join(" ", arr);

            IsSorted(array, SortOrder.DESCENDING);
        }

        static int[] SortArray(int[] arr, SortOrder sortOrder)
        {
            int[] arrCopy = arr.ToArray();
            int temp;

            for (int i = 0; i < arrCopy.Length; i++)
            {
                for (int j = 0; j < arrCopy.Length - i - 1; j++)
                {
                    if ((sortOrder == SortOrder.ASCENDING) && (arrCopy[j] > arrCopy[j + 1]) ||
                        (sortOrder == SortOrder.DESCENDING) && (arrCopy[j] < arrCopy[j + 1]))
                    {
                        temp = arrCopy[j];
                        arrCopy[j] = arrCopy[j + 1];
                        arrCopy[j + 1] = temp;
                    }
                }
            }
            return arrCopy;
        }

        static bool IsSorted(int[] arr, SortOrder sortOrder)
        {
            int[] sorted = SortArray(arr, sortOrder);
            return arr.SequenceEqual(sorted);
        }
    }
}

