using System;
using Xunit;
using static Lab04_TicTacToe.Program;
using Lab04_TicTacToe.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CheckIfBoardHasAWinner()
        {
            Board board = new Board();
            string[,] checkBoard ={
                { "X", "X", "O"},
                { "X", "O", "6"},
                { "O", "8", "9"},
                };
            board.GameBoard = checkBoard;
            Player playerOne = new Player("Player 1", "X"); 
            Player playerTwo = new Player("Player 2", "O");
            Game game = new Game(playerOne, playerTwo);
            game.Board = board;
            Assert.True(game.CheckForWinner(board));
        }

    }
}
