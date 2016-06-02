namespace LargerThanNeighbours
{
    using System;
    using System.Linq;

    class Neighbours
    {
        static void Main(string[] args)
        {
            ReadInput();
        }

        private static void ReadInput()
        {
            var length = int.Parse(Console.ReadLine());
            var line = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            CalculateResult(line);
        }

        private static void CalculateResult(int[] line)
        {
            var counter = 0;

            for (int i = 1; i < line.Length - 1; i++)
            {
                var current = line[i];
                var previous = line[i - 1];
                var next = line[i + 1];

                if (current > previous && current > next)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
