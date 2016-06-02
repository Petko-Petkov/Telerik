namespace NFactorial
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    class Factorial
    {
        static void Main(string[] args)
        {
            ReadInput();
        }

        private static void ReadInput()
        {
            var number = int.Parse(Console.ReadLine());

            var arr = Enumerable.Range(1, number);

            GenerateOutpu(arr);
        }

        private static void GenerateOutpu(IEnumerable<int> arr)
        {
            BigInteger result = 1;

            foreach (var item in arr)
            {
                result *= item;
            }

            Console.WriteLine(result);
        }
    }
}
