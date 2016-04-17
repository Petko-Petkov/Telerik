namespace PlayCards
{
    using System;
    using System.Collections.Generic;
    class Card
    {
        static void Main(string[] args)
        {
            var cards = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            var card = Console.ReadLine();

            if (cards.Contains(card))
            {
                Console.WriteLine("yes {0}", card);
            }
            else
            {
                Console.WriteLine("no {0}", card);
            }
        }
    }
}
