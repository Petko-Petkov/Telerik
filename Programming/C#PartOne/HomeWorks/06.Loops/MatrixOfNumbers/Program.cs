namespace MatrixOfNumbers
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var line = Enumerable.Range(i, n).ToArray();
                Console.WriteLine(string.Join(" ", line));
            }
        }
    }
}
