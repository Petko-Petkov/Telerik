/* Find online more information about ASCII (American Standard Code for Information Interchange) 
 * and write a program that prints the visible characters of the ASCII table on the console 
 * (characters from 33 to 126 including).*/

namespace PrintASCIITable
{
    using System;
    using System.Text;

    class PrintASCIITable
    {
        static void Main()
        {
            // Console.OutputEncoding = Encoding.UTF8;
            char character = '\u0021';

            for (int i = 33; i <= 126; i++)
            {
                Console.Write(character);
                character++;
            }
        }
    }
}
