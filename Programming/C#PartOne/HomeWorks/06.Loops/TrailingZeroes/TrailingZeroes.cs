/*Write a program that calculates with how many zeroes the factorial of a given number N has at its end.*/

namespace TrailingZeroes
{
    using System;
    using System.Numerics;

    class TrailingZeroes
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = input; i > 0; i--)
            {
                result *= i;
            }

            int count = 0;

            while (true)
            {
                var lastNum = result % 10;

                if (lastNum != 0)
                {
                    break;
                }

                count++;
                result /= 10;
            }

            Console.WriteLine(count);
        }
    }
}
