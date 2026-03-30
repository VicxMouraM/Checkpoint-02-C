using CardGame.Enums;

namespace CardGame.Models
{
    public class Card
    {
        public Suit Suit { get; set; }
        public CardRank Rank { get; set; }

        public Card(Suit suit, CardRank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }
}