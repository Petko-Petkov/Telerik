namespace SumFiveNumbers
{
    using System;

    class SumFiveNumbers
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
