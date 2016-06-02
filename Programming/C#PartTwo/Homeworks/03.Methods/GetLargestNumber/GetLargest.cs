namespace GetLargestNumber
{
    using System;

    class GetLargest
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ');

            var larger = GetMax(nums[0], nums[1]);
            larger = GetMax(larger, nums[2]);
            Console.WriteLine(larger);
        }

        private static string GetMax(string first, string second)
        {
            return int.Parse(first) > int.Parse(second) ? first : second;
        }
    }
}
