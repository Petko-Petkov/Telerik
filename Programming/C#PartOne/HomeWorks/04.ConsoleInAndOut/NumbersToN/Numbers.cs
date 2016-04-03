namespace NumbersToN
{
    using System;

    class Numbers
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
