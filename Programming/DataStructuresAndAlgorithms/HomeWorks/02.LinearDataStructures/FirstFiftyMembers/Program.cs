using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstFiftyMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var queue = new Queue<int>();
            var output = new Queue<int>();
            queue.Enqueue(n);
            output.Enqueue(n);
            while (output.Count <= 50)
            {
                var toPrint = queue.Dequeue();
                queue.Enqueue(toPrint + 1);
                output.Enqueue(toPrint + 1);
                queue.Enqueue(2 * toPrint + 1);
                output.Enqueue(2 * toPrint + 1);
                queue.Enqueue(toPrint + 2);
                output.Enqueue(toPrint + 2);
            }

            for (int i = 1; i <= 50; i++)
            {
                var current = output.Dequeue();
                PrintNumber(i, current);
            }
        }

        private static void PrintNumber(int counter, int toPrint)
        {
            Console.WriteLine($"{counter} - {toPrint}");
        }
    }
}
