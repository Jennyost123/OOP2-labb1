namespace Labb1;
class UnoCardDeck
{
    
    public List <UnoCard> UnoCards {get;set;}

    public UnoCardDeck()
    {
        UnoCards = new List<UnoCard>();
        Enum.GetValues(typeof(UnoColor)).Cast<UnoColor>().ToList().ForEach(color =>
        {
            Enum.GetValues(typeof(UnoRank)).Cast<UnoRank>().Take(10).ToList().ForEach(rank =>
            {
                UnoCards.Add(new UnoCard(color, rank));
            });
        });
    }
    public void Add(UnoCard UnoCard)
    {
        UnoCards.Add(UnoCard);
    }
    public void AddRange(List<UnoCard> UnoCards)
    {
        this.UnoCards.AddRange(UnoCards);
    }
    public UnoCard Draw()
    {   UnoCard drawnCard = UnoCards[0];
        UnoCards.RemoveAt(0);
        return drawnCard;
    }
     public List<UnoCard> Draw(int count)
    {
        var drawnCards = UnoCards.GetRange(0, count);
        UnoCards.RemoveRange(0, count);
        return drawnCards;
    }
    public void Shuffle()
    {
        UnoCards = UnoCards.OrderBy(x => Random.Shared.Next()).ToList();
    }
}