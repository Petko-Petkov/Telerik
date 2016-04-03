namespace Fibonacci
{
    using System;

    class Fibonacci
    {
        static void Main(string[] args)
        {
            long first = 0;
            long second = 1;
            var count = int.Parse(Console.ReadLine());
            if (count == 1)
            {
                Console.WriteLine("0");
            }
            var counter = 2;
            Console.Write("{0}, {1}", first, second);

            while (count > counter)
            {
                long third = first + second;
                Console.Write(", {0}", third);
                
                first = second;
                second = third;
                third = first;
                counter++;
            }

            Console.WriteLine();
        }
    }
}
