namespace MaximalSum
{
    using System;

    class MaxSum
    {
        static void Main(string[] args)
        {
            var arr = FillArray();
            int sum = GetMaxSum(arr);
            Console.WriteLine(sum);
        }

        private static int GetMaxSum(int[] arr)
        {
            var maxSum = int.MinValue;
            var currSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                currSum += arr[i];
                 
                if (currSum > maxSum)
                {
                    maxSum = currSum;
                }

                if (currSum < 0)
                {
                    currSum = 0;
                }
            }

            return maxSum;
        }

        private static int[] FillArray()
        {
            var length = int.Parse(Console.ReadLine());
            var arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }
    }
}
