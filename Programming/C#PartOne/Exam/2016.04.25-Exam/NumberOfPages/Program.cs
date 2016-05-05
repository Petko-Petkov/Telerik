using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfPages
{
    class Program
    {
        static void Main(string[] args)
        {
            var digits = int.Parse(Console.ReadLine());
            var pagesCount = 0;
            var count = 1;

            while (true)
            {
                if (pagesCount == digits)
                {
                    Console.WriteLine(count - 1);
                    return;
                }
                var currentPage = count;
                pagesCount += currentPage.ToString().Length;
                count++;
            }
        }
    }
}
