using System;

namespace Matrix
{
    public class Matrix
    {
        // An array of floating-point values that represents the elements of this Matrix.
        public double[,] Array { get; }

        //Number of rows.
        public int Rows
        {
            get
            {
                return Array.GetLength(0);
            }

        }

        //Number of columns.
        public int Columns
        {
            get
            {
                return Array.GetLength(1);
            }
        }


        public Matrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
                throw new ArgumentOutOfRangeException();
            else Array = new double[rows, columns];
        }

        public Matrix(double[,] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            else Array = array;
        }


        //Allows instances of a Matrix to be indexed just like arrays
        public double this[int row, int column]
        {
            get
            {
                if (row < 0 || row >= Rows || column < 0 || column >= Columns)
                    throw new ArgumentException();
                else return Array[row, column];
            }
            set
            {
                if (row < 0 || row >= Rows || column < 0 || column >= Columns)
                    throw new ArgumentException();
                else Array[row, column] = value;
            }
        }


        public Matrix Add(Matrix matrix)
        {
            if (matrix != null)
            {
                if (Rows == matrix.Rows && Columns == matrix.Columns)
                {
                    for (int i = 0; i < matrix.Rows; i++)
                    {
                        for (int j = 0; j < matrix.Columns; j++)
                        {
                            matrix[i, j] += Array[i, j];
                        }
                    }
                    return matrix;
                }
                else
                {
                    throw new MatrixException();
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public Matrix Subtract(Matrix matrix)
        {
            if (matrix != null)
            {
                if (Rows == matrix.Rows && Columns == matrix.Columns)
                {
                    Matrix result = new Matrix(matrix.Rows, matrix.Columns);
                    for (int i = 0; i < matrix.Rows; i++)
                    {
                        for (int j = 0; j < matrix.Columns; j++)
                        {
                            result[i, j] = Array[i, j] - matrix[i, j];
                        }
                    }
                    return result;
                }
                else
                {
                    throw new MatrixException();
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public Matrix Multiply(Matrix matrix)
        {
            if (matrix != null)
            {
                if (Columns == matrix.Rows)
                {
                    Matrix result = new Matrix(Rows, matrix.Columns);
                    for (int i = 0; i < Rows; i++)
                    {
                        for (int j = 0; j < matrix.Columns; j++)
                        {
                            for (int k = 0; k < Columns; k++)
                            {
                                result[i, j] += Array[i, k] * matrix[k, j];
                            }
                        }
                    }
                    return result;
                }
                else
                {
                    throw new MatrixException();
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public double SumOfNumbers()
        {
            double sumOfNumbers = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    sumOfNumbers += Array[i, j];
                }
            }
            return sumOfNumbers;
        }

    }
}
