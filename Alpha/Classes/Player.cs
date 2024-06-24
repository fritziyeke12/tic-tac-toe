using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.Classes
{
    internal class Player
    {
        public string Name { get; set; }
        public char Team { get; set; }
        public bool Victor = false;
        public int[] PlayerMove = new int[2];
        public bool IsTurn = false;

        public Player()
        {
            Name = "Player";
        }

        public void MakeMove()
        {

        }
        
    }
}
