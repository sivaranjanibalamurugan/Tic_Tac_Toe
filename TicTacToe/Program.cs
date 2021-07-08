using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!!");
            TicTacToe ticTacToe = new TicTacToe();
            
            char[] board = ticTacToe.CreateBoard();
            char playerChoice = ticTacToe.SelectOption();
            char computerChoice = playerChoice == 'X' ? 'O' : 'X';
            Console.WriteLine("Player choice:{0} Computer Choice:{1}", playerChoice, computerChoice);
        }
    }
}
