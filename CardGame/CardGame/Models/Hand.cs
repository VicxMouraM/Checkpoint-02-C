using System.Collections.Generic;

namespace CardGame.Models
{
    public class Hand
    {
        public List<Card> Cards { get; set; }

        public Hand()
        {
            Cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public Card PlayCard(int index)
        {
            if (index < 0 || index >= Cards.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Índice inválido da carta.");

            Card selectedCard = Cards[index];
            Cards.RemoveAt(index);
            return selectedCard;
        }
    }
}