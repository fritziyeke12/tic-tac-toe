using Alpha.Classes;

namespace Alpha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Player 1 enter your name: ");
            string p1Name = Console.ReadLine();

            Console.WriteLine("Player 2 enter your name: ");
            string p2Name = Console.ReadLine();

            Game game = new Game(p1Name, p2Name, 'X', 'O');

            game.Start();

            while (game.gameOn)
            {
                game.NewRound();
                //game.CheckGame();
            }

            game.Over();
        }
    }
}