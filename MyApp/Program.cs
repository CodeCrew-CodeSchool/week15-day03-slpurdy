using System;

namespace tictactoe
{
    class Player
    {
        public string id;
        public string marker;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Purdy tic tac toe game!\n");
            Console.WriteLine("Press key to continue");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("You are player 1. You will be using X\n");
            Console.WriteLine("Press key to continue");
            Console.ReadLine();
            Console.Clear();

            string[][] gameBoard = new string[][]
            {
                new string[] { "1", "2", "3" },
                new string[] { "4", "5", "6" },
                new string[] { "7", "8", "9" }
            };

            Player player1 = new Player { id = "1", marker = "X" };
            Player player2 = new Player { id = "2", marker = "O" };

            Player currentPlayer = player1;
            bool gameOver = false;
            while (!gameOver)
            {
                Console.WriteLine("My Purdy Tic Tac Toe\n");
                DisplayBoard(gameBoard);

                Console.WriteLine($"\nPlayer {currentPlayer.id}. Make a move!");
                string playerChoice = Console.ReadLine();
                try
                {
                    MarkBoard(playerChoice, currentPlayer, gameBoard);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                Console.Clear();

                if (CheckForWinner(gameBoard))
                {
                    Console.WriteLine($"Player {currentPlayer.id} wins!");
                    DisplayBoard(gameBoard);
                    gameOver = true;
                }
                else
                {
                    // Switch the current player
                    currentPlayer = currentPlayer.id == "1" ? player2 : player1;
                }
            }
        }

        static void DisplayBoard(string[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                string[] row = board[i];
                for (int x = 0; x < row.Length; x++)
                {
                    string value = row[x];
                    Console.Write("|" + value + "|");
                }
                Console.WriteLine();
            }
        }

        static void MarkBoard(string playerChoice, Player currentPlayer, string[][] gameBoard)
        {
            if (playerChoice == "1")
            {
                if (gameBoard[0][0] == "X" || gameBoard[0][0] == "O")
                {
                    throw new Exception("Spot is already taken");
                }
                gameBoard[0][0] = currentPlayer.marker;
            }
            else if (playerChoice == "2")
            {
                if (gameBoard[0][1] == "X" || gameBoard[0][1] == "O")
                {
                    throw new Exception("Spot is already taken");
                }
                gameBoard[0][1] = currentPlayer.marker;
            }
            else if (playerChoice == "3")
            {
                if (gameBoard[0][2] == "X" || gameBoard[0][2] == "O")
                {
                    throw new Exception("Spot is already taken");
                }
                gameBoard[0][2] = currentPlayer.marker;
            }
            else if (playerChoice == "4")
            {
                if (gameBoard[1][0] == "X" || gameBoard[1][0] == "O")
                {
                    throw new Exception("Spot is already taken");
                }
                gameBoard[1][0] = currentPlayer.marker;
            }
            else if (playerChoice == "5")
            {
                if (gameBoard[1][1] == "X" || gameBoard[1][1] == "O")
                {
                    throw new Exception("Spot is already taken");
                }
                gameBoard[1][1] = currentPlayer.marker;
            }
            else if (playerChoice == "6")
            {
                if (gameBoard[1][2] == "X" || gameBoard[1][2] == "O")
                {
                    throw new Exception("Spot is already taken");
                }
                gameBoard[1][2] = currentPlayer.marker;
            }
            else if (playerChoice == "7")
            {
                if (gameBoard[2][0] == "X" || gameBoard[2][0] == "O")
                {
                    throw new Exception("Spot is already taken");
                }
                gameBoard[2][0] = currentPlayer.marker;
            }
            else if (playerChoice == "8")
            {
                if (gameBoard[2][1] == "X" || gameBoard[2][1] == "O")
                {
                    throw new Exception("Spot is already taken");
                }
                gameBoard[2][1] = currentPlayer.marker;
            }
            else if (playerChoice == "9")
            {
                if (gameBoard[2][2] == "X" || gameBoard[2][2] == "O")
                {
                    throw new Exception("Spot is already taken");
                }
                gameBoard[2][2] = currentPlayer.marker;
            }
        }

        static bool CheckForWinner(string[][] board)
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i][0] == board[i][1] && board[i][1] == board[i][2])
                {
                    return true;
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (board[0][i] == board[1][i] && board[1][i] == board[2][i])
                {
                    return true;
                }
            }

            // Check diagonals
            if (board[0][0] == board[1][1] && board[1][1] == board[2][2])
            {
                return true;
            }

            if (board[0][2] == board[1][1] && board[1][1] == board[2][0])
            {
                return true;
            }

            return false;
        }
    }
}
