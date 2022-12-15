using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Consolegoose_game
{
    public class Player
    {
        public string Name { get; set; }
        public int Position { get; set; }


        public Player(string name)
        {
            Name = name;
        }

        public void DiceDraw6()
        {
            var dice = new Dice();
            var positioncase = dice.Throw();
            Console.WriteLine("le joueur " + Name + " a fait " + positioncase);
            Position += positioncase;
            Console.WriteLine("le joueur " + Name + " est sur la case " + Position);
        }
        public void DiceDraw9()
        {
            var dice = new Dice();
            var positioncase = dice.ThrowTwo();
            Console.WriteLine("le joueur " + Name + " a fait " + positioncase);
            Position += positioncase;
            Console.WriteLine("le joueur " + Name + " est sur la case " + Position);
        }

    }
}
