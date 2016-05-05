namespace QuickSort
{
    using System;

    class Sort
    {
        static void Main(string[] args)
        {
            var arr = FillArray();
            Quicksort(arr, 0, arr.Length - 1);
            PrintOutput(arr);
        }

        private static void PrintOutput(string[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static void Quicksort(IComparable[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }

        private static string[] FillArray()
        {
            var length = int.Parse(Console.ReadLine());
            var arr = new string[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = Console.ReadLine();
            }

            return arr;
        }
    }
}
