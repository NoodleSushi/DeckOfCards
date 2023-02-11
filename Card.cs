namespace DeckOfCards;

public enum CardSuit
{
    Heart,
    Spade,
    Diamond,
    Clove,
}

public enum CardRank
{
    Ace,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Jack,
    Queen,
    King,
}

public readonly struct Card
{
    private readonly CardSuit _suit;
    private readonly CardRank _rank;

    public Card(CardSuit suit, CardRank rank)
    {
        _suit = suit;
        _rank = rank;
    }

    public override string ToString()
    {
        return $"Suit: {Enum.GetName(_suit)}; Rank: {Enum.GetName(_rank)}";
    }
}
