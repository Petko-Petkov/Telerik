namespace NumbersToN
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                Console.Write("{0} ", i + 1);
            }

            Console.WriteLine();
        }
    }
}
