namespace GreatestCommonDivisor
{
    using System;

    class Program
    {
        static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return GCD(b, a % b);
            }
        }
        static void Main()
        {
            var line = Console.ReadLine().Split(' ');
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);
            Console.WriteLine(Math.Abs(GCD(a, b)));
        }
    }
}
