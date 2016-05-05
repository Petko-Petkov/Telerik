namespace AllocateArray
{
    using System;

    class Allocator
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());

            var arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i * 5);
            }
        }
    }
}
