namespace BitsToBits
{
    using System;
    using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var matrix = new char[length, 30];
            var longLine = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                var line = int.Parse(Console.ReadLine());
                var currentLine = Convert.ToString(line, 2).PadLeft(30, '0');
                longLine.Append(currentLine);
            }

            var zeroes = GetLongest(longLine, '0');
            var ones = GetLongest(longLine, '1');

            Console.WriteLine(zeroes);
            Console.WriteLine(ones);
            // var longestZeroes = CalculateLongestSequence(length, matrix, '0');
            // var longestOnes = CalculateLongestSequence(length, matrix, '1');

            // Console.WriteLine(longestZeroes);
            // Console.WriteLine(longestOnes);
        }

        private static int GetLongest(StringBuilder longLine, char ch)
        {
            var longest = 0;
            var currentLongest = 1;
            bool match = false;

            for (int i = 0; i < longLine.Length - 1; i++)
            {
                var current = longLine[i];
                var next = longLine[i + 1];

                if (current == ch && next == ch)
                {
                    currentLongest++;
                    match = true;
                }
                else
                {
                    currentLongest = 1;
                }

                if (currentLongest > longest && match)
                {
                    longest = currentLongest;
                }
            }

            return longest;
        }

        //private static int CalculateLongestSequence(int length, char[,] matrix, char ch)
        //{
        //    var currentLength = 1;
        //    var longest = 1;

        //    for (int row = 0; row < length; row++)
        //    {
        //        for (int col = 0; col < 30; col++)
        //        {
        //            var current = matrix[row, col];
        //            var next = col != 29 ? matrix[row, col + 1] :
        //                row != length - 1 ? matrix[row + 1, 0] : ' ';

        //            if (current == ch && next == ch)
        //            {
        //                currentLength++;
        //            }
        //            else
        //            {
        //                currentLength = 1;
        //            }

        //            if (currentLength > longest)
        //            {
        //                longest = currentLength;
        //            }
        //        }
        //    }

        //    return longest;
        //}
    }
}