namespace FrequentNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MostFrequent
    {
        static void Main(string[] args)
        {
            var dict = FillDictionary();
            var mostFrequent = dict
                .OrderByDescending(t => t.Value)
                .FirstOrDefault();

            Console.WriteLine("{0} ({1} times)", mostFrequent.Key, mostFrequent.Value);
        }

        private static Dictionary<string, int> FillDictionary()
        {
            var length = int.Parse(Console.ReadLine());
            var arr = new Dictionary<string, int>();

            for (int i = 0; i < length; i++)
            {
                var current = Console.ReadLine();

                if (!arr.ContainsKey(current))
                {
                    arr.Add(current, 0);
                }

                arr[current]++;
            }

            return arr;
        }
    }
}
