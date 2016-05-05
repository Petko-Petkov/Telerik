namespace FillTheMatrix
{
    using System;
    using System.Text;
    class MatrixFiller
    {
        static void Main(string[] args)
        {
            ReadInput();
        }

        private static void ReadInput()
        {
            int length = int.Parse(Console.ReadLine());
            char c = (char)Console.Read();
            FillMatrix(length, c);
        }

        private static int[,] FillMatrix(int length, char ch)
        {
            var matrix = new int[length, length];
            var counter = 0;

            switch (ch)
            {
                case 'a':
                    for (int row = 0; row < length; row++)
                    {
                        for (int col = 0; col < length; col++)
                        {
                            matrix[col, row] = ++counter;
                        }
                    }
                    break;
                case 'b':
                    for (int row = 0; row < length; row++)
                    {
                        if (row % 2 == 0)
                        {
                            for (int col = 0; col < length; col++)
                            {
                                matrix[col, row] = ++counter;
                            }
                        }
                        else
                        {
                            for (int col = length - 1; col >= 0; col--)
                            {
                                matrix[col, row] = ++counter;
                            }
                        }
                    }
                    break;
                case 'c':
                    int r = length - 1;
                    int c = 0;
                    int mod = 1;

                    for (int i = 0; i < length * length; i++)
                    {
                        if (r == length && c < length)
                        {
                            mod++;
                            r = length - mod;
                            c = 0;
                        }
                        else if (c == length && c <= length)
                        {
                            mod--;
                            r = 0;
                            c = length - mod;
                        }

                        matrix[r, c] = i + 1;
                        r++;
                        c++;
                    }
                    break;
                case 'd':
                    matrix = DrawSpiralMatrix(matrix, length);
                    break;
                default:
                    break;
            }

            for (int row = 0; row < length; row++)
            {
                var str = new StringBuilder();

                for (int col = 0; col < length; col++)
                {
                    if (matrix[row, col] != 0)
                    {
                        str.Append(matrix[row, col]);
                    }
                    else
                    {
                        str.Append(length * length);
                    }
                    str.Append(' ');
                }

                Console.WriteLine(str.ToString().Trim());
            }

            return matrix;
        }

        private static int[,] DrawSpiralMatrix(int[,] matrix, int side)
        {
            int switcher = side - 1;
            int counter = 1;

            int row = 0;
            int col = 0;

            while (switcher > 0)
            {
                for (int x = row; x < switcher + row; x++)
                {
                    matrix[x, row] = counter++;
                }

                for (int y = row; y < switcher + row; y++)
                {
                    matrix[row + switcher, y] = counter++;
                }

                for (int bottomRow = side - 1 - row; bottomRow > col; bottomRow--)
                {
                    matrix[bottomRow, switcher + row] = counter++;
                }

                for (int l = switcher + row; l > row; l--)
                {
                    matrix[col, l] = counter++;
                }

                row += 1;
                col += 1;
                switcher -= 2;
            }

            return matrix;
        }
    }
}
