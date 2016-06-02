namespace ReverseString
{
    using System;
    using System.Text;
    class Reverser
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            // First solution
            // Array.Reverse(input);
            // var output = string.Join("", input);
            
            // Second Solution
            var output = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output.Append(input[i]);
            }

            Console.WriteLine(output.ToString());
        }
    }
}
