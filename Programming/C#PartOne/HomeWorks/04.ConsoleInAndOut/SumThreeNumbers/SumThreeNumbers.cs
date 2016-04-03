namespace SumThreeNumbers
{
    using System;

    class SumThreeNumbers
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int i = 0; i < 3; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
