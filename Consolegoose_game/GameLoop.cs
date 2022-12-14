using System;
namespace Consolegoose_game
{
	public class GameLoop
	{
        //protrietes
        public List<Player> Players { get; }
        public bool IsGameFinished { get; set; }


        //constructeur
        public GameLoop(List<Player> players)
        {
            Players = players;
            IsGameFinished = false;
        }
        //methode
        //lancement game(boucle game)
        public void StartGame()
        {
            while (!IsGameFinished)
            {
                foreach(var player in Players)
                {
                    player.DiceDraw();
                    Console.ReadLine();
                    if (player.Position == 50)
                    {
                        IsGameFinished = true;
                        Console.WriteLine("Finish!! Is Winner player " + player.Name + " 🎉.");

                    }
        //les conditions
                    if (player.Position > 50) player.Position = 25;
                    if (player.Position == 37) player.Position = 12;
                    if (player.Position == 14) player.Position = 7;
                    if (player.Position == 46) player.Position = 33;
                    if (player.Position == 20) player.Position = 35;
                    if (player.Position == 2) player.Position = 17;
                    if (player.Position == 31) player.Position = 43;
                    if (player.Position == 49) player.Position = 1;


                }

            }
        }
    }
}

