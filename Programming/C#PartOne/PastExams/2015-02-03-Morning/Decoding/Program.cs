using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoding
{
    class Program
    {
        static void Main(string[] args)
        {
            var salt = decimal.Parse(Console.ReadLine());
            var text = Console.ReadLine().Split('@')[0];

            for (int i = 0; i < text.Length; i++)
            {
                var currentChar = text[i];
                decimal result;

                if (Char.IsDigit(currentChar))
                {
                    result = currentChar + salt + 500;
                }
                else if (Char.IsLetter(currentChar))
                {
                    result = (currentChar * salt) +1000;
                }
                else
                {
                    result = currentChar - salt;
                }

                if (i % 2 == 0)
                {
                    Console.WriteLine("{0:F2}", result / 100);
                }
                else
                {
                    Console.WriteLine(result * 100);
                }
            }
        }
    }
}
