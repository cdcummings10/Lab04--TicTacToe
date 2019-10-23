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
        [Fact]
        public void CheckIfPlayersSwitchBetweenTurns()
        {
            Board board = new Board();
            string[,] checkBoard ={
                { "X", "X", "O"},
                { "X", "O", "6"},
                { "O", "8", "9"},
                };
            board.GameBoard = checkBoard;
            Player playerOne = new Player("Player 1", "X");
            playerOne.IsTurn = true;
            Player playerTwo = new Player("Player 2", "O");
            Game game = new Game(playerOne, playerTwo);
            game.Board = board;
            game.SwitchPlayer();
            Assert.Equal(playerTwo, game.NextPlayer());
        }
        [Fact]
        public void CheckIfPlayersSwitchBetweenTurnsFalse()
        {
            Board board = new Board();
            string[,] checkBoard ={
                { "X", "X", "O"},
                { "X", "O", "6"},
                { "O", "8", "9"},
                };
            board.GameBoard = checkBoard;
            Player playerOne = new Player("Player 1", "X");
            playerOne.IsTurn = false;
            Player playerTwo = new Player("Player 2", "O");
            Game game = new Game(playerOne, playerTwo);
            game.Board = board;
            game.SwitchPlayer();
            Assert.NotEqual(playerTwo, game.NextPlayer());
        }
        [Fact]
        public void CheckIfPositionPickedHasCorrectCoordinates()
        {
            Board board = new Board();
            string[,] checkBoard ={
                { "X", "X", "O"},
                { "X", "O", "6"},
                { "O", "8", "9"},
                };
            board.GameBoard = checkBoard;
            Player playerOne = new Player("Player 1", "X");
            playerOne.IsTurn = true;
            Player playerTwo = new Player("Player 2", "O");
            Game game = new Game(playerOne, playerTwo);
            game.Board = board;
            Assert.Equal(new Position(1, 2).Row, Player.PositionForNumber(6).Row);
            Assert.Equal(new Position(1, 2).Column, Player.PositionForNumber(6).Column);
        }


    }
}
