using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToe
    { 
         public const int ROW = 3;
        public const int COLUMN = 3;
    
        public char[] board;
        public char[] CreateBoard()
        {


            board = new char[10];
            for (int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }
            Console.WriteLine("Empty board created");
            return board;
        }
        public char SelectOption()
        {
            Console.WriteLine("Enter your choice as X or O");
            char choice = Convert.ToChar(Console.ReadLine());

            if (char.ToUpper(choice) != 'X' && char.ToUpper(choice) != 'O')
            {
                Console.WriteLine("Enter either X or O");
                choice = SelectOption();
            }

            return char.ToUpper(choice);

        }
        public void DisplayBoard(char[] board)
        {
            int row = 0;
            int column = 0;
            int position = 1;
            Console.WriteLine("-------------");
            while (row != ROW)
            {
                column = 0;
                while (column != COLUMN)
                {
                    Console.Write(" {0} |", board[position]);
                    position++;
                    column++;
                }
                Console.WriteLine();
                Console.WriteLine("-------------");
                row++;
            }
        }

        public char[] MovePosition(char[] board, char symbol)
        {
            //int position = 1;
            DisplayBoard(board);
            Console.WriteLine("Enter your choice of position");
            int posChoice = Convert.ToInt32(Console.ReadLine());
            if (board[posChoice] == ' ')
            {
                board[posChoice] = symbol;
            }
            else
            {
                Console.WriteLine("Position is already occupied.\nChoose another position");
                board = MovePosition(board, symbol);

            }
            DisplayBoard(board);
            return board;
        }
    }

}

