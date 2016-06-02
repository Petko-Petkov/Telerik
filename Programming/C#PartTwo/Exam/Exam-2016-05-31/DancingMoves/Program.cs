namespace DancingMoves
{
    using System;

    class Program
    {
        private static decimal[] inputArray;
        private static decimal steps = 0;
        private static decimal result = 0;
        private static int lastIndex = 0;

        static void Main(string[] args)
        {
            ReadInput();
        }

        private static void ReadInput()
        {
            inputArray = GetList(Console.ReadLine());

            while (true)
            {
                var commands = Console.ReadLine();
                if (commands == "stop")
                {
                    Console.WriteLine("{0:F1}", result / steps);
                    break;
                }
                steps+=1;
                var commandsArray = commands.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var count = int.Parse(commandsArray[0]);
                var direction = commandsArray[1];
                var step = int.Parse(commandsArray[2]);

                GenerateMove(count, direction, step);
            }
        }

        private static void GenerateMove(int count, string direction, int step)
        {
            step %= inputArray.Length;

            switch (direction)
            {
                case "left":
                    for (int i = 0; i < count; i++)
                    {
                        if (lastIndex - step < 0)
                        {
                            lastIndex = inputArray.Length + lastIndex;
                        }

                        result += inputArray[lastIndex - step];
                        lastIndex -= step;
                    }
                    break;
                default:
                    for (int i = 0; i < count; i++)
                    {
                        if (lastIndex + step >= inputArray.Length)
                        {
                            lastIndex = lastIndex - inputArray.Length;
                        }

                        result += inputArray[lastIndex + step];
                        lastIndex += step;
                    }
                    break;
            }
        }

        private static decimal[] GetList(string line)
        {
            var arr = line.Split(' ');
            var list = new decimal[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                list[i] = decimal.Parse(arr[i]);
            }

            return list;
        }
    }
}