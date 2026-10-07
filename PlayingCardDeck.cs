namespace Labb1;

class PlayingCardDeck
{
    public List <PlayingCard> Cards {get;set;}
    public PlayingCardDeck()
    {
        Cards = new List<PlayingCard>();
        Enum.GetValues(typeof(Suit)).Cast<Suit>().ToList().ForEach(suit =>
        {
            Enum.GetValues(typeof(Rank)).Cast<Rank>().ToList().ForEach(rank =>
            {
                Cards.Add(new PlayingCard(suit, rank));
            });
        });
    }
    public void Add(PlayingCard card)
    {
        Cards.Add(card);
    }
    public void AddRange(List<PlayingCard> cards)
    {
        Cards.AddRange(cards);
    }
    public PlayingCard Draw()
    {   Cards.RemoveAt(0);
        return Cards[0];
    }
    public List<PlayingCard> Draw(int count)
    {
        var drawnCards = Cards.GetRange(0, count);
        Cards.RemoveRange(0, count);
        return drawnCards;
           
        /* var drawnCards = new List<PlayingCard>();
        for (int i = 0; i < count; i++)
        {
            drawnCards.Add(Cards[0]);
            Cards.RemoveAt(0);
        }
        return drawnCards; */
    }
    public void Shuffle()
    {
        Cards = Cards.OrderBy(x => Random.Shared.Next()).ToList();
    }
}