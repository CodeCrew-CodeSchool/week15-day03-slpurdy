using System;

namespace TicTacToe
{
    class Program
    {
        static string[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static string currentPlayer = "X";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Purdy Tic Tac Toe!\n\n");

            while (true)
            {
                DisplayBoard();
                Console.WriteLine($"{currentPlayer}'s turn. Select a position (1-9):");
                string input = Console.ReadLine();

                int position = 0;
                if (input == "1")
                    position = 1;
                else if (input == "2")
                    position = 2;
                else if (input == "3")
                    position = 3;
                else if (input == "4")
                    position = 4;
                else if (input == "5")
                    position = 5;
                else if (input == "6")
                    position = 6;
                else if (input == "7")
                    position = 7;
                else if (input == "8")
                    position = 8;
                else if (input == "9")
                    position = 9;
                else
                {
                    Console.WriteLine("Invalid input :( Please try again.");
                    continue;
                }

                if (UpdateBoard(position, currentPlayer))
                {
                    if (CheckWin(currentPlayer))
                    {
                        DisplayBoard();
                        Console.WriteLine($"{currentPlayer} wins!");
                        break;
                    }
                    else if (IsBoardFull())
                    {
                        DisplayBoard();
                        Console.WriteLine("It's a tie!");
                        break;
                    }

                    SwitchPlayer();
                }
                else
                {
                    Console.WriteLine("Position taken :( Please try again.");
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DisplayBoard()
        {
            Console.WriteLine($"|{board[0]}||{board[1]}||{board[2]}|");
            Console.WriteLine($"|{board[3]}||{board[4]}||{board[5]}|");
            Console.WriteLine($"|{board[6]}||{board[7]}||{board[8]}|");
        }

        static bool UpdateBoard(int position, string marker)
        {
            if (board[position - 1] != "X" && board[position - 1] != "O")
            {
                board[position - 1] = marker;
                return true;
            }
            return false;
        }

        static bool IsBoardFull()
        {
            foreach (string pos in board)
            {
                if (pos != "X" && pos != "O")
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckWin(string marker)
        {
            int[,] winPatterns = new int[,]
            {
                { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },
                { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },
                { 0, 4, 8 }, { 2, 4, 6 }
            };

            for (int i = 0; i < winPatterns.GetLength(0); i++)
            {
                if (board[winPatterns[i, 0]] == marker &&
                    board[winPatterns[i, 1]] == marker &&
                    board[winPatterns[i, 2]] == marker)
                {
                    return true;
                }
            }
            return false;
        }

        static void SwitchPlayer()
        {
            currentPlayer = (currentPlayer == "X") ? "O" : "X";
        }
    }
}
