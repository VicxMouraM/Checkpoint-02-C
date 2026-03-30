namespace CardGame.Models
{
    public class Match
    {
        public List<Player> Players { get; set; }
        public List<Round> RoundsHistory { get; set; }
        public Deck Deck { get; set; }

        public Match(Player player1, Player player2)
        {
            Players = new List<Player> { player1, player2 };
            RoundsHistory = new List<Round>();
            Deck = new Deck();
        }

        public void StartMatch()
        {
            Deck.Shuffle();

            for (int i = 0; i < 5; i++)
            {
                Players[0].Hand.AddCard(Deck.DrawCard());
                Players[1].Hand.AddCard(Deck.DrawCard());
            }
        }

        public Round PlayRound()
        {
            if (Players[0].Hand.Cards.Count == 0 || Players[1].Hand.Cards.Count == 0)
                throw new InvalidOperationException("Não há cartas suficientes para jogar a rodada.");

            Card card1 = Players[0].Hand.PlayCard(0);
            Card card2 = Players[1].Hand.PlayCard(0);

            Round round = new Round(card1, card2);
            RoundsHistory.Add(round);

            if (round.Result == Enums.RoundResult.Player1Wins)
                Players[0].Score++;
            else if (round.Result == Enums.RoundResult.Player2Wins)
                Players[1].Score++;

            return round;
        }
    }
}