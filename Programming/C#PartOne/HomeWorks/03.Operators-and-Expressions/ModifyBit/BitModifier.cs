namespace ModifyBit
{
    using System;

    class BitModifier
    {
        static void Main(string[] args)
        {
            var input = long.Parse(Console.ReadLine());
            var position = int.Parse(Console.ReadLine());
            var bit = int.Parse(Console.ReadLine());

            var result = (bit == 0 ? input & (~(1 << position)): input | (1 << position));
            
            Console.WriteLine(result);
        }
    }
}
