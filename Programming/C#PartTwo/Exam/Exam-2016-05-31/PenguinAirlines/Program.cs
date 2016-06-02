using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenguinAirlines
{
    class Program
    {
        private static Dictionary<int, HashSet<int>> islands = new Dictionary<int, HashSet<int>>();
        private static bool[] visited;

        static void Main(string[] args)
        {
            ReadInput();
        }

        private static void ReadInput()
        {
            var length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                var line = Console.ReadLine();
                if (line == "None")
                {
                    islands[i] = new HashSet<int>();
                }
                else
                {
                    islands[i] = GetSet(line);
                }
            }

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Have a break")
                {
                    break;
                }

                visited = new bool[length];

                var flights = GetList(line);

                CheckFlights(flights[0], flights[1]);
            }
        }

        private static HashSet<int> GetSet(string line)
        {
            var arr = line.Split(' ');
            var list = new HashSet<int>();

            foreach (var item in arr)
            {
                list.Add(int.Parse(item));
            }

            return list;
        }

        private static List<int> GetList(string line)
        {
            var arr = line.Split(' ');
            var list = new List<int>();

            foreach (var item in arr)
            {
                list.Add(int.Parse(item));
            }

            return list;
        }

        private static void CheckFlights(int from, int to)
        {
            if (islands[from].Count == 0 || islands[to].Count == 0)
            {
                Console.WriteLine("No flights available.");
            }
            else if (islands[from].Contains(to) || islands[to].Contains(from))
            {
                Console.WriteLine("There is a direct flight.");
            }
            else
            {
                BFS(from, to);
            }
        }

        private static void BFS(int first, int second)
        {
            var queue = new Queue<int>();
            queue.Enqueue(first);

            while (queue.Count != 0)
            {
                int v = queue.Dequeue();
                if (visited[v])
                {
                    continue;
                }

                foreach (var w in islands[v])
                {
                    if (islands[w].Contains(second) || islands[v].Contains(second))
                    {
                        Console.WriteLine("There are flights, unfortunately they are not direct, grandma :(");
                        return;
                    }
                    queue.Enqueue(w);
                }

                visited[v] = true;
            }

            Console.WriteLine("No flights available.");
        }
    }
}
