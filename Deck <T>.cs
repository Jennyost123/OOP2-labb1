namespace Labb1;

class Deck<T>
{
    public List<T> Cards { get; set; }

    public Deck()
    {
        Cards = new List<T>();
    }

    public void Add(T card)
    {
        Cards.Add(card);
    }

    public void AddRange(List<T> cards)
    {
        Cards.AddRange(cards);
    }

    public T Draw()
    {
        T drawnCard = Cards[0];
        Cards.RemoveAt(0);
        return drawnCard;
    }

    public List<T> Draw(int count)
    {
        var drawnCards = Cards.GetRange(0, count);
        Cards.RemoveRange(0, count);
        return drawnCards;
    }

    public void Shuffle()
    {
        Cards = Cards.OrderBy(x => Random.Shared.Next()).ToList();
    }
}
