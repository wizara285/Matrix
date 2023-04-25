namespace Matrix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[,] array2D = new double[,] { { 1, -2 },
                                                { 3, 4 } };


            Matrix matrix_1 = new Matrix(array2D);

            Matrix matrix_2 = new Matrix(new double[,] { { 3, 9 },
                                                         { 0, -2 } });


            // using 'Add' function and recording the resulting matrix
            var AddingMatrix = matrix_1.Add(matrix_2);

            // using 'Subtract' function and recording the resulting matrix
            var SubstractingMatrix = matrix_1.Subtract(matrix_2);

            // using 'Multiply' function and recording the resulting matrix
            var MultiplyingMatrix = matrix_1.Multiply(matrix_2);



            // output result of adding matrix
            for (int i = 0; i < AddingMatrix.Rows; i++)
            {
                for (int j = 0; j < AddingMatrix.Columns; j++)
                {
                    Console.Write(AddingMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // output result of substructing matrix
            for (int i = 0; i < SubstractingMatrix.Rows; i++)
            {
                for (int j = 0; j < SubstractingMatrix.Columns; j++)
                {
                    Console.Write(SubstractingMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // output result of multiplying matrix
            for (int i = 0; i < MultiplyingMatrix.Rows; i++)
            {
                for (int j = 0; j < MultiplyingMatrix.Columns; j++)
                {
                    Console.Write(MultiplyingMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}