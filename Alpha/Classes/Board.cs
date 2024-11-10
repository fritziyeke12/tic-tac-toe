using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.Classes
{
    internal class Board
    {
        public char[,] Grid { get; set; }
        public bool gameOver = false;
        public char victor = '_';

        public Board()
        {
            Grid = new char[3,3];
            LoadGrid();
        }

        private void LoadGrid()
        {
            for (int i = 0; i < 3;  i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Grid[i, j] = '_';
                }
            }
        }

        private char GetCell(int row, int col)
        {
            return Grid[row, col];
        }

        public void ShowGrid()
        {
            Console.WriteLine("Current Board: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Grid[i,j]);
                }
                Console.Write("\n");
            }
        }

        public void SetCell(int row, int col, char team)
        {
            /*if(row > 3 || row < 1 || col > 3 || col < 1)
            {
                Console.WriteLine("There are only 3 rows and columns in this board!");
                SetCell(row, col, team);
            }

            if (Grid[row -1, col -1] != '_')
            {
                Console.WriteLine("Sorry, another player already moved here!");
                SetCell(row, col, team);
            }
*/
            Grid[row - 1, col - 1] = team;
        }

        public void MakeMove(Player player)
        {
            int row;
            int col;
            bool isMoveValid = false;
                        

            while(!isMoveValid)
            {
                ShowGrid();

                Console.WriteLine($"It's your turn {player.Name}! Enter the row and column number for where you would like to move below.");

                Console.WriteLine("Row (1-3): ");
                row = int.Parse(Console.ReadLine());

                Console.WriteLine("Col (1-3): ");
                col = int.Parse(Console.ReadLine());

                if (row > 3 || row < 1 || col > 3 || col < 1)
                {
                    Console.WriteLine("There are only 3 rows and columns in this board!");
                    continue;
                }

                if (Grid[row - 1, col - 1] != '_')
                {
                    Console.WriteLine("Sorry, another player already moved here!");
                    continue;
                }

                SetCell(row, col, player.Team);

                //ShowGrid();

                isMoveValid = true;
            }
            
        }

        public bool CheckRows(int colIndex)
        {
            char symbol = Grid[colIndex, 0] != '_' ? Grid[colIndex, 0] : '_' ;

            if(symbol == '_')
            {
                return gameOver;
            }

            for(int i = 1; i < Grid.Length; i++)
            {
                if(symbol != Grid[colIndex, i])
                {
                    return gameOver;
                }
                victor = symbol;
                gameOver = true;
            }

            return gameOver;
        }

        public bool CheckCols(int colIndex)
        {
            char symbol = Grid[0, colIndex] != '_' ? Grid[0, colIndex] : '_';

            if (symbol == '_')
            {
                return gameOver;
            }

            for (int i = 1; i < Grid.Length; i++)
            {
                if (symbol != Grid[i, colIndex])
                {
                    return gameOver;
                }
                victor = symbol;
                gameOver = true;
            }

            return gameOver;
        }

        public bool CheckBoard()
        {
            
            if (Grid[0,0] == Grid[1,1] && Grid[1,1] == Grid[2, 2])
            {
                if (Grid[0, 0] != '_')
                {
                    victor = Grid[0, 0];
                    gameOver = true;
                }                
            }

            if (Grid[0, 2] == Grid[1, 1] && Grid[1, 1] == Grid[2, 0])
            {
                if (Grid[0, 2] != '_')
                {
                    victor = Grid[0, 2];
                    gameOver = true;
                }                
            }




            gameOver = CheckRows(0);
            gameOver = CheckRows(1);
            gameOver = CheckRows(2);

            gameOver = CheckCols(0);
            gameOver = CheckCols(1);
            gameOver = CheckCols(2);


            return gameOver;
        }
    }
}
