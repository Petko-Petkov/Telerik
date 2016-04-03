namespace SumNNumbers
{
    using System;

    class Sum
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
