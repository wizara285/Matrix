using System;


namespace Matrix
{
    public class MatrixException : Exception
    {
        public int Row { get; }
        public int Column { get; }

        public override string Message
        {
            get
            {
                return "Invalid Matrix operation";
            }
        }

        public MatrixException(int row, int column)
        {
            Row = row;
            Column = column;
        }
        public MatrixException() { }
        public MatrixException(string message) : base(message) { }
    }
}
