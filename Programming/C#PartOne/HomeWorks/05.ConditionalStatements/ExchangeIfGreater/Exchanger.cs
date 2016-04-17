namespace ExchangeIfGreater
{
    using System;

    class Exchanger
    {
        static void Main(string[] args)
        {
            var first = double.Parse(Console.ReadLine());
            var second = double.Parse(Console.ReadLine());

            if (first < second)
            {
                Console.WriteLine("{0} {1}", first, second);
            }
            else
            {
                Console.WriteLine("{0} {1}", second, first);
            }
        }
    }
}
