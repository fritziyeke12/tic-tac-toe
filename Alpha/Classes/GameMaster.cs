using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha.Classes
{
    internal class GameMaster
    {
        public Game Game = new Game();
        public bool Play;
        public string Instructions = "The usual rules for noughts and crosses, I'm sure you know them!";

        public GameMaster()
        {
            Play = true;
        }

        public void NextTurn(Player player1, Player player2)
        {
            if (player1.IsTurn)
            {
                player1.MakeMove();
            }
            else if (player2.IsTurn)
            {
                player2.MakeMove();
            }
        }

        public string Announce(Player player1, Player player2)
        {
            //return $"{(player1.IsTurn ? player2.Name : player1.Name)} just made a move on {(player1.IsTurn ? player2.PlayerMove : player1.PlayerMove)}";
            if (!player1.IsTurn)
            {
                return $"{player2.Name} just made a move on [{player2.PlayerMove[0]},{player2.PlayerMove[1]}].\n\nYour turn {player1.Name}";
            }
            else /*if (!player2.IsTurn)*/
            {
                return $"{player1.Name} just made a move on [{player1.PlayerMove[0]},{player1.PlayerMove[1]}].\n\nYour turn {player2.Name}";
            }
        }

        public void CheckVictor(Player player1, Player player2)
        {
            if (player1.Victor)
            {
                Game.Over();
            }
            else if (player2.Victor)
            {
                Game.Over();
            }
        }
    }
}
