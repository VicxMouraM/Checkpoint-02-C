namespace CardGame.Models
{
    public class Player
    {
        public string Name { get; set; }
        public Hand Hand { get; set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Hand = new Hand();
            Score = 0;
        }
    }
}