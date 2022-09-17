using System;

namespace Cards
{
    public enum SuitType
    {
        Hearts,
        Clubs,
        Diamonds,
        Spades
    }

    public enum CardValueType
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public class PlayingCard
    {
        public PlayingCard(SuitType suitType, CardValueType cardValueType)
        {
            Suit = suitType;
            Value = cardValueType;

            switch (suitType)
            {
                case SuitType.Hearts:
                case SuitType.Spades:
                    IsRed = true;
                    break;
                default:
                    IsRed = false;
                    break;
            }
        }

        public Guid CardId { get; } = Guid.NewGuid();

        public SuitType Suit { get; }

        public CardValueType Value { get; }

        public bool IsRed { get; set; }

        public bool IsDealt { get; set; }

        public override string ToString()
        {
            var colour = IsRed ? "Red" : "Black";

            return $"{Value} of {Suit}. Colour: {colour}";
        }
    }
}

