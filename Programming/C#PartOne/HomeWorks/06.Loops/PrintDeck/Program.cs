namespace PrintDeck
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var card = Console.ReadLine();
            int length;

            switch (card)
            {
                case "J":
                    length = 11;
                    break;
                case "Q":
                    length = 12;
                    break;
                case "K":
                    length = 13;
                    break;
                case "A":
                    length = 14;
                    break;
                default:
                    length = int.Parse(card);
                    break;
            }

            for (int i = 2; i <= length; i++)
            {
                string currentCard;

                switch (i)
                {
                    case 11:
                        currentCard = "J";
                        break;
                    case 12:
                        currentCard = "Q";
                        break;
                    case 13:
                        currentCard = "K";
                        break;
                    case 14:
                        currentCard = "A";
                        break;
                    default:
                        currentCard = i.ToString();
                        break;
                }
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", currentCard);
            }
        }
    }
}
