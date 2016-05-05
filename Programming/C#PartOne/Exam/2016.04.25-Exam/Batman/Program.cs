using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batman
{
    class Program
    {
        private static int externalModifier = 0;
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            char character = (char)Console.Read();

            var emptySpaceModifier = (length / 2) - 1;
            var downEmpty = length / 2;

            for (int i = 0; i < emptySpaceModifier; i++)
            {
                var startEnd = new string(' ', i);
                var characters = new string(character, length - i);
                var whiteSpaces = new string(' ', length);
                Console.WriteLine("{0}{1}{2}{1}{0}", startEnd, characters, whiteSpaces);
                externalModifier = length - emptySpaceModifier;
            }

            var startEndOut = new string(' ', emptySpaceModifier);
            var charctersOut = new string(character, length - emptySpaceModifier);

            var middleLine = string.Format("{0}{1}{0}{2} {2}{0}{1}{0}", startEndOut, charctersOut, character);
            Console.WriteLine(middleLine);
            var bodyLength = length / 3;

            for (int i = 0; i < bodyLength; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string(' ', downEmpty), new string(character, (length * 3) - (downEmpty * 2)));
            }

            for (int i = 0, j = length + 1, k = length - 2; i < downEmpty; i++, j++, k-= 2)
            {
                Console.WriteLine("{0}{1}{0}", new string(' ', j), new string(character, k));
            }
        }
    }
}
