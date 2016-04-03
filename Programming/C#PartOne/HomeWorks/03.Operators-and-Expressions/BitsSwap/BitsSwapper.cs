/*Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. */

namespace BitsSwap
{
    using System;

    class BitsSwapper
    {
        //Method for setting a bit at given position
        static int SetBits(int inputNumber, int position, int bitValue)
        {
            return bitValue == 0 ? inputNumber & (~(1 << position)) : inputNumber | (1 << position);
        }

        //Method for taking a bit at given position
        static int BitValue(int inputNumber, int position)
        {
            return (((1 << position) & inputNumber) >> position);
        }

        static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());
            var q = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            ////Check for overlapping
            //if (p + k > q)
            //{
            //    Console.WriteLine("Overlapping!");
            //}

            //Calculating the result
            for (int i = 0; i < k; i++)
            {
                var smallerBit = BitValue(input, p + i);
                var higherBit = BitValue(input, q + i);
                input = SetBits(input, p + i, higherBit);
                input = SetBits(input, q + i, smallerBit);
            }

            Console.WriteLine(input);
        }
    }
}
