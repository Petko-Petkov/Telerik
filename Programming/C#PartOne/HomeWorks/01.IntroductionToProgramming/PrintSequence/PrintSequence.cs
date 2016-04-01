/*Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...*/

namespace PrintSequence
{
    using System;

    class PrintSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2, j = -3; i < 12; i+=2, j-= 2)
            {
                Console.WriteLine(i);
                Console.WriteLine(j);
            }
        }
    }
}
