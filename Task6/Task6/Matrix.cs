using System;

namespace Task6
{
    class Matrix
    {
        private int[,] arrayMatrix;

        public Matrix(int[,] arrayMatrix)
        {
            this.arrayMatrix = arrayMatrix;
        }

        public int this[int i, int j]
        {
            get
            {
                return arrayMatrix[i, j];
            }
            set
            {
                arrayMatrix[i, j] = value;
            }
        }

        public override string ToString()
        {
            string rez = "";
            for (int i = 0; i < arrayMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < arrayMatrix.GetLength(1); j++)
                {
                    rez += arrayMatrix[i, j] + " ";
                }
            }
            return rez;
        }

        public int ArrLength
        {
            get { return arrayMatrix.GetLength(0); }
        }

        public static Matrix operator +(Matrix first, Matrix second)
        {
            return operate(first, second, "+");
        }

        public static Matrix operator -(Matrix first, Matrix second)
        {
            return operate(first, second, "-");
        }

        private static Matrix operate(Matrix first, Matrix second, String operat)
        {
            CheckArguments(first, second);

            int[,] result = new int[first.ArrLength, second.ArrLength];

            for (int i = 0; i < first.ArrLength; i++)
            {
                for (int j = 0; j < second.ArrLength; j++)
                {
                    if (operat == "-")
                    {
                        result[i, j] = first[i, j] - second[i, j];
                    }
                    else if (operat == "+")
                    {
                        result[i, j] = first[i, j] + second[i, j];
                    }
                }
            }
            return new Matrix(result);
        }

        public static Matrix operator *(Matrix first, Matrix second)
        {
            CheckArguments(first, second);

            int[,] result = new int[first.ArrLength, first.ArrLength];
            for (int i = 0; i < first.ArrLength; i++)
                for (int j = 0; j < second.ArrLength; j++)
                    for (int k = 0; k < second.ArrLength; k++)
                        result[i, j] += first[i, k] * second[k, j];
            return new Matrix(result);
        }

        private static void CheckArguments(Matrix first, Matrix second)
        {
            if (first == null || second == null)
            {
                throw new MatrixNullException("Argument must be not null");
            }

            if (first.ArrLength != second.ArrLength)
            {
                throw new MatrixLengthException("Matrixes must be the same size");
            }
        }
    }
}