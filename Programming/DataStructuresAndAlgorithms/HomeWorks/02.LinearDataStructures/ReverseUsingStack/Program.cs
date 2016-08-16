namespace ReverseUsingStack
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int num;
            var stack = new Stack<int>();
            while (true)
            {
                var input = Console.ReadLine();

                if (int.TryParse(input, out num))
                {
                    stack.Push(num);
                }
                else
                {
                    break;
                }
            }

            while(stack.Count > 0)
            {
                var last = stack.Pop();
                Console.WriteLine(last);
            }
        }
    }
}
