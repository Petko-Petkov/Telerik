using System;

namespace WeAllLoveBits
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLength = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLength; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                var output = 0;

                while (currentNumber != 0)
                {
                    output <<= 1;
                    output += currentNumber & 1;
                    currentNumber >>= 1;
                }

                Console.WriteLine(output);
            }
        }
    }
}
