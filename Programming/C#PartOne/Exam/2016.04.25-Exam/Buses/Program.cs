using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses
{
    class Program
    {
        static void Main(string[] args)
        {
            var busesCount = int.Parse(Console.ReadLine());
            var counter = 0;
            var currentLowest = int.MaxValue;

            for (int i = 0; i < busesCount; i++)
            {
                var speed = int.Parse(Console.ReadLine());

                if (speed <= currentLowest)
                {
                    currentLowest = speed;
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
