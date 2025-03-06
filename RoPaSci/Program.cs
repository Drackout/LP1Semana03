using System;
using System.Reflection;
using RoPaSci;

namespace RoPaSci
{
    class Program
    {
        private static void Main(string[] args)
        {
            GameItem playr1Item = Enum.Parse<GameItem>(args[0]);
            GameItem playr2Item = Enum.Parse<GameItem>(args[1]);

            GameItem xxx;
            

            int result = RockPaperScissors(playr1Item, playr2Item);
            switch (result)
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static int RockPaperScissors(GameItem player1, GameItem player2)
        {
                    Console.WriteLine(player1);

            int winner;
            if (player1 == player2)
            {
                winner = 0; // Draw
            }
            else if (((player1 == Enum.Parse<GameItem>("Rock")) && 
                      (player2 == Enum.Parse<GameItem>("Scissors"))) ||
                      ((player1 == Enum.Parse<GameItem>("Scissors")) && 
                      (player2 == Enum.Parse<GameItem>("Paper"))) || 
                      ((player1 == Enum.Parse<GameItem>("Paper")) && 
                      (player2 == Enum.Parse<GameItem>("Rock"))))
            {
                winner = 1; // Player 1 wins
            }
            else
            {
                winner = 2; // Player 2 wins
            }
            return winner;
        }
    }
}
