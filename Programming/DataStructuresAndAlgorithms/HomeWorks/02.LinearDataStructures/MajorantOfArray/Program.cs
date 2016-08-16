namespace MajorantOfArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private static List<int> input = new List<int>()
        {
            2, 2, 3, 3, 2, 3, 4, 3, 3
        };

        static void Main(string[] args)
        {
            var majorant = input
                .GroupBy(x => x)
                .Select(g => new { Value = g.Key, Count = g.Count() })
                .Where(g => g.Count >= input.Count / 2 + 1)
                .FirstOrDefault();

            try
            {
                Console.WriteLine(majorant.Value);
            }
            catch (NullReferenceException)
            {

                throw new NullReferenceException($"No majorant found for provided input");
            }
        }
    }
}
