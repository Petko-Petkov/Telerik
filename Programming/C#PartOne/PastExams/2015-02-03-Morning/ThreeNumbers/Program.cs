namespace ThreeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var inputList = new List<double>();

            for (int i = 0; i < 3; i++)
            {
                inputList.Add(double.Parse(Console.ReadLine()));
            }

            var list = inputList.OrderByDescending(b => b);

            Console.WriteLine(list.FirstOrDefault());
            Console.WriteLine(list.LastOrDefault());
            Console.WriteLine("{0:F2}", list.Sum() / 3);
        }
    }
}
