using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.Classes
{
    internal class Game
    {
        public Board Board;
        public Player Player1;
        public Player Player2;
        public bool gameOn;

        public Game(string player1Name, string player2Name, char player1Team, char player2Team)
        {
            Player1 = new Player(player1Name, player1Team);
            Player1.IsTurn = true;

            Player2 = new Player(player2Name, player2Team);
            Board = new Board();
        }

        public void Start()
        {
            gameOn = true;

            /*while(gameOn)
            {
                Console.WriteLine("");
            }*/

            Console.WriteLine($"Welcome to Noughts and Crosses {Player1.Name} and {Player2.Name}. You know the rules, so lets get started!");
        }

        public void NewRound()
        {
            int row;
            int col;

            //Board.ShowGrid();

            if (Player1.IsTurn && gameOn)
            {
                /*Console.WriteLine($"It's your turn {Player1.Name}! Enter the row and column number for where you would like to move below.");
                Console.WriteLine("Enter row: ");
                row = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter col: ");
                col = int.Parse(Console.ReadLine());

                Board.SetCell(row, col, Player1.Team);
                Board.ShowGrid();*/

                Board.MakeMove(Player1);

                if (Board.CheckBoard())
                {
                    gameOn = false;
                }

                Player1.IsTurn = false;
                Player2.IsTurn = true;
            }

            if (Player2.IsTurn && gameOn)
            {
                /*Console.WriteLine($"It's your turn {Player2.Name}! Enter the row and column number for where you would like to move below.");
                Console.WriteLine("Enter row: ");
                row = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter col: ");
                col = int.Parse(Console.ReadLine());

                Board.SetCell(row, col, Player2.Team);
                Board.ShowGrid();*/

                Board.MakeMove(Player2);

                if (Board.CheckBoard())
                {
                    gameOn = false;
                }

                Player2.IsTurn = false;
                Player1.IsTurn = true;
            }

        }

        public void CheckGame()
        {
            if (Board.CheckBoard())
            {
                gameOn = false;
            }
        }

        public void Over()
        {
            Console.WriteLine($"Game over!! Team {Board.victor} wins!");
        }
    }
}
