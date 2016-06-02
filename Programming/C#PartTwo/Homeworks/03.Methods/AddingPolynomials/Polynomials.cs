namespace AddingPolynomials
{
    using System;
    using System.Linq;
    using System.Text;
    class Polynomials
    {
        static void Main(string[] args)
        {
            ReadInput();
        }

        private static void ReadInput()
        {
            var length = int.Parse(Console.ReadLine());
            var firstArray = Console.ReadLine().Split().Select(x => Convert.ToInt32(x)).ToArray();
            var secondArray = Console.ReadLine().Split().Select(x => Convert.ToInt32(x)).ToArray();

            GenerateOutput(firstArray, secondArray);
        }

        private static void GenerateOutput(int[] firstArray, int[] secondArray)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < firstArray.Length; i++)
            {
                var current = firstArray[i] + secondArray[i];

                sb.Append(current + " ");
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
