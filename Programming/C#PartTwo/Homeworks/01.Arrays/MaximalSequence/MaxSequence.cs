namespace MaximalSequence
{
    using System;

    class MaxSequence
    {
        static void Main(string[] args)
        {
            var arr = FillArray();
            var longestSequence = FindMaximalSequence(arr);
            Console.WriteLine(longestSequence);
        }

        private static int FindMaximalSequence(int[] arr)
        {
            var longest = 1;
            var currentLongest = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                var prev = arr[i - 1];
                var current = arr[i];

                if (current == prev)
                {
                    currentLongest++;

                    if (currentLongest > longest)
                    {
                        longest = currentLongest;
                    }
                }
                else
                {
                    currentLongest = 1;
                }
            }

            return longest;
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
