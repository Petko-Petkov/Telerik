namespace IntDoubleString
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var intArray = new List<string> { "int", "integer" };
            var doubleArray = new List<string> { "real", "double" };
            var stringArray = new List<string> { "text", "string" };

            var inputStr = Console.ReadLine();

            if (stringArray.Contains(inputStr))
            {
                var str = Console.ReadLine();
                Console.WriteLine(str + "*");
            }
            else if(intArray.Contains(inputStr))
            {
                var i = int.Parse(Console.ReadLine());
                Console.WriteLine(i + 1);
            }
            else
            {
                var i = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", i + 1);
            }
        }
    }
}
