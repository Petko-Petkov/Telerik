namespace NumbersComparer
{
    using System;

    class NumbersComparer
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(first, second));
        }
    }
}
