using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.Classes
{
    internal class GameMaster
    {
        public Game Game;
        public bool Play;
        public string Instructions = "The usual rules for noughts and crosses, I'm sure you know them!";

        public GameMaster()
        {
            Play = true;
        }

        public void NextTurn()
        {

        }

        public string Announce()
        {
            return $"";
        }

        public void CheckVictor(Player player1, Player player2)
        {

        }
    }
}
