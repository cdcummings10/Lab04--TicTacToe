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

        // TODO: Setup your game. Create a new method that creates your players 
        // and instantiates the game class. Call that method in your Main method.
        // You are requesting a Winner to be returned, Determine who the winner 
        // is output the celebratory message to the correct player. If it's a draw, 
        // tell them that there is no winner. 
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
