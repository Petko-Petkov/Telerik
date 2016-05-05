namespace MaximalKSum
{
    using System;
    using System.Linq;

    class MaxSum
    {
        private static int K;

        static void Main(string[] args)
        {
            var arr = FillArray();
            int sum = GetSum(arr);
            Console.WriteLine(sum);
        }

        private static int GetSum(int[] arr)
        {
            var maxEls = arr
                .OrderByDescending(t => t)
                .Take(K);

            return maxEls.Sum();
        }

        private static int[] FillArray()
        {
            var length = int.Parse(Console.ReadLine());
            K = int.Parse(Console.ReadLine());
            var arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }
    }
}
