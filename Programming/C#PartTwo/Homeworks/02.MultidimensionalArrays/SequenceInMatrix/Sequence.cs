namespace SequenceInMatrix
{
    using System;

    class Sequence
    {
        private static int modRow = 0;
        private static int modCol = 0;

        static void Main(string[] args)
        {
            var matrix = FillMatrix();
            var sequenceLength = CalculateSequence(matrix);
            Console.WriteLine(sequenceLength);
        }

        private static int CalculateSequence(int[,] matrix)
        {
            int maxDirection = 0;
            int maxRow = 0;
            int maxCol = 0;
            int maxElements = 0;
            int tempElements = 0;
            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        tempElements = Check(matrix, row, col, k);
                        if (tempElements > maxElements)
                        {
                            maxElements = tempElements;
                            maxRow = row;
                            maxCol = col;
                            maxDirection = k;
                        }
                    }
                }
            }

            return maxElements;
        }

        private static int Check(int[,] matrix, int row, int col, int direction)
        {
            int max = 1;
            Direction(direction);
            while (row + modRow >= 0 && col + modCol >= 0 &&
                    row + modRow < matrix.GetLength(0) && col + modCol < matrix.GetLength(1))
            {
                if (matrix[row, col] == matrix[row + modRow, col + modCol])
                {
                    max++;
                    row = modRow + row;
                    col = modCol + col;
                }
                else
                {
                    return max;
                }
            }

            return max;
        }

        private static void Direction(int direction)
        {
            if (direction == 1)
            {
                modRow = -1;
                modCol = 1;
            }
            else if (direction == 2)
            {
                modRow = 0;
                modCol = 1;
            }
            else if (direction == 3)
            {
                modRow = 1;
                modCol = 1;
            }
            else if (direction == 4)
            {
                modRow = 1;
                modCol = 0;
            }
        }

        private static int[,] FillMatrix()
        {
            var dimensions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var rows = int.Parse(dimensions[0]);
            var cols = int.Parse(dimensions[1]);
            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(line[col]);
                }
            }

            return matrix;
        }
    }
}
