namespace Patterns
{
    using System;
    using System.Linq;

    class Program
    {
        private static int[,] matrix;
        private static int length;
        private static int maxSum = int.MinValue;

        static void Main(string[] args)
        {
            ReadInput();
            CheckPattern();
            WriteOutput(); 
        }

        private static void WriteOutput()
        {
            if (maxSum != int.MinValue)
            {
                Console.WriteLine("YES {0}", maxSum);
            }
            else
            {
                Console.WriteLine("NO {0}", GetDiagonalSum());
            }
        }

        private static int GetDiagonalSum()
        {
            var sum = 0;

            for (int row = 0; row < length; row++)
            {
               sum += matrix[row, row];     
            }

            return sum;
        }

        private static void CheckPattern()
        {
            for (int row = 0; row < length - 2; row++)
            {
                for (int col = 0; col < length - 4; col++)
                {
                    var currentSum = 0;
                    var a = matrix[row, col];
                    var b = matrix[row, col + 1];
                    var c = matrix[row, col + 2];
                    var d = matrix[row + 1, col + 2];
                    var e = matrix[row + 2, col + 2];
                    var f = matrix[row + 2, col + 3];
                    var g = matrix[row + 2, col + 4];

                    if (a + 1 == b && b + 1 == c && c + 1 == d && d + 1 == e && e + 1 == f && f + 1 == g)
                    {
                        currentSum = a + b + c + d + e + f + g;

                        if (currentSum > maxSum)
                        {
                            maxSum = currentSum;
                        }
                    }
                }
            }
        }

        private static void ReadInput()
        {
            length = int.Parse(Console.ReadLine());
            matrix = new int[length, length];

            for (int row = 0; row < length; row++)
            {
                var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

                for (int col = 0; col < length; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
        }
    }
}
