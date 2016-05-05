namespace CompareArrays
{
    using System;

    public class ArrayComparator
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var firstArray = new int[length];
            var secondArray = new int[length];

            FillArray(firstArray, length);
            FillArray(secondArray, length);
            var equal = CompareArray(firstArray, secondArray);

            Console.WriteLine(equal ? "Equal" : "Not equal");
        }

        private static bool CompareArray(int[] firstArray, int[] secondArray)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    return false;
                }
            }

            return true;
        }

        private static void FillArray(int[] arr, int length)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
