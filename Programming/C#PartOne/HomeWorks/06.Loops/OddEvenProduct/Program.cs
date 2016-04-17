namespace OddEvenProduct
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var line = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var oddProduct = 1;
            var evenProduct = 1;

            for (int i = 0; i < line.Length; i++)
            {
                var num = int.Parse(line[i]);

                if (i % 2 == 0)
                {
                    evenProduct *= num;
                }
                else
                {
                    oddProduct *= num;
                }
            }

            if (evenProduct == oddProduct)
            {
                Console.WriteLine("yes {0}", evenProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}", evenProduct, oddProduct);
            }
        }
    }
}
