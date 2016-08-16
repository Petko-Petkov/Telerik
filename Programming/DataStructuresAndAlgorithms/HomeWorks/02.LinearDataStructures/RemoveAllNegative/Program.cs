namespace RemoveAllNegative
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private static List<int> input = new List<int>()
        {
            11, 222, 3, 15, -5, -6, -12, 13, 22, -1
        };
        static void Main(string[] args)
        {
            var output = input
                .Where(x => x > 0)
                .OrderBy(X => X)
                .ToList();

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
