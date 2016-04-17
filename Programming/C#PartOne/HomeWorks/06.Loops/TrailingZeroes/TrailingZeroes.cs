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
            string str = result.ToString();

            for (int i = str.Length - 1; i > 0; i--)
            {
                if (str[i] != '0')
                {
                    break;
                }

                count += 1;
            }
            
            Console.WriteLine(count);
        }
    }
}
