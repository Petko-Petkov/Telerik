using System;
using System.Numerics;

namespace CatalanNumbers
{
    class Program
    {
        static BigInteger Factorial(int factor)
        {
            BigInteger result = 1;
            for (int i = 1; i <= factor; i++)
            {
                result = result * i;
            }
            return result;
        }

        static BigInteger DivideFactorials(int factorial1, int factorial2)
        {
            BigInteger result = 1;
            for (int i = factorial2 + 1; i <= factorial1; i++)
            {
                result = result * i;
            }
            return result;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = DivideFactorials((2 * n), (n + 1)) / Factorial(n);
            Console.WriteLine(result);
        }
    }
}
