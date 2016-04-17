namespace BiggestOfThree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Biggest
    {
        static void Main(string[] args)
        {
            var list = new List<double>();

            for (int i = 0; i < 3; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }

            var sorted = list.OrderByDescending(b => b);

            Console.WriteLine(sorted.First());
        }
    }
}
