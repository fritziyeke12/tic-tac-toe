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

        public void Start()
        {
            gameOn = true;

            while(gameOn)
            {
                Console.WriteLine("");
            }
        }
    }
}
