namespace DeckOfCards;

public class Deck
{
    private readonly List<Card> _deck = new();
    private readonly Random _rng = new();
    public int Count { get => _deck.Count; }

    public Deck()
    {
        Restock();
    }

    public Deck(List<Card> cardDeck)
    {
        _deck = cardDeck;
    }

    public void Restock()
    {
        _deck.Clear();
        foreach (CardSuit suitVal in Enum.GetValues<CardSuit>())
        {
            foreach (CardRank rankVal in Enum.GetValues<CardRank>())
            {
                _deck.Add(new Card(suitVal, rankVal));
            }
        }
    }

    public void Shuffle()
    {
        for (int i = _deck.Count - 1; i > 1; i--)
        {
            int rnd = _rng.Next(i + 1);
            (_deck[i], _deck[rnd]) = (_deck[rnd], _deck[i]);
        }
    }

    public Deck PopRange(int amount)
    {
        int maxAmount = int.Min(_deck.Count, amount);
        if (maxAmount <= 0)
            return new();
        int startIdx = _deck.Count - amount;
        Deck poppedRange = new(_deck.GetRange(startIdx, maxAmount));
        for (int i = 0; i < maxAmount; i++)
        {
            _deck.RemoveAt(startIdx);
        }
        return poppedRange;
    }

    public override string ToString()
    {
        return string.Join('\n', _deck.Select(x => x.ToString()));
    }
}
