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
        UnoCardDeck();
    }

    public static void PrintPlayDeck(PlayingCardDeck deck)
    {
        foreach (var card in deck.Cards)
        {
            Console.WriteLine($"{card.PlayingRank} of {card.PlayingSuit}");
        }
    }
    public static void PlayingDeck()
    {
        PlayingCardDeck deck = new PlayingCardDeck();
        Console.WriteLine( "Old Deck :" );
        Program.PrintPlayDeck(deck);
        Console.ReadKey();

        deck.Shuffle();
        Console.WriteLine( "----------------" );
        Console.WriteLine( "Shuffled Deck:" );
        Program.PrintPlayDeck(deck);
    }
     public static void UnoCardDeck()
    {
        UnoCardDeck UnoDeck = new UnoCardDeck();
        Console.WriteLine( "Old Deck :" );
        Program.PrintUnoDeck(UnoDeck);
        Console.ReadKey();

        UnoDeck.Shuffle();
        Console.WriteLine( "----------------" );
        Console.WriteLine( "Shuffled Deck:" );
        PrintUnoDeck(UnoDeck);
    }
    public static void PrintUnoDeck(UnoCardDeck deck)
    {
        for (int i = 0; i < deck.UnoCards.Count; i++)
        {
            var card = deck.UnoCards[i];
            Console.WriteLine($"{card.Color} {card.Rank}");
        }
    }
}
