using CardGame.Enums;

namespace CardGame.Models
{
    public class Deck
    {
        public List<Card> Cards { get; set; }
        private readonly Random _random;

        public Deck()
        {
            Cards = new List<Card>();
            _random = new Random();
            CreateFullDeck();
        }

        private void CreateFullDeck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
                {
                    Cards.Add(new Card(suit, rank));
                }
            }
        }

        public void Shuffle()
        {
            for (int i = Cards.Count - 1; i > 0; i--)
            {
                int j = _random.Next(i + 1);
                (Cards[i], Cards[j]) = (Cards[j], Cards[i]);
            }
        }

        public Card DrawCard()
        {
            if (Cards.Count == 0)
                throw new InvalidOperationException("O baralho está vazio.");

            Card topCard = Cards[0];
            Cards.RemoveAt(0);
            return topCard;
        }
    }
}