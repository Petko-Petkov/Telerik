namespace AppearanceCounter
{
    using System;
    using System.Collections.Generic;

    class Counter
    {
        static void Main(string[] args)
        {
            ReadInput();
        }

        private static void ReadInput()
        {
            var count = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, int>();
            var line = Console.ReadLine().Split(' ');

            for (int i = 0; i < count; i++)
            {
                var current = line[i];

                if (!dict.ContainsKey(current))
                {
                    dict[current] = 0;
                }

                dict[current]++;
            }

            var searched = Console.ReadLine();

            Print(dict, searched);
        }

        private static void Print(Dictionary<string, int> dict, string searched)
        {
            if (!dict.ContainsKey(searched))
            {
                Console.WriteLine(0);
                return;
            }
            Console.WriteLine(dict[searched]);
        }
    }
}
