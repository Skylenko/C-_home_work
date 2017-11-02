namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr =  {
                {2, 4, 3, 3},
                {5, 7, 8, 5},
                {2, 4, 3, 3},
                {5, 7, 8, 5}
            };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i != j)
                    {
                        if (i > j)
                        {
                            arr[i, j] = 0;
                        }
                        else
                        {
                            arr[i, j] = 1;
                        }
                    }
                }
            }
        }
    }
}