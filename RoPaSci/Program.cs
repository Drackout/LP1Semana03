using System;
using System.Reflection;
using RoPaSci;

namespace RoPaSci
{
    class Program
    {
        private static void Main(string[] args)
        {
            GameItem[] playerItem = {Enum.Parse<GameItem>(args[0]), 
            Enum.Parse<GameItem>(args[1])};

            GameStatus result = RockPaperScissors(playerItem[0], playerItem[1]);
            switch (result)
            {
                case GameStatus.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static GameStatus RockPaperScissors(GameItem player1, 
                                                    GameItem player2)
        {
            GameStatus winner;
            if (player1 == player2)
            {
                winner = GameStatus.Draw; // Draw
            }
            else if (((player1 == GameItem.Rock) && 
                      (player2 == GameItem.Scissors)) 
                      ||
                      ((player1 == GameItem.Scissors) && 
                      (player2 == GameItem.Paper)) 
                      || 
                      ((player1 == GameItem.Paper) && 
                      (player2 == GameItem.Rock)))
            {
                winner = GameStatus.Player1Wins; // Player 1 wins
            }
            else
            {
                winner = GameStatus.Player2Wins; // Player 2 wins
            }
            return winner;
        }
    }
}
