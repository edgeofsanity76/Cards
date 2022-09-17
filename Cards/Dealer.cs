namespace Cards
{
    internal class Dealer
    {
        private readonly List<PlayingCard> _deck;
        private readonly Random _random = new();


        public Dealer()
        {
            _deck = GenerateDeck().ToList();
        }

        private static IEnumerable<PlayingCard> GenerateDeck()
        {
            for (var i = 0; i < Enum.GetValues(typeof(SuitType)).Length; i++)
            {
                for (var j = 0; j < Enum.GetValues(typeof(CardValueType)).Length; j++)
                {
                    yield return new PlayingCard((SuitType)i, (CardValueType)j);
                }
            }
        }

        public IReadOnlyList<PlayingCard> GetDeck()
        {
            return _deck;
        }

        public PlayingCard GetCardRandomFromDeck()
        {
            var dealableCards = _deck.Where(c => c.IsDealt == false).ToList();

            if (!dealableCards.Any()) return null!;
            var randomCard = dealableCards[_random.Next(0, dealableCards.Count - 1)];

            _deck.First(c => c.CardId == randomCard.CardId).IsDealt = true;

            return randomCard;
        }
    }
}
