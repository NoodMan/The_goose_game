using System;
namespace Consolegoose_game
{
	public class Dice
	{
		//proprietes
		private Random random = new Random();


		//methode
		public int Throw()
		{
			return random.Next(1, 6);

        }
        public int ThrowTwo()
        {
            return random.Next(2, 9);

        }

    }

}

