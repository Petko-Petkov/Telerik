/* Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20) and prints a matrix 
 * holding the numbers from 1 to N*N in the form of square spiral like in the examples below.*/

namespace SpiralMatrix
{
    using System;

    public class SpiralMatrix
    {
        public static void Main()
        {
            var side = int.Parse(Console.ReadLine());
            int[,] matrix = new int[side, side];
            int switcher = side - 1;
            int counter = 1;

            int row = 0;
            int col = 0;

            while (switcher > 0)
            {
                for (int x = row; x < switcher + row; x++)
                {
                    matrix[row, x] = counter++;
                }

                for (int y = row; y < switcher + row; y++)
                {
                    matrix[y, row + switcher] = counter++;
                }

                for (int bottomRow = side - 1 - row; bottomRow > col; bottomRow--)
                {
                    matrix[switcher + row, bottomRow] = counter++;
                }

                for (int l = switcher + row ; l > row; l--)
                {
                    matrix[l, col] = counter++;
                }

                row += 1;
                col += 1;
                switcher -= 2;
            }

            for (int i = 0; i< side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        matrix[i, j] = side * side;
                    }
                    Console.Write("{0}", matrix[i, j]);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }    
    }
}
