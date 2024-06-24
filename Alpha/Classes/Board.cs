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
                    Grid[i, j] = ' ';
                }
            }
        }

        private char GetCell(int row, int col)
        {
            return Grid[row, col];
        }

        private void SetCell(int row, int col, Player player)
        {
            Grid[row, col] = player.Team;
        }
    }
}
