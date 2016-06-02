namespace IntegerCalculations
{
    using System;
    using System.Linq;

    class Calculations
    {
        static void Main(string[] args)
        {
            ReadInput();
        }

        private static void ReadInput()
        {
            var arr = Console.ReadLine().Split(' ').Select(x => Convert.ToDecimal(x)).OrderBy(y => y).ToArray();
            GenerateOutput(arr);
        }

        private static void GenerateOutput(decimal[] arr)
        {
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[arr.Length - 1]);
            Console.WriteLine("{0:F2}", arr.Average());
            Console.WriteLine(arr.Sum());
            decimal result = 1;

            foreach (var item in arr)
            {
                result *= item;
            }

            Console.WriteLine(result);
        }
    }
}
