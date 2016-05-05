namespace CompareCharArrays
{
    using System;

    class CharArrayComparator
    {
        static void Main(string[] args)
        {
            var firstString = Console.ReadLine();
            var secondString = Console.ReadLine();
            
            var length = firstString.Length >= secondString.Length ? secondString.Length : firstString.Length;

            for (int i = 0; i < length; i++)
            {
                if (firstString[i] > secondString[i])
                {
                    Console.WriteLine('>');
                    return;
                }
                else if (firstString[i] < secondString[i])
                {
                    Console.WriteLine('<');
                    return;
                }
            }

            if (firstString.Length == secondString.Length)
            {
                Console.WriteLine('=');
            }
            else
            {
                Console.WriteLine(firstString.Length > secondString.Length ? '>' : '<');
            }
        }
    }
}
