namespace FindOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private static List<int> input = new List<int>()
        {
            3, 4, 4, 2, 3, 3, 4, 3, 2
        };

        static void Main(string[] args)
        {
            var output = input
                .GroupBy(x => x)
                .Select(g => new { Value = g.Key, Count = g.Count() })
                .ToList();

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Value} -> {item.Count} times");
            }
        }
    }
}
