using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            PlayGame();
        }

        /// <summary>
        /// Creates two new Player objects and sets one Player.IsTurn to true. Creates a new Game object
        /// with the two players as parameters. Plays game.
        /// </summary>
        static void PlayGame()
        {
            Player player1 = new Player("Player 1", "X");
            Player player2 = new Player("Player 2", "O");
            player1.IsTurn = true;
            player2.IsTurn = false;
            Game game = new Game(player1, player2);
            game.Play();
        }
    }
}
