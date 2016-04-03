namespace Interval
{
    using System;

    class Interval
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            first = Math.Min(first, second);
            second = Math.Max(first, second);
            var result = 0;

            for (int i = first + 1; i < second; i++)
            {
                if (i % 5 == 0)
                {
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
