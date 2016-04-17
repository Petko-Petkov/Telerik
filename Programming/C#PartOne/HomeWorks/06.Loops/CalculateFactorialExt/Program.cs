namespace CalculateFactorialExt
{
    using System;
    using System.Numerics;


    class Program
    {
        static void Main()
        {
            var inputN = int.Parse(Console.ReadLine());
            var inputK = int.Parse(Console.ReadLine());
            
            var divisor = CalculateFactorial(inputN);
            var diff = CalculateFactorial(inputN - inputK);            

            Console.WriteLine(divisor / (CalculateFactorial(inputK) * (diff)));
        }

        private static BigInteger CalculateFactorial(int input)
        {
            BigInteger output = 1;

            for (int i = input; i > 0; i--)
            {
                output *= i;
            }

            return output;
        }
    }
}
