using System;
using System.Collections.Generic;

namespace CompanyInfo
{
    class PrintCompanyInfo
    {
        static void Main(string[] args)
        {
            List<string> manager = new List<string>();

            for (int i = 1; i <= 9; i++)
            {
                var currentLine = Console.ReadLine();

                switch (i)
                {
                    case 1:
                        Console.WriteLine(currentLine);
                        break;
                    case 2:
                        Console.WriteLine("Address: {0}", currentLine);
                        break;
                    case 3:
                        Console.WriteLine("Tel. {0}", currentLine);
                        break;
                    case 4:
                        Console.WriteLine("Fax: {0}", currentLine!= string.Empty ? currentLine : "(no fax)");
                        break;
                    case 5:
                        Console.WriteLine("Web site: {0}", currentLine);
                        break;
                    default:
                        manager.Add(currentLine);
                        break;
                }
            }

            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", manager[0], manager[1], manager[2], manager[3]);
        }
    }
}
