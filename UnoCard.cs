namespace Labb1;
class UnoCard
{
    public UnoColor Color { get;set;}
    public UnoRank Rank { get;set;}

    public UnoCard(UnoColor color, UnoRank rank)
    {
        Color = color;
        Rank = rank;
    }
    public override string ToString()
    {
        return $"{Color} {Rank}";
    }
}