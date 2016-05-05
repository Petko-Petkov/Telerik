namespace SelectionSort
{
    using System;

    class SelectionSort
    {
        private static int[] arr;

        static void Main(string[] args)
        {
            FillArray();
            Sort(arr);
            PrintArr(arr);
        }

        private static void PrintArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        private static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var minPosition = i;

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minPosition])
                    {
                        minPosition = j;
                    }
                }

                if (minPosition != i)
                {
                    var temp = arr[i];
                    arr[i] = arr[minPosition];
                    arr[minPosition] = temp;
                }
            }
        }

        private static int[] FillArray()
        {
            var length = int.Parse(Console.ReadLine());
            arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }
    }
}
