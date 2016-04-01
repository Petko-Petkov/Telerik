/*Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …*/

namespace PrintLongSequence
{
    using System;

    class PrintSequence
    {
        static void Main()
        {
            for (int i = 2, j = -3; i < 1002; i+=2, j-=2)
            {
                Console.Write("{0}, {1}, ", i, j);
            }
        }
    }
}
