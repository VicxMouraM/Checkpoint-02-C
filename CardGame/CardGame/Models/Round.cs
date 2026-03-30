using CardGame.Enums;

namespace CardGame.Models
{
    public class Round
    {
        public Card Player1Card { get; set; }
        public Card Player2Card { get; set; }
        public RoundResult Result { get; set; }

        public Round(Card player1Card, Card player2Card)
        {
            Player1Card = player1Card;
            Player2Card = player2Card;
            Result = EvaluateRound();
        }

        private RoundResult EvaluateRound()
        {
            if ((int)Player1Card.Rank > (int)Player2Card.Rank)
                return RoundResult.Player1Wins;

            if ((int)Player1Card.Rank < (int)Player2Card.Rank)
                return RoundResult.Player2Wins;

            return RoundResult.Draw;
        }
    }
}