namespace Labb1;

enum Suit
{
    Hearts,
    Diamonds,
    Clubs,
    Spades
}
enum Rank
{
    two = 2,
    three = 3,
    four = 4,
    five = 5,
    six = 6,
    seven = 7,
    eight = 8,
    nine = 9,
    ten = 10,
    jack = 11,
    queen = 12,
    king = 13,
    ace = 14
}
enum UnoColor
{
    Red,
    Blue,
    Green,
    Yellow
}
enum UnoRank
{
    zero,
    one,
    two,
    three,
    four,
    five,
    six,
    seven,
    eight,
    nine,
    skip,
    reverse,
    drawTwo
}
class Program
{
    static void Main(string[] args)
    {
        
    }

    public static void Pdeck<T>(Deck<T> deck)
    {
        Console.WriteLine("Old Deck:");
        PrintDeck(deck);
        deck.Shuffle();
        Console.WriteLine("----------------");
        Console.WriteLine("Shuffled Deck:");
        PrintDeck(deck);
        Console.ReadKey();

    }

    public static void PrintDeck<T>(Deck<T> deck)
    {
        foreach (var card in deck.Cards)
        {
            Console.WriteLine(card);
        }
    }

    public static void PlayingDeck()
    {
        var cards = Enum.GetValues<Suit>()
            .SelectMany(suit => Enum.GetValues<Rank>()
                .Select(rank => new PlayingCard(suit, rank)));

        Deck<PlayingCard> deck = new Deck<PlayingCard>(cards);
        Pdeck(deck);
    }

    public static void UnoDeck()
    {
        var cards = Enum.GetValues<UnoColor>()
            .SelectMany(color => Enum.GetValues<UnoRank>()
                .Take(10)
                .Select(rank => new UnoCard(color, rank)));

        Deck<UnoCard> deck = new Deck<UnoCard>(cards);
        Pdeck(deck);
    }
}
