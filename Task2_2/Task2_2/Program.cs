using System;

namespace Task2_2
{
    class Program
    {
        public static void Main()
        {
            int[] arr = { 8, 10, 2, 1 };
            SwitchElements(arr);

            int[] arr2 = { 8, 10, 2, 1, 9, 10, 6 };
            IndexesOfMaxElements(arr2);
        }

        public static string SwitchElements(int[] arr)
        {
            for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            return String.Join(" ", arr);
        }

        public static int IndexesOfMaxElements(int[] a)
        {
            int max = a[0];
            int max2 = a[0];
            int index1 = 0;
            int index2 = 0;

            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    index1 = i;
                    break;
                }
            }

            for (int j = a.Length - 1; j >= 0; j--)
            {
                if (a[j] > max2)
                {
                    max2 = a[j];
                    index2 = j;
                    break;
                }
            }
            return index2 - index1;
        }
    }
}