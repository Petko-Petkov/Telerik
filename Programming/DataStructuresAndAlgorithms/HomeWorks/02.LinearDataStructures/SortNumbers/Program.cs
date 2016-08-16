namespace SortNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var list = ReadInput();
            var ordered = list.OrderBy(x => x);

            foreach (var item in ordered)
            {
                Console.WriteLine(item);
            }
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
