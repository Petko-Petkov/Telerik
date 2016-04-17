namespace MMSA
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var sum = 0m;
            var count = 0;
            var average = 0m;
            var maxValue = decimal.MinValue;
            var minValue = decimal.MaxValue;

            for (int i = 1; i <= input; i++)
            {
                count++;

                var number = decimal.Parse(Console.ReadLine());

                if (number > maxValue)
                {
                    maxValue = number;
                }

                if (number < minValue)
                {
                    minValue = number;
                }

                sum += number;

                average = sum / count;
            }

            Console.WriteLine("min={0:F2}", minValue);
            Console.WriteLine("max={0:F2}", maxValue);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", average);
        }
    }
}
