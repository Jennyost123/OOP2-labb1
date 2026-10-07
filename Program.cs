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
class Program
{
    static void Main(string[] args)
    {
        PlayingCardDeck deck = new PlayingCardDeck();
        Console.WriteLine( "Old Deck :" );
        Program.PrintDeck(deck);
        Console.ReadKey();

        deck.Shuffle();
        Console.WriteLine( "----------------" );
        Console.WriteLine( "Shuffled Deck:" );
        PrintDeck(deck);
    }

    public static void PrintDeck(PlayingCardDeck deck)
    {
        foreach (var card in deck.Cards)
        {
            Console.WriteLine($"{card.PlayingRank} of {card.PlayingSuit}");
        }
    }
}
