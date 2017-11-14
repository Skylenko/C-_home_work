using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstMatrix = {
                {44, 6, 43},
                {76, 34, 4},
                {90, 4, 76},
       };

            int[,] secondMatrix = {
                {6, 18, 3},
                {5, 7, 89},
                {9, 35, 3},
       };

            Matrix matrixFirst = null;
            Matrix matrixSecond = new Matrix(secondMatrix);

            try
            {
                var sumOfmatrix = matrixFirst + matrixSecond;
                var subOfmatrix = matrixFirst - matrixSecond;
                var mulOfmatrix = matrixFirst * matrixSecond;
            }
            catch (MatrixNullException e)
            {
                throw new ArgumentException("Argument must be not null", e.Message);
            }
            catch (MatrixLengthException e)
            {
                throw new ArgumentException("Matrixes must be the same size", e);

            }
        }
    }
}