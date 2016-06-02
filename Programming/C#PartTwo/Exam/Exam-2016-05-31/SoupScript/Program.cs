using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoupScript
{
    class Program
    {
        private static StringBuilder output = new StringBuilder();
        private static int indent = 0;
        static void Main(string[] args)
        {
            ReadInput();
            Console.WriteLine(output.ToString().Trim());
        }

        private static void ReadInput()
        {
            var length = int.Parse(Console.ReadLine());

            for (int row = 0; row < length; row++)
            {
                var line = Console.ReadLine();
                var currentLine = string.Empty;

                if (String.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                var commentIndex = line.IndexOf("//");
                if (commentIndex > 0 || (line[0] == '/' && line[1] == '/'))
                {
                    var comment = line.Substring(commentIndex);
                    output.AppendLine(GetIndent() + comment);
                    line = line.Substring(0, commentIndex);
                }

                if (String.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                
                currentLine = GetFormattedLine(line.Trim());
                output.AppendLine(currentLine);
            }
        }

        private static string GetFormattedLine(string line)
        {
            var sb = new StringBuilder();
            sb.Append(GetIndent());

            for (int i = 0; i < line.Length; i++)
            {
                var currentChar = line[i];
                if (currentChar == '{')
                {
                    indent += 4;
                    if (line[i-1] != ' ')
                    {
                        sb.Append(' ');
                    }
                    sb.Append(currentChar);
                    break;
                }

                if (currentChar == '}')
                {
                    indent -= 4;
                    sb.Append(currentChar);
                    if (sb.Length > 0)
                    {
                        sb = sb.Remove(0, 4);
                    }
                    break;
                }

                if (currentChar == '\'')
                {
                    var remaining = line.Substring(i + 1, line.Length - i - 1);
                    var endingStringIndex = remaining.IndexOf('\'');
                    var str = line.Substring(i, endingStringIndex+2);
                    sb.Append(str);
                    i += endingStringIndex + 1;
                    continue;
                }

                if (currentChar == '.' || currentChar == '(' || currentChar == ',' || currentChar == ')' || currentChar == ';')
                {
                    if (line[i - 1] == ' ')
                    {
                        sb.Remove(sb.Length - 1, 1);
                    }

                    if (currentChar == '(' && line[i + 1] == ' ')
                    {
                        i += 1;
                    }
                }

                if (IsOperator(currentChar))
                {
                    if (line[i - 1] != ' ')
                    {
                        sb.Append(' ');
                    }
                    sb.Append(currentChar);
                    if (line[i + 1] != ' ')
                    {
                        sb.Append(' ');
                    }

                    continue;
                }

                if (currentChar == '!')
                {
                    if (line[i + 1] == ' ')
                    {
                        i += 1;
                        sb.Append(currentChar);
                        continue;
                    }
                }

                if (currentChar == ' ')
                {
                    if (line[i - 1] == ' ')
                    {
                        continue;
                    }
                    if (line[i-1] == ')' && line[i+1] == '{')
                    {
                        sb.Append(currentChar);
                        continue;
                    }
                    if (IsOperator(line[i-1]) || IsOperator(line[i+1]))
                    {
                        sb.Append(currentChar);
                        continue;
                    }
                    if (line[i-1] == ',')
                    {
                        sb.Append(currentChar);
                        continue;
                    }
                    if (line[i - 1] == '.' || line[i + 1] == '.' || line[i-1] == ';' || line[i + 1] == ';')
                    {
                        continue;
                    }

                    sb.Append(currentChar);
                    continue;
                }

                sb.Append(currentChar);
            }

            return sb.ToString();
        }

        private static bool IsOperator(char v)
        {
            switch (v)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                case '=':
                case '>':
                case '<':
                    return true;
                default:
                    return false;
            }
        }

        private static string GetIndent()
        {
            return new string(' ', indent);
        }
    }
}
