namespace SortThreeNumbers
{
    using System;
    using System.Linq;
    class Sort
    {
        static void Main(string[] args)
        {
            var list = new double[3];

            for (int i = 0; i < 3; i++)
            {
                list[i] = double.Parse(Console.ReadLine());
            }

            var ordered = list.OrderByDescending(b => b);

            Console.WriteLine(string.Join(" ", ordered));
        }
    }
}
