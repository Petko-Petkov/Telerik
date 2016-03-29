using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersianRugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = int.Parse(Console.ReadLine());
            var distance = int.Parse(Console.ReadLine());
            var middleLine = string.Format("{0}X{0}", new string('#', height));

            for (int i = 0; i < height; i++)
            {
                var shaprs = new string('#', i);
                string spaces;
                var left = (2 * height - 3) - (2 * distance) - (2 * i);

                if (left > 0)
                {
                    spaces = new string(' ', distance);
                    var dots = new string('.', left);

                    Console.WriteLine("{0}\\{1}\\{2}/{1}/{0}", shaprs, spaces, dots);
                }
                else
                {
                    spaces = new string(' ', height * 2 - 2 * i - 1);

                    Console.WriteLine("{0}\\{1}/{0}", shaprs, spaces);
                }
            }

            Console.WriteLine(middleLine);

            for (int i = height - 1; i >= 0; i--)
            {
                var shaprs = new string('#', i);
                string spaces;
                var left = (2 * height - 3) - (2 * distance) - (2 * i);

                if (left > 0)
                {
                    spaces = new string(' ', distance);
                    var dots = new string('.', left);

                    Console.WriteLine("{0}/{1}/{2}\\{1}\\{0}", shaprs, spaces, dots);
                }
                else
                {
                    spaces = new string(' ', height * 2 - 2 * i - 1);

                    Console.WriteLine("{0}/{1}\\{0}", shaprs, spaces);
                }
            }
        }
    }
}
