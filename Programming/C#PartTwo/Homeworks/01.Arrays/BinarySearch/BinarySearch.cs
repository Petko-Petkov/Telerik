namespace BinarySearch
{
    using System;

    class BinarySearch
    {
        static void Main(string[] args)
        {
            var arr = FillArray();
            var num = int.Parse(Console.ReadLine());

            // var index = SearchBinaryRecursive(arr, num, 0, arr.Length);
            var index = SearchBinaryIterative(arr, num, 0, arr.Length);
            Console.WriteLine(index);
        }

        private static int SearchBinaryIterative(int[] arr, int num, int min, int max)
        {
            while (min <= max)
            {
                int middle = (min + max) / 2;
                int currNum = arr[middle];

                if (num == currNum)
                {
                    return middle;
                }
                else if (num < currNum)
                {
                    max = middle - 1;
                }
                else
                {
                    min = middle + 1;
                }
            }

            return -1;
        }

        private static int SearchBinaryRecursive(int[] arr, int number, int min, int max)
        {
            if (min > max)
            {
                return -1;
            }
            else
            {
                int middle = (min + max) / 2;

                if (number == arr[middle])
                {
                    return middle;
                }
                else if (number < arr[middle])
                {
                    return SearchBinaryRecursive(arr, number, min, middle);
                }
                else
                {
                    return SearchBinaryRecursive(arr, number, middle + 1, max);
                }
            }
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
