namespace SumAvgOfSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            var list = ReadInput();
            var sum = list.Sum();
            var avg = sum / list.Count;
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {avg}");
        }

        private static List<int> ReadInput()
        {
            var list = new List<int>();

            while (true)
            {
                int num;
                var input = Console.ReadLine();

                if (int.TryParse(input, out num))
                {
                    list.Add(num);
                }
                else
                {
                    break;
                }
            }

            return list;
        }
    }
}
