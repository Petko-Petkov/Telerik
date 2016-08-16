namespace RemoveOddOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private static List<int> input = new List<int>()
        {
            4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2
        };

        static void Main(string[] args)
        {
            var output = input
                .GroupBy(x => x)
                .Select(g => new { Value = g.Key, Count = g.Count() })
                .Where(g => g.Count % 2 == 0)
                .ToList();

            foreach (var item in output)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
