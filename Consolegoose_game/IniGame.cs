using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolegoose_game
{
    public class IniGame
    {
        public static void Initialization()
        {
            var players = AskAllPlayerInformation();
            var gameLoop =new GameLoop(players);
            gameLoop.StartGame();


        }
        public static List<Player> AskAllPlayerInformation()
        {
            var players = new List<Player>();
            var playerCount = AskPlayerNumber();
            for(int i = 0; i < playerCount; i++)
            {
                players.Add(AskOnePlayerInformation(i));
            }
            return players;
        }
        public static Player AskOnePlayerInformation(int numberPlayer)
        {
            Console.WriteLine("Entrer le nom du joueur");
            var playername = Convert.ToString(Console.ReadLine());
            return new Player(playername);
        }
        public static int AskPlayerNumber ()
        {
            Console.WriteLine("Bienvenue dans le goose game!!!!\nCombien de joueur ete vous ?");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
