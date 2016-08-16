namespace LongestSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private static List<string> inputs = new List<string>()
        {
            "2,2,3,5,6,5,5,5,5,2,2,2,2,2",
            "1,2,3,4,5,5,5,5,3,3,3,3"
        };

        static void Main(string[] args)
        {
            for (int i = 0; i < inputs.Count; i++)
            {
                var currentList = inputs[i].Split(',').Select(x => int.Parse(x)).ToList();
                GetLongestSequence(currentList);
            }
        }

        private static void GetLongestSequence(List<int> currentList)
        {
            var currentLongest = 1;
            var longest = 0;
            int eqElement = 0;

            for (int i = 1; i < currentList.Count; i++)
            {
                var current = currentList[i];
                var prev = currentList[i - 1];

                if (prev == current)
                {
                    currentLongest++;
                }
                else
                {
                    currentLongest = 1;
                }

                if (currentLongest > longest)
                {
                    longest = currentLongest;
                    eqElement = prev;
                }
            }

            var list = Enumerable.Repeat(eqElement, longest).ToList();

            PrintOutput(list);
        }

        private static void PrintOutput(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }
    }
}
