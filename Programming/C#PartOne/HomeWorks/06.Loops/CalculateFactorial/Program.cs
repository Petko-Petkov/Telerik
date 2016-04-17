namespace CalculateFactorial
{
    using System;
    using System.Numerics;
    class Program
    {
        static void Main(string[] args)
        {
            var n = BigInteger.Parse(Console.ReadLine());
            
            var k = int.Parse(Console.ReadLine());

            for (int i = (int)n - 1; i > k; i--)
            {
                n *= i;
            }

            Console.WriteLine(n);
        }
    }
}
