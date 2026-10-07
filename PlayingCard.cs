namespace Labb1;
class PlayingCard
{
    public Suit PlayingSuit {get;set;}
    public Rank PlayingRank {get;set;}

    public PlayingCard(Suit suit, Rank rank)
    {
        PlayingSuit = suit;
        PlayingRank = rank;
    }
    public override string ToString()
    {
        return $"{PlayingSuit}";
    }
}