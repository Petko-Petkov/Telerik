namespace SaddyKopper
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    class Program
    {
        private static List<BigInteger> foundSum = new List<BigInteger>();
        static void Main(string[] args)
        {
            var inputNumber = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                while (inputNumber.Length > 1)
                {
                    inputNumber = RemoveLastDigit(inputNumber);
                    FindDigitAtEvenPosition(inputNumber);
                }

                inputNumber = ProductOfSums();
                if (inputNumber.Length == 1)
                {
                    Console.WriteLine(i+1);
                    Console.WriteLine(inputNumber);
                    return;
                }

                foundSum.Clear();
            }

            Console.WriteLine(inputNumber);
        }

        private static string ProductOfSums()
        {
            BigInteger output = 1;

            foreach (var sum in foundSum)
            {
                output *= sum;
            }

            return output.ToString();
        }

        private static string RemoveLastDigit(string inputNumber)
        {
            if (inputNumber.Length > 1)
            {
                return inputNumber.Substring(0, inputNumber.Length - 1);
            }

            return "";
        }

        private static void FindDigitAtEvenPosition(string inputNumber)
        {
            int result = 0;

            for (int i = 0; i < inputNumber.Length; i += 2)
            {
                result += int.Parse(inputNumber[i].ToString()); 
            }

            foundSum.Add(result);
        }
    }
}
