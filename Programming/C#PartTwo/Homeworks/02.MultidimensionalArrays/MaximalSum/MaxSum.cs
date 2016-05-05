namespace MaximalSum
{
    using System;

    class MaxSum
    {
        static void Main(string[] args)
        {
            var matrix = FillMatrix();
            var sum = CalculateSum(matrix);
            Console.WriteLine(sum);
        }

        private static int CalculateSum(short[,] matrix)
        {
            var maxSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    var currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col]
                        + matrix[row, col + 1] + matrix[row + 1, col + 1] + matrix[row + 2, col + 1]
                        + matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }

            return maxSum;
        }

        private static short[,] FillMatrix()
        {
            var dimensions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var rows = int.Parse(dimensions[0]);
            var cols = int.Parse(dimensions[1]);
            var matrix = new short[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = short.Parse(line[col]);
                }
            }

            return matrix;
        }
    }
}
