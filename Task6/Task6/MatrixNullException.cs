using System;

namespace Task6
{
    class MatrixNullException : Exception
    {
        public MatrixNullException()
        {
        }

        public MatrixNullException(string message)
        : base(message)
        {
        }

        public MatrixNullException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
