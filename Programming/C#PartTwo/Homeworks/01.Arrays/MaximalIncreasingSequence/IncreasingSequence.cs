namespace MaximalIncreasingSequence
{
    using System;

    class IncreasingSequence
    {
        static void Main(string[] args)
        {
            var arr = FillArray();
            var length = FindMaximalIncreasingSequence(arr);

            Console.WriteLine(length);
        }

        private static int FindMaximalIncreasingSequence(int[] arr)
        {
            var longest = 1;
            var currentLongest = 1;
            var maxIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                var prev = arr[i - 1];
                var current = arr[i];

                if (current > prev)
                {
                    currentLongest++;

                    if (currentLongest > longest)
                    {
                        longest = currentLongest;
                        maxIndex = i;
                    }
                }
                else
                {
                    currentLongest = 1;
                }
            }

            //var start = maxIndex - longest;

            //for (int i = start+1; i <= maxIndex; i++)
            //{
            //    Console.WriteLine("->" + arr[i]);
            //}

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
