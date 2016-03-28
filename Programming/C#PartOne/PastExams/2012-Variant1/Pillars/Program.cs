using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Program
    {
        private static char[,] matrix = new char[8, 8];
        private static int bitCounter = 0;
        static void Main(string[] args)
        {
            ReadInput();
            var tempCounter = 0;
            
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                var currentColCounter = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (matrix[row, col] == '1')
                    {
                        currentColCounter++;
                    }
                }
                
                if ((bitCounter - currentColCounter) / 2 == tempCounter && (bitCounter - currentColCounter) % 2 == 0)
                {
                    Console.WriteLine(matrix.GetLength(0) - 1 - col);
                    Console.WriteLine(tempCounter);
                    return;
                }

                tempCounter += currentColCounter;
            }

            Console.WriteLine("No");
        }

        private static void ReadInput()
        {
            for (int row = 0; row < 8; row++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                var str = Convert.ToString(currentNumber, 2).PadLeft(8, '0');
                for (int col = 0; col < 8; col++)
                {
                    matrix[row, col] = str[col];
                    if (str[col] == '1')
                    {
                        bitCounter++;
                    }
                }
            }
        }
    }
}
