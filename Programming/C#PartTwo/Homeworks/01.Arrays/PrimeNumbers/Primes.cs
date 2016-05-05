namespace PrimeNumbers
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    class Primes
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var arr = new BitArray(input + 1);
            arr.SetAll(true);
            var highestPrime = GeneratePrimes(arr, input);
            Console.WriteLine(highestPrime);
        }

        private static int GeneratePrimes(BitArray arr, int input)
        {
            int current = 2;

            while (current * current <= input)
            {
                int mark = current + current;

                while (mark <= input)
                {
                    arr[mark] = false;
                    mark += current;
                }

                current++;
                while (!arr[current]) 
                {
                    current++;
                }
            }

            var count = 1;

            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i])
                {
                    count = i;
                    break;
                }
            }

            return count;
        }
    }
}
