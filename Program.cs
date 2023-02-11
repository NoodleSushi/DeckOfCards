namespace DeckOfCards;

public static class Program
{
    public static void Main(string[] args)
    {
        Deck deck = new();

        while (true)
        {
            Console.Write(
                """
                    Deck of Cards
                    1 - Create
                    2 - Shuffle
                    3 - Deal
                    4 - Display Deck
                    Choice: 
                    """
            );
            int choice = GetIntInput();
            switch (choice)
            {
                case 1:
                    deck.Restock();
                    Console.WriteLine("New deck created!");
                    break;
                case 2:
                    deck.Shuffle();
                    Console.WriteLine("Deck Shuffled.");
                    break;
                case 3:
                    Console.Write("How many? ");
                    int cardAmount = GetIntInput();
                    Deck dealtCards = deck.PopRange(cardAmount);
                    Console.WriteLine(dealtCards.ToString());
                    break;
                case 4:
                    Console.WriteLine(deck.ToString());
                    Console.WriteLine($"Number of cards: {deck.Count}");
                    break;
            }
        }
    }

    public static int GetIntInput()
    {
        return Convert.ToInt32(Console.ReadLine());
    }
}
