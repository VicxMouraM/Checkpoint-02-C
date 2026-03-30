using CardGame.Models;
using CardGame.Enums;
using System;

Player player1 = new Player("Jogador 1");
Player player2 = new Player("Jogador 2");

Match match = new Match(player1, player2);
match.StartMatch();

Console.WriteLine("=== JOGO DE CARTAS ===");
Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    Round round = match.PlayRound();

    Console.WriteLine($"Rodada {i + 1}");
    Console.WriteLine($"{player1.Name} jogou: {round.Player1Card}");
    Console.WriteLine($"{player2.Name} jogou: {round.Player2Card}");

    switch (round.Result)
    {
        case RoundResult.Player1Wins:
            Console.WriteLine("Resultado: Jogador 1 venceu a rodada.");
            break;
        case RoundResult.Player2Wins:
            Console.WriteLine("Resultado: Jogador 2 venceu a rodada.");
            break;
        default:
            Console.WriteLine("Resultado: Empate.");
            break;
    }

    Console.WriteLine();
}

Console.WriteLine("=== PLACAR FINAL ===");
Console.WriteLine($"{player1.Name}: {player1.Score}");
Console.WriteLine($"{player2.Name}: {player2.Score}");

if (player1.Score > player2.Score)
    Console.WriteLine("Vencedor da partida: Jogador 1");
else if (player2.Score > player1.Score)
    Console.WriteLine("Vencedor da partida: Jogador 2");
else
    Console.WriteLine("A partida terminou empatada.");