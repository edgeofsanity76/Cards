using Cards;

var dealer = new Dealer();

foreach (var card in dealer.GetDeck())
{
    Console.WriteLine(card);
}

Console.WriteLine($"There are {dealer.GetDeck().Count} cards in the deck");

while (Console.ReadKey().Key != ConsoleKey.Escape)
{
    var randomCard = dealer.GetCardRandomFromDeck();
    Console.WriteLine(randomCard);
}