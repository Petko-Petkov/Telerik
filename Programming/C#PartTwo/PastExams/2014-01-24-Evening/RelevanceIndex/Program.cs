using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevanceIndex
{
    class Program
    {
        private static string searchedWord;
        private static Dictionary<int, string> orderedOutput = new Dictionary<int, string>();

        static void Main(string[] args)
        {
            ReadInput();
            WriteOutput();
        }

        private static void WriteOutput()
        {
            var output = orderedOutput.OrderByDescending(x => x.Key);

            foreach (var item in output)
            {
                Console.WriteLine(item.Value);
            }
        }

        private static void ReadInput()
        {
            searchedWord = Console.ReadLine();
            var length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                var line = Console.ReadLine();

                SearchOccurences(line);

            }
        }

        private static void SearchOccurences(string line)
        {
            var result = 0;

            var strArr = line.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < strArr.Length; i++)
            {
                var word = strArr[i];
                if (searchedWord.ToLower() == word.ToLower())
                {
                    result++;
                    strArr[i] = word.ToUpper();
                }
            }

            GenerateOutputString(strArr, result);
        }

        private static void GenerateOutputString(string[] strArr, int result)
        {
            orderedOutput[result] = string.Join(" ", strArr);
        }
    }
}
