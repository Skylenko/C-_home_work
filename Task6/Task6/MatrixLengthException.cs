using System;

namespace Task6
{
    class MatrixLengthException : Exception
    {

        public MatrixLengthException()
        {
        }

        public MatrixLengthException(string message)
        : base(message)
        {
        }

        public MatrixLengthException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
