/*Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. */

namespace BitsExchange
{
    using System;

    class BitsExchanger
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
            //Taking input data from user
            var input = int.Parse(Console.ReadLine());

            //Calculating the result
            for (int i = 0; i < 3; i++)
            {
                var smallerBit = BitValue(input, 3 + i);
                var higherBit = BitValue(input, 24 + i);
                input = SetBits(input, 3 + i, higherBit);
                input = SetBits(input, 24 + i, smallerBit);
            }

            Console.WriteLine(input);
        }
    }
}
