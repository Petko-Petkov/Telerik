namespace HelpDoge
{
    using System;
    using System.Linq;
    using System.Numerics;

    class Program
    {
        private static BigInteger[,] matrix;
        private static int fx, fy;
        static void Main(string[] args)
        {
            ReadInput();
            CalculatePaths();
            Console.WriteLine(matrix[fx, fy]);
        }

        private static void CalculatePaths()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == 0 && col == 0)
                    {
                        matrix[row, col] = 1;
                        continue;
                    }

                    if (matrix[row, col] == -1)
                    {
                        matrix[row, col] = 0;
                        continue;
                    }

                    if (row == 0)
                    {
                        matrix[row, col] = matrix[row, col - 1];
                        continue;
                    }

                    if (col == 0)
                    {
                        matrix[row, col] = matrix[row - 1, col];
                        continue;
                    }

                    matrix[row, col] = matrix[row - 1, col] + matrix[row, col - 1];
                }
            }
        }

        private static void ReadInput()
        {
            var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToInt32(s)).ToArray();
            matrix = new BigInteger[line[0], line[1]];
            line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToInt32(s)).ToArray();
            fx = line[0];
            fy = line[1];

            var length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => Convert.ToInt32(s)).ToArray();

                matrix[line[0], line[1]] = -1;
            }
        }
    }
}
