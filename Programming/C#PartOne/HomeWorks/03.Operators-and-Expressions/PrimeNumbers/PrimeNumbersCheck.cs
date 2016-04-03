/*Write an expression that checks if given positive integer number n (n ≤ 100) is prime 
 * (i.e. it is divisible without remainder only to itself and 1). */

namespace PrimeNumbers
{
    using System;

    class PrimeNumbersCheck
    {
        static void Main()
        {
            //Taking an integer from the user
            var input = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (input <= 1)
            {
                Console.WriteLine("false");
                return;
            }

            //Cheking for each ot its divisors if it is divided with remainder
            for (int i = 2; i < input; i++)
            {
                if ((input % i) == 0)
                {
                    isPrime = false;
                }
            }

            if (isPrime || input == 2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}